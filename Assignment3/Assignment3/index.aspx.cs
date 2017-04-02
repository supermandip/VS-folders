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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection cnMovie = new SqlConnection();
        DataTable movietable = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            var cstr = System.Configuration.ConfigurationManager.ConnectionStrings["movieDBCN"];
            string strConn = cstr.ConnectionString;
            cnMovie = new SqlConnection(strConn);
            if (!IsPostBack)
            {
                loadTable();
                loadDDandDetail();

            }

        }

        protected void loadTable()
        {
            cnMovie.Open();
            string sql = "SELECT * from Movie";

            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                movietable.Load(dr);
                dr.Close();
            }

            cnMovie.Close();

        }
        protected void loadDDandDetail()
        {
            movieDD.DataSource = movietable;
            movieDD.DataTextField = "MovieTitle";
            movieDD.DataValueField = "MovieID";
            movieDD.DataBind();

            LoadDetail();

        }
        protected void LoadDetail()
        {
            cnMovie.Open();
            DataTable dtable = new DataTable();

            string sql = "SELECT       Director.DirectorID, Director.DirectorName, Director.DirectorNationality,Movie.MovieID, Movie.MovieTitle, Movie.ReleaseDate,Genre.GenreID, Genre.GenreType " +
                        "FROM            Director INNER JOIN " +
                         "Movie ON Director.DirectorID = Movie.DirectorID INNER JOIN " +
                         "Genre ON Movie.GenreID = Genre.GenreID where Movie.MovieID = @id";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar);
                cmd.Parameters["@id"].Value = movieDD.SelectedValue;

                SqlDataReader dr = cmd.ExecuteReader();
                dtable.Load(dr);
                dr.Close();
            }
            movieDetail.DataSource = dtable;
            movieDetail.DataBind();
            cnMovie.Close();


        }

        protected void movieDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetail();
        }
    }
}