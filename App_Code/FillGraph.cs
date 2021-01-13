using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

public class FillGraph
{
    public FillGraph()
    {

    }

    public static string BarGraphScript(DataTable dt, string[] names, string varName, string title, string[] timeline)
    {
        string output = "";
        string[] colors = new string[] { "rgba(16,133,135,1)", "rgba(82,185,159,1)", "rgba(242,175,62,1)", "rgba(255,255,255)" };

        try
        {
            output = @" <script type='text/javascript'>";
            output += @" var " + varName + @" = {
			            type: 'bar',
			            data: {";

            output += @"labels: [";

            //for (int i = 0; i < timeline.Length; i++)
            //{
            //    output += @"'" + timeline[i] + @"',";
            //}
            output += "],";

            output += Environment.NewLine + @"datasets: [ ";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                output += @"{
                label : '" + names[i] + @"',
                backgroundColor: '" + colors[i] + @"',
                data: [";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    output += " " + dt.Rows[i][j].ToString() + @",";
                }
                output += "]},";
            }
            output = output.Remove(output.Length - 1);
            output += @"]},
            options: {
                title : { display: true, text: '"+title+@"' },
				tooltips: { mode: 'index', intersect: false},
				responsive: true 
                }
            };
            </script>";
        }
        catch (Exception ep)
        {
            output = "Error";
        }
        return output;
    }

    public static string PieGraphScript(DataTable dt, string[] names, string varName, string title)
    {
        string output = "";
        string[] colors = new string[] { "rgba(16,133,135,1)", "rgba(82,185,159,1)", "rgba(242,175,62,1)"};

        try
        {
            output = @" <script type='text/javascript'>";
            output += @" var " + varName + @" = {
			            type: 'doughnut',
			            data: {";

            output += @"labels: [";

            for (int i = 0; i < names.Length; i++)
            {
                output += @"'" + names[i] + @"',";
            }
            output += "],";

            output += Environment.NewLine + @"datasets: [ ";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                output += @"{
                label : '" + names[i] + @"',
                data: [";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    output += " " + dt.Rows[i][j].ToString() + @",";
                }
                output += "],";
                output += "backgroundColor: [";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    output += "'" + colors[j] + @"',";
                }
                output += "]},";
            }
            output = output.Remove(output.Length - 1);
            output += @"]},
            options: {
                legend: {position: 'top',},
                title: {display: true, text: '" + title + @"'},
				animation: {animateScale: true, animateRotate: true},
				responsive: true 
                }
            };
            </script>";
        }
        catch (Exception ep)
        {
            output = "Error";
        }
        return output;
    }
}