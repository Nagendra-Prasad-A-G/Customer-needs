using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class UserDetails : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string k = "SELECT uid,username,email,contact,address,gender,age FROM [User]";
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
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('No Data Available.')", true);
        }
    }
}