using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Category : System.Web.UI.Page
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

        }
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "")
        {
            string j = "SELECT TOP 1 cid from Category ORDER BY cid DESC";
            SqlDataAdapter da = new SqlDataAdapter(j,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            int i = 1;
            if (c > 0)
            {
                i=Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString())+1;
            }
            else
            {
                i = 1;
            }
            string k = "INSERT INTO Category VALUES('" + i.ToString() + "','" + TextBox1.Text + "','" + TextBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(k,conn);
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