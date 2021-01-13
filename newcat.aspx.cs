using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class newcat : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["type"].ToString() != "admin")
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {
            string k = Session["cid"].ToString();
            string j = "SELECT * FROM Category where cid='" + k + "'";
            SqlDataAdapter da = new SqlDataAdapter(j,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            if (c > 0)
            {
                TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "")
        {

            string k = "UPDATE Category SET Category='" + TextBox1.Text + "',SubCategory='" + TextBox2.Text + "' where cid='" + Session["cid"].ToString()+ "'";
            SqlCommand cmd = new SqlCommand(k, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Session["Add"] = "Data";
            Response.Redirect("AddCategory.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Enter Data');", true);
        }
    }
}