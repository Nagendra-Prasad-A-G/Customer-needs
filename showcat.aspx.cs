using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class showcat : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
        if (!IsPostBack)
        {
            string cc = Request.QueryString["category"];
            Session["cc"] = cc;
            LabelUid.Text = Session["Uid"].ToString();
            string s = "SELECT DISTINCT SubCategory FROM Category where Category='"+cc+"'";
            SqlDataAdapter da = new SqlDataAdapter(s, conn);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            int count = ds1.Tables[0].Rows.Count;
            string text = "<table align='left' width='100%'> <tr>";
            for (int i = 0; i < count; i++)
            {
                
                string Subcategory = ds1.Tables[0].Rows[i][0].ToString();
                if ((i % 2) == 0)
                {
                    text += "</tr>";
                    text += "<tr><td style='width:50%; height:100px; background-color:darkgray; font-size:x-large; text-align:center'>";
                    text += "<a href='ViewProduct.aspx?Category=" + cc + "&SubCategory=" + Subcategory + "'>";
                    text += "<span style='width:100%; font-family:'Bell MT'; font-size:28px; color:Black:display: inline-block;'>" + Subcategory + "</span></a>";
                    text += "</td>";
                    text += "<td width='2%'></td>";
                }
                else
                {
                    text += "<td style='width:50%; height:100px; background-color:darkgray; font-size:x-large; text-align:center' >";
                    text += "<a href='ViewProduct.aspx?Category=" + cc + "&SubCategory=" + Subcategory + "'>";
                    text += "<span style='width:100%; font-family:'Bell MT'; font-size:28px; color:Black:display: inline-block;'>" + Subcategory + "</span></a>";
                    text += "</td>";
                    text += "<td width='2%'></td><tr><td><br></td></tr>";
                }
            }
            text += "</tr></table>";
            Label1.Text = text;
            Label1.Visible = true;
            conn.Close();

            string ins = "insert into hits(category,date,uid) values ('" + cc + "','" + System.DateTime.Now.ToString("yyyy/MM/dd") + "','" + LabelUid.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}