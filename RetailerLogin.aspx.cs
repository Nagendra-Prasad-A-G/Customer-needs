using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class RetailerLogin : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox6.Text != "" && TextBox7.Text != "")
        {
            string k = "SELECT * FROM Retailer where RID='" + TextBox6.Text + "' and Password='" + TextBox7.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(k, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            if (c > 0)
            {
                Session["Rid"] = TextBox6.Text;
                Session["type"] = "Retailer";
                Response.Redirect("ManageProduct.aspx");
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
}