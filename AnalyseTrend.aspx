<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="AnalyseTrend.aspx.cs" Inherits="AnalyseTrend" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <asp:Literal ID='js' runat='server'></asp:Literal>
    <asp:Literal ID='Functions' runat='server'></asp:Literal>
    <asp:Literal ID='Load' runat='server'></asp:Literal>
    <script src="js/Chart.bundle.js"></script>
    <script src="js/utils.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <center>
    <h2>Analyse Sales & Trend</h2>
        <hr />
        </center>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-lg-6" style="text-align:center">
                <canvas id="canvas1"></canvas>
                <span style="font-size:medium">Number of Hits</span>
            </div>
            <div class="col-lg-6" style="text-align:center">
                <canvas id="canvas2"></canvas>
                <span style="font-size:medium">Number of Sales</span>
            </div>
        </div>
    </div>
</asp:Content>

