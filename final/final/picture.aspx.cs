﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace final
{
    public partial class WebForm3 : System.Web.UI.Page
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
                LoadRecipeDD(sender, e);

            }
        }
        protected void LoadRecipeDD(object sender, EventArgs e)
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

            pdd.DataSource = dt;
            pdd.DataTextField = "RecipeName";
            pdd.DataValueField = "SName";
            pdd.DataBind();

            pdd_SelectedIndexChanged(sender, e);



        }

        protected void pdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            rpic.ImageUrl = "~/images/" + pdd.SelectedValue + ".jpg";
            rpic.Width = 300;

        }
    }
}