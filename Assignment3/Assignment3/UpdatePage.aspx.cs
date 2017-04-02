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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection cnMovie = new SqlConnection();
        DataTable movietable = new DataTable();
        DataTable atable = new DataTable();
        DataTable ptable = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            var cstr = System.Configuration.ConfigurationManager.ConnectionStrings["movieDBCN"];
            string strConn = cstr.ConnectionString;
            cnMovie = new SqlConnection(strConn);
            if (!IsPostBack)
            {
                LoadTable();
                LoadCurrentMovies();
                LoadDirector();
                LoadGenre();

               LoadDDandDetail(); // fordelete
            }

        }
        protected void LoadTable()
        {
            cnMovie.Open();
            movietable.Clear();
            string sql = "SELECT       Director.DirectorID, Director.DirectorName,Movie.MovieID, Movie.MovieTitle, Movie.ReleaseDate,Genre.GenreID, Genre.GenreType " +
                         "FROM            Director INNER JOIN " +
                          "Movie ON Director.DirectorID = Movie.DirectorID INNER JOIN " +
                          "Genre ON Movie.GenreID = Genre.GenreID";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                movietable.Load(dr);
                dr.Close();
            }

            cnMovie.Close();

        }
        protected void LoadCurrentMovies()
        {

            allGrid.DataSource = movietable;
            allGrid.DataBind();


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
            dList.DataSource = atable;
            dList.DataTextField = "DirectorName";
            dList.DataValueField = "DirectorID";
            dList.DataBind();
        }
        protected void LoadGenre()
        {
            ptable.Clear();
            cnMovie.Open();
            string sql = "select * from Genre";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                ptable.Load(dr);
                dr.Close();
            }

            cnMovie.Close();
            gList.DataSource = ptable;
            gList.DataTextField = "GenreType";
            gList.DataValueField = "GenreID";
            gList.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            bool idInvalid = false;
            bool idFound = false;
            bool listSelect = false;
            LoadTable();
            if (bid.Value == "" || bname.Value == "" || dDate.Value == "")
            {

                idInvalid = true;

            }

            for (int crow = 0; crow < movietable.Rows.Count; crow++)
            {

                if (movietable.Rows[crow][0].ToString() == bid.Value)
                {

                    idFound = true;
                }

            }

            if (idInvalid)
            {
                Response.Write("<script> alert('Invalid ID')</script>");

            }
            else if (idFound)
            {
                Response.Write("<script> alert('ID found')</script>");
            }
            else if (dList.SelectedValue == "" || gList.SelectedValue == "")
            {
                listSelect = true;
                Response.Write("<script> alert('Select director and Genre')</script>");
            }

            if (!idInvalid && !idFound && !listSelect)
            {

                
                UpdateMovie(bid.Value, bname.Value, dDate.Value,  gList.SelectedValue, dList.SelectedValue);
                ResetAll();

            }
        }
       
        protected void UpdateMovie(string bid, string aid, string date, string gen, string dir)
        {
            cnMovie.Open();
            string sql = "Insert into Movie (MovieID, MovieTitle, ReleaseDate, GenreID, DirectorID) Values (@bid, @aid, @date, @gen, @dir)";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                cmd.Parameters.Add("@bid", SqlDbType.VarChar);
                cmd.Parameters["@bid"].Value = bid;

                cmd.Parameters.Add("@aid", SqlDbType.VarChar);
                cmd.Parameters["@aid"].Value = aid;

                cmd.Parameters.Add("@date", SqlDbType.VarChar);
                cmd.Parameters["@date"].Value = date;

                cmd.Parameters.Add("@gen", SqlDbType.VarChar);
                cmd.Parameters["@gen"].Value = gen;

                cmd.Parameters.Add("@dir", SqlDbType.VarChar);
                cmd.Parameters["@dir"].Value = dir;


                cmd.ExecuteNonQuery();


            }
            cnMovie.Close();

        }
        protected void ResetAll()
        {
            bid.Value = "";
            bname.Value = "";
            dDate.Value = "";
            dList.ClearSelection();
            gList.ClearSelection();

            LoadTable();
            LoadCurrentMovies();
            LoadDirector();
            LoadGenre();
            LoadDDandDetail();

        }

        protected void LoadDDandDetail()
        {
            movieDD.DataSource = movietable;

            //what is shown in dropdown and what is the search key
            movieDD.DataTextField = "MovieTitle";//must match the databasename
            movieDD.DataValueField = "MovieID";
            movieDD.DataBind();

            movieDD.DataBind();

            LoadDetail();
        }

        protected void movieDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetail();
        }

        protected void LoadDetail()
        {
            cnMovie.Open();
            DataTable dtable = new DataTable();
            string sql = "SELECT        Director.DirectorName, Director.DirectorNationality, Movie.MovieTitle, Movie.ReleaseDate, Genre.GenreType " +
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
        protected void delete_Click(object sender, EventArgs e)
        {
            

            try
            {
                
                deleteMovie();
                ResetAll();

              

            }
            catch
            {
                Response.Write("<script>alert('Movie delete error');</script>");

            }
        }
        protected void deleteMovie()
        {
            cnMovie.Open();
            string sql = "Delete from Movie where MovieID = @bid ";
            using (SqlCommand cmd = new SqlCommand(sql, cnMovie))
            {
                cmd.Parameters.Add("@bid", SqlDbType.VarChar);
                cmd.Parameters["@bid"].Value = movieDD.SelectedValue;




                cmd.ExecuteNonQuery();


            }
            cnMovie.Close();
             
              }

        }
    }
