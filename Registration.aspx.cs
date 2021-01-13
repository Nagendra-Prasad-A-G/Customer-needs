using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string k = "SELECT TOP 1 Uid from [User] ORDER BY Uid DESC";
            SqlDataAdapter da = new SqlDataAdapter(k,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = 101;
            int c = ds.Tables[0].Rows.Count;
            if (c > 0)
            {
                i = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString())+1;
            }
            else
            {
                i = 101;
            }
            TextBox1.Text = i.ToString();
        }
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "")
        {
            string k = "INSERT INTO [User] VALUES('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+RadioButtonList1.SelectedItem.Text+"','"+TextBox6.Text+"','"+TextBox7.Text+"')";
            SqlCommand cmd = new SqlCommand(k,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("UserLogin.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Enter Details.')", true);
        }
    }
}