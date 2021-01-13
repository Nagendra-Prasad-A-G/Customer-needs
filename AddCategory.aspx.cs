using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AddCategory : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["type"].ToString() != "admin")
        {
            Response.Redirect("Login.aspx");
        }
        if(Session["Add"] == "Data")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Category details Updated');", true);
            Session["Add"] = "";
        }

        if (!IsPostBack)
        {
            string k = "SELECT * FROM Category";
            SqlDataAdapter da = new SqlDataAdapter(k, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            if (c > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
            else
            {
                GridView1.Visible = false;
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Category.aspx");
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "yes")
        {
            string i2 = Convert.ToString(e.CommandArgument.ToString());
            Session["cid"] = i2;
            Response.Redirect("newcat.aspx");
        }
    }
}