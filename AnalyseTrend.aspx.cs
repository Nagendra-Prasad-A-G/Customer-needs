using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class AnalyseTrend : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string cateCount = "";
        string subcateCount = "";
        string prodCount = "";
        string sel = "select DISTINCT category from hits";
        SqlDataAdapter da = new SqlDataAdapter(sel, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string[] category = new string[ds.Tables[0].Rows.Count];
        if (ds.Tables[0].Rows.Count>0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                category[i] = ds.Tables[0].Rows[i][0].ToString();
            }
        }

        sel = "select DISTINCT subcategory from hits";
        da = new SqlDataAdapter(sel, con);
        ds = new DataSet();
        da.Fill(ds);
        string[] subcategory = new string[ds.Tables[0].Rows.Count];
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                subcategory[i] = ds.Tables[0].Rows[i][0].ToString();
            }
        }

        sel = "select DISTINCT productid from hits";
        da = new SqlDataAdapter(sel, con);
        ds = new DataSet();
        da.Fill(ds);
        string[] productid = new string[ds.Tables[0].Rows.Count];
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                productid[i] = ds.Tables[0].Rows[i][0].ToString();
            }
        }

        foreach (string s in category)
        {
            sel = "select category from hits where category='" + s + "'";
            da = new SqlDataAdapter(sel, con);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cateCount += s + "-" + ds.Tables[0].Rows.Count.ToString() + ",";
            }
        }

        foreach (string s in subcategory)
        {
            sel = "select subcategory from hits where subcategory='" + s + "'";
            da = new SqlDataAdapter(sel, con);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                subcateCount += s + "-" + ds.Tables[0].Rows.Count.ToString() + ",";
            }
        }

        foreach (string s in productid)
        {
            sel = "select productid from hits where productid='" + s + "'";
            da = new SqlDataAdapter(sel, con);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                prodCount += s + "-" + ds.Tables[0].Rows.Count.ToString() + ",";
            }
        }

        cateCount = cateCount.TrimEnd(',');
        subcateCount = subcateCount.TrimEnd(',');
        prodCount = prodCount.TrimEnd(',');

        string[] fillCategory = cateCount.Split(',');
        string[] fillSubCategory = subcateCount.Split(',');
        string[] fillProductid = prodCount.Split(',');

        string maxCategory = "";
        string maxSubCategory = "";
        string maxProductid = "";

        int maxCount = 0;
        foreach (string s in fillCategory)
        {
            string[] val = s.Split('-');
            if (Convert.ToInt32(val[1]) > maxCount)
            {
                maxCategory = val[0] + "-" + val[1];
                maxCount = Convert.ToInt32(val[1]);
            }
        }

        maxCount = 0;
        foreach (string s in fillSubCategory)
        {
            string[] val = s.Split('-');
            if (Convert.ToInt32(val[1]) > maxCount)
            {
                maxSubCategory = val[0] + "-" + val[1];
                maxCount = Convert.ToInt32(val[1]);
            }
        }

        maxCount = 0;
        foreach (string s in fillProductid)
        {
            string[] val = s.Split('-');
            if (Convert.ToInt32(val[1]) > maxCount)
            {
                maxProductid = val[0] + "-" + val[1];
                maxCount = Convert.ToInt32(val[1]);
            }
        }

        string[] maxCate = maxCategory.Split('-');
        string[] maxSubCate = maxSubCategory.Split('-');
        string[] maxProd = maxProductid.Split('-');

        string prodName = "";
        string str = "select productname from product where pid='" + maxProd[0] + "'";
        da = new SqlDataAdapter(str,con);
        ds = new DataSet();
        da.Fill(ds);
        if(ds.Tables[0].Rows.Count>0)
        {
            prodName = ds.Tables[0].Rows[0][0].ToString();
        }

        DataTable dt;
        string[] names = new string[] { maxCate[0], maxSubCate[0], prodName, "" };
        string[] timeline = new string[] {"Number of Hits"  };

        dt = new DataTable();

        dt.Columns.Add("Data1");
        dt.Columns.Add("Data2");
        dt.Columns.Add("Data3");
        dt.Columns.Add("Data4");

        dt.Rows.Add(maxCate[1]);
        dt.Rows.Add(maxSubCate[1]);
        dt.Rows.Add(maxProd[1]);
        dt.Rows.Add("0");

        js.Text += FillGraph.BarGraphScript(dt, names, "config1", "TREND ANALYSIS", timeline);

        



        sel = "select DISTINCT productname from orders";
        da = new SqlDataAdapter(sel, con);
        ds = new DataSet();
        da.Fill(ds);
        string[] products = new string[ds.Tables[0].Rows.Count];
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                products[i] = ds.Tables[0].Rows[i][0].ToString();
            }
        }

        string[] prodMaxCount = new string[products.Length];
        for (int i = 0; i < products.Length;i++)
        {
            sel = "select productname from orders where productname='" + products[i] + "'";
            da = new SqlDataAdapter(sel, con);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                prodMaxCount[i]= products[i] + "-" + ds.Tables[0].Rows.Count.ToString();
            }
        }

        maxCount = 0;
        string [] maxProduct = new string[prodMaxCount.Length];
        for (int i = 0; i < prodMaxCount.Length; i++)
        {
            string[] val = prodMaxCount[i].Split('-');
            if (Convert.ToInt32(val[1]) >= maxCount)
            {
                maxProduct[i] = val[0] + "-" + val[1];
                maxCount = Convert.ToInt32(val[1]);
            }
        }

        string[] MaxProdName = new string [maxProduct.Length];

        
        timeline = new string[] { "Number of Product Sales" };
        dt = new DataTable();

        dt.Columns.Add("Data1");
        dt.Columns.Add("Data2");
        dt.Columns.Add("Data3");
        string val1 = "";
        string val2 = "";
        if (maxProduct.Length == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                MaxProdName = maxProduct[i].Split('-');
                val1 += MaxProdName[1]+",";
                val2 += MaxProdName[0] + ",";
            }
        }
        else if(maxProduct.Length == 2)
        {
            for (int i = 0; i < 2; i++)
            {
                MaxProdName = maxProduct[i].Split('-');
                val1 += MaxProdName[1] + ",";
                val2 += MaxProdName[0] + ",";
            }
        }
        else if (maxProduct.Length > 2)
        {
            for (int i = 0; i < 3; i++)
            {
                MaxProdName = maxProduct[i].Split('-');
                val1 += MaxProdName[1] + ",";
                val2 += MaxProdName[0] + ",";
            }
        }

        val1 = val1.TrimEnd(',');
        string[] fill = val1.Split(',');
        val2 = val2.TrimEnd(',');
        string[] fill2 = val2.Split(',');
        if (fill.Length==1)
        {
            dt.Rows.Add(fill[0]);
            names = new string[] { fill2[0] };
        }
        else if (fill.Length == 2)
        {
            dt.Rows.Add(fill[0], fill[1]);
            names = new string[] { fill2[0], fill2[1]};
        }
        else if (fill.Length > 2)
        {
            dt.Rows.Add(fill[0], fill[1], fill[2]);
            names = new string[] { fill2[0], fill2[1], fill2[2] };
        }
        
        js.Text += FillGraph.PieGraphScript(dt, names, "config3", "SALES ANALYSIS");



        Functions.Text = "<script type='text/javascript'>";

        Functions.Text += "function FillGraph1() {";
        Functions.Text += "var ctx1 = document.getElementById('canvas1').getContext('2d');";
        Functions.Text += "window.myLine = new Chart(ctx1, config1); }";

        Functions.Text += "function FillGraph2() {";
        Functions.Text += "var ctx2 = document.getElementById('canvas2').getContext('2d');";
        Functions.Text += "window.myLine = new Chart(ctx2, config3); }";

        Functions.Text += "</script>";

        Load.Text = "<script type='text/javascript'>";
        Load.Text += "window.onload = function () {";
        Load.Text += "FillGraph1();";
        Load.Text += "FillGraph2();";
        Load.Text += " }; </script>";
    }
}