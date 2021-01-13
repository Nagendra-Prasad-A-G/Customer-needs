using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class WriteFeedback : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["type"].ToString() != "User")
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {
            TextBox2.Text = Session["Uid"].ToString();
        }
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text != "" && TextBox4.Text != "")
        {
            string k = "SELECT TOP 1 FID from FeedBack ORDER BY FID DESC";
            SqlDataAdapter da = new SqlDataAdapter(k, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            int i = 101;
            if (c > 0)
            {
                i = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
            }
            else
            {
                i = 1001;
            }
            String date = DateTime.Now.ToString("yyyy/MM/dd");
            string time = DateTime.Now.ToString("HH:mm");
            string kk = "INSERT INTO FeedBack VALUES('" + i.ToString() + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + date + "','" + time + "')";
            SqlCommand cmd = new SqlCommand(kk, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Feedback Submitted')", true);
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Write Feedback Message')", true);
        }
    }
}