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
    public partial class WebForm1 : System.Web.UI.Page
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
                LoadRecipeGrid();

            }

        }
        protected void LoadRecipeGrid() {
            cn.Open();
            string sql = "SELECT RecipeName, RecipeDesc, RecipeCategory from Recipes";

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }

            cn.Close();
            rcp.DataSource = dt;
            rcp.DataBind();
        
        
        
        }
    }
}