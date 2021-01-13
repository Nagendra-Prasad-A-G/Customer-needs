using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ProductDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelPid.Text = Request.QueryString["Pid"];
        LabelUid.Text = Session["Uid"].ToString();
        string sel = "select productname,cost,description,image,category,subcategory from product where pid='" + LabelPid.Text + "'";
        SqlDataAdapter da = new SqlDataAdapter(sel, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if(ds.Tables[0].Rows.Count>0)
        {
            LabelPName.Text = ds.Tables[0].Rows[0][0].ToString();
            LabelCost.Text = ds.Tables[0].Rows[0][1].ToString();
            LabelDesc.Text = ds.Tables[0].Rows[0][2].ToString();
            Image1.ImageUrl = ds.Tables[0].Rows[0][3].ToString();

            string category = ds.Tables[0].Rows[0][4].ToString();
            string subcategory = ds.Tables[0].Rows[0][5].ToString();

            string ins = "insert into hits(category,subcategory,productid,date,uid) values ('" + category + "','" + subcategory + "','" + LabelPid.Text + "','" + System.DateTime.Now.ToString("yyyy/MM/dd") + "','" + LabelUid.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        string k = "SELECT * FROM QA where Answers !='' and pid='" + LabelPid.Text + "'";
        da = new SqlDataAdapter(k, con);
        ds = new DataSet();
        da.Fill(ds);
        int c = ds.Tables[0].Rows.Count;
        if (c > 0)
        {
            string text = "<table>";
            for (int i = 0; i < c; i++)
            {
                string question = ds.Tables[0].Rows[i][1].ToString();
                string ans = ds.Tables[0].Rows[i][2].ToString();
                text += "<tr><td align='left' style='font-family: 'Calibri Light'; font-size: medium'>";
                text += "<b>Q:</b> " + question + "</td></tr><tr><td align='left' style='font-family: 'Calibri Light'; font-size: medium'>";
                text += "<b>A:</b><i> " + ans + "</i></td></tr><tr><td align='left' style='font-family: 'Calibri Light'; font-size: medium'><br></td></tr>";
            }
            text += "</table>";

            Label2.Text = text;
            Label2.Visible = true;
        }
        else
        {
            Label2.Text = "Have a question related to this product?";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //add question
        if (TextBox1.Text != "")
        {
            string pid = "SELECT TOP 1 ID from QA ORDER BY ID DESC";
            SqlDataAdapter da = new SqlDataAdapter(pid, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int c = ds.Tables[0].Rows.Count;
            int i = 1;
            if (c > 0)
            {
                i = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
            }
            else
            {
                i = 1;
            }
            string q = TextBox1.Text;

            string date = DateTime.Now.ToString("yyyy/MM/dd");
            string time = DateTime.Now.ToString("HH:mm");

            string j = "INSERT INTO QA VALUES('" + i.ToString() + "','" + TextBox1.Text + "','','" + LabelUid.Text + "','','" + date + "','" + time + "','" + LabelPid.Text + "')";
            SqlCommand cmd = new SqlCommand(j, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            Labelsuccess.Visible = true;
            Labelsuccess.ForeColor = System.Drawing.Color.Green;
            Labelsuccess.Text = "Your question has been submitted.";
        }
        else
        {
            Labelsuccess.Visible = true;
            Labelsuccess.ForeColor = System.Drawing.Color.IndianRed;
            Labelsuccess.Text = "field cannot be left blank";
        }
    }

    protected void ButtonCart_Click(object sender, EventArgs e)
    {
        //Cart
        string pid = "SELECT TOP 1 PID from Cart ORDER BY PID DESC";
        SqlDataAdapter da = new SqlDataAdapter(pid, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        int c = ds.Tables[0].Rows.Count;
        int i = 1001;
        if (c > 0)
        {
            i = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;
        }
        else
        {
            i = 1001;
        }
        string k = "Insert INTO Cart VALUES('" + LabelPid.Text + "','" + LabelPName.Text + "','1','" + LabelCost.Text + "','" + LabelCost.Text + "','" + LabelUid.Text + "','Cart')";
        SqlCommand cmd = new SqlCommand(k, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Added to your Cart')", true);
    }

    protected void ButtonBuy_Click(object sender, EventArgs e)
    {
        //buy
        Session["pname"] = LabelPName.Text;
        Session["pid"] = LabelPid.Text;
        Session["cost"] = LabelCost.Text;
        Session["BuyNow"] = "Data";
        Response.Redirect("Payment.aspx");
    }
}