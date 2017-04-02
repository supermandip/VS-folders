using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection cnMovie = new SqlConnection();
        DataTable booktable = new DataTable();
        DataTable atable = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            var cstr = System.Configuration.ConfigurationManager.ConnectionStrings["movieDBCN"];
            string strConn = cstr.ConnectionString;
            cnMovie = new SqlConnection(strConn);
            if (!IsPostBack)
            {
                LoadTable();
                LoadDirector();
                LoadDetail();
            }


        }
        protected void LoadTable()
        {
            cnMovie.Open();
            booktable.Clear();
            string sql = "SELECT       Director.DirectorID, Director.DirectorName,Movie.MovieID, Movie.MovieTitle, Movie.ReleaseDate,Genre.GenreID, Genre.GenreType " +
                         "FROM            Director INNER JOIN " +
                          "Movie ON Director.DirectorID = Movie.DirectorID INNER JOIN " +
                          "Genre ON Movie.GenreID = Genre.GenreID";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                booktable.Load(dr);
                dr.Close();
            }

            cnMovie.Close();

        }
        protected void LoadOne(string x)
        {
            cnMovie.Open();
            DataTable dtable = new DataTable();
            string sql = "SELECT        Director.DirectorName, Director.DirectorNationality, Movie.MovieTitle, Movie.ReleaseDate, Genre.GenreType " +
                        "FROM            Director INNER JOIN " +
                         "Movie ON Director.DirectorID = Movie.DirectorID INNER JOIN " +
                         "Genre ON Movie.GenreID = Genre.GenreID where Genre.GenreType = @id";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar);
                cmd.Parameters["@id"].Value = x;

                SqlDataReader dr = cmd.ExecuteReader();
                dtable.Load(dr);
                dr.Close();
            }
            GV1.DataSource = dtable;
            GV1.DataBind();
            cnMovie.Close();


        }

        protected void LoadDetail()
        {
            cnMovie.Open();
            DataTable dtable = new DataTable();
            string sql = "SELECT        Director.DirectorName, Director.DirectorNationality, Movie.MovieTitle, Movie.ReleaseDate, Genre.GenreType " +
                        "FROM            Director INNER JOIN " +
                         "Movie ON Director.DirectorID = Movie.DirectorID INNER JOIN " +
                         "Genre ON Movie.GenreID = Genre.GenreID where Director.DirectorID = @id";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar);
                cmd.Parameters["@id"].Value = dirList.SelectedValue;

                SqlDataReader dr = cmd.ExecuteReader();
                dtable.Load(dr);
                dr.Close();
            }
            GV2.DataSource = dtable;
            GV2.DataBind();
            cnMovie.Close();


        }
        protected void LoadDirector()
        {
            atable.Clear();
            cnMovie.Open();
            string sql = "select * from Director";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                atable.Load(dr);
                dr.Close();
            }

            cnMovie.Close();
            dirList.DataSource = atable;
            dirList.DataTextField = "DirectorName";
            dirList.DataValueField = "DirectorID";
            dirList.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                LoadOne(genreList.SelectedValue);
          
        }

        protected void dirList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetail();
        }
    }
}