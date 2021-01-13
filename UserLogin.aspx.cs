using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class UserLogin : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox6.Text != "" && TextBox7.Text != "")
        {
            string k = "SELECT * FROM [User] where Uid='" + TextBox6.Text + "' and Password='" + TextBox7.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(k, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            if (c > 0)
            {
                Session["Uid"] = TextBox6.Text;
                Session["uname"] = ds.Tables[0].Rows[0][1].ToString();
                Session["type"] = "User";
                Response.Redirect("HomeMain.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Invalid Admin ID or Password')", true);
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Enter Id and Password')", true);
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
}