using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

public partial class ViewQuestions : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string s = "SELECT id,question,date,time,pid FROM QA WHERE Answers=''";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Label4.Visible = false;
            }
            else
            {
                Label4.Visible = true;
            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string up = "update QA set answers='" + TextBoxAns.Text + "' where id='" + LabelQid.Text + "'";
        SqlCommand cmd = new SqlCommand(up, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("ViewQuestions.aspx");
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Reply")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            string s = "SELECT id,question FROM Qa WHERE id='" + i + "'";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            LabelQuestion.Text = ds.Tables[0].Rows[0][1].ToString();
            LabelQid.Text = ds.Tables[0].Rows[0][0].ToString();

            s = "select productname from product where pid='" + i + "'";
            da = new SqlDataAdapter(s,con);
            ds = new DataSet();
            da.Fill(ds);
            LabelPname.Text = ds.Tables[0].Rows[0][0].ToString();
            Popup(true);
        }
    }

    protected void ButtonClose_Click(object sender, EventArgs e)
    {
        Popup(false);
    }

    void Popup(bool isDisplay)
    {
        StringBuilder builder = new StringBuilder();
        if (isDisplay)
        {
            builder.Append("<script language=JavaScript> ShowPopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "ShowPopup", builder.ToString());
        }
        else
        {
            builder.Append("<script language=JavaScript> HidePopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "HidePopup", builder.ToString());
        }
    }
}