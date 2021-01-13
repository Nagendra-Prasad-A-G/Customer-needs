using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class AddRetailer : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Add"] == "Data")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Retailer Details added')", true);
            Session["Add"] = "";
        }
        if (!IsPostBack)
        {
            string str1 = "SELECT CAST(rid AS int) AS Expr1 FROM retailer ORDER BY Expr1 desc";
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count == 0)
            {
                TextBoxRid.Text = "101";
            }
            else
            {
                string s = ds1.Tables[0].Rows[0][0].ToString();
                int s1 = Convert.ToInt32(s) + 1;
                TextBoxRid.Text = s1.ToString();
            }
        }
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string s = "insert into retailer values('" + TextBoxRid.Text + "','" + TextBoxName.Text + "','" + TextBoxOwnerName.Text + "','" + TextBoxEmail.Text + "','" + TextBoxContact.Text + "','" + TextBoxAddress.Text + "','" + TextBoxPass.Text + "')";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Session["Add"] = "Data";
        Response.Redirect("AddRetailer.aspx");
    }
}