using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace final
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            var cstr = System.Configuration.ConfigurationManager.ConnectionStrings["recipesDBCN"];
            string strConn = cstr.ConnectionString;
            cn = new SqlConnection(strConn);
            if (!IsPostBack)
            {
                LoadRecipeDD();

            }

        }

        protected void LoadRecipeDD()
        {
            cn.Open();
            string sql = "SELECT * from Recipes";

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }

            cn.Close();
            loadDDandDetail();



        }
        protected void loadDDandDetail()
        {
            dd.DataSource = dt;
            dd.DataTextField = "RecipeName";
            dd.DataValueField = "Id";
            dd.DataBind();

            LoadDetail();

        }
        protected void LoadDetail()
        {
            cn.Open();
            DataTable gtable = new DataTable();
            DataTable itable = new DataTable();

            //Load recipe data based on dropdown

            string sql = "select * from Recipes where Recipes.Id = @id";
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = dd.SelectedValue;

                SqlDataReader dr = cmd.ExecuteReader();
                gtable.Load(dr);

                dr.Close();
                detail.DataSource = gtable;
                detail.DataBind();
            }

            //load ing
            string sql2 = "select Ingredient, Amount from Ingredients where Ingredients.RecipeId = @id";
            using (SqlCommand cmd = new SqlCommand(sql2, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = dd.SelectedValue;

                SqlDataReader dr = cmd.ExecuteReader();
                itable.Load(dr);

                dr.Close();
                grid.DataSource = itable;
                grid.DataBind();
            }
            

            
            cn.Close();


        }

        protected void dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetail();
        }
    }
}