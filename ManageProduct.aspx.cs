using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ManageProduct : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string k = "SELECT * FROM Product";
            SqlDataAdapter da = new SqlDataAdapter(k, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            if (c > 0)
            {
                GridView1.Visible = true;
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('No Data Available');", true);
                GridView1.Visible = false;
            }
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddProduct.aspx");
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "yes")
        {
            string i2 = Convert.ToString(e.CommandArgument.ToString());
            string mm = "DELETE FROM Product where Pid='" + i2 + "'";
            SqlCommand cmd = new SqlCommand(mm, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("ManageProduct.aspx");
        }
    }
}