<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="ViewProduct.aspx.cs" Inherits="ViewProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>View Products</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="style2.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="LabelUid" runat="server" Visible="false" Text="LabelUID"></asp:Label>
    <asp:Label ID="LabelCategory" runat="server" Font-Bold="true" Text=""></asp:Label> > 
    <asp:Label ID="LabelSubCategory" runat="server" Font-Bold="true" Text=""></asp:Label>
    <div class="container">
        
        <div class="col-md-4" style="text-align:center">
            <asp:ImageButton ID="ImageButton1" runat="server" Width="200px" Height="300px"  Visible="false" OnClick="ImageButton1_Click"/><br />
            <asp:Label ID="LabelPName1" Font-Bold="true" Visible="false" runat="server" Text="One Plus 6"></asp:Label><br />
            <asp:Label ID="LabelDesc1" runat="server" Visible="false" Text="DescriptionDescription DescriptionDescription DescriptionDescription"></asp:Label><br /><br />
            <asp:Label ID="Label1" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" ID="Button1" OnClick="Button1_Click" runat="server" Text="View Details" />
            <asp:Label ID="lblp1" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
            <asp:Label ID="LabelErr" runat="server" style="font-size: x-large" Text="No data found!" Visible="False"></asp:Label>
            <asp:ImageButton ID="ImageButton2" Visible="false" Width="200px" Height="300px" runat="server" OnClick="ImageButton2_Click" /><br />
            <asp:Label ID="LabelPName2" Visible="false" Font-Bold="true" runat="server"></asp:Label><br />
            <asp:Label ID="LabelDesc2" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label2" Visible="false" Font-Size="Medium" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" ID="Button2" OnClick="Button2_Click" runat="server" Text="View Details" />
            <asp:Label ID="lblp2" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
             <asp:ImageButton ID="ImageButton3" Visible="false" Width="200px" Height="300px" OnClick="ImageButton3_Click" runat="server" /><br />
            <asp:Label ID="LabelPName3" Visible="false" Font-Bold="true" runat="server"></asp:Label><br />
            <asp:Label ID="LabelDesc3" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label3" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" ID="Button3" OnClick="Button3_Click" runat="server" Text="View Details" />
            <asp:Label ID="lblp3" Visible="false" runat="server"></asp:Label>
        </div>
    </div>
    <br /><br /><br />
    <div class="container">
        <div class="col-md-4" style="text-align:center">
            <asp:ImageButton ID="ImageButton4" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton4_Click" runat="server" /><br />
            <asp:Label ID="LabelPName4" Font-Bold="true" Visible="false" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc4" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label4" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button4_Click" ID="Button4" runat="server" Text="View Details" />
            <asp:Label ID="lblp4" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
            <asp:Label ID="Label13" runat="server" style="font-size: x-large" Text="No data found!" Visible="False"></asp:Label>
            <asp:ImageButton ID="ImageButton5" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton5_Click" runat="server" /><br />
            <asp:Label ID="LabelPName5" Visible="false" Font-Bold="true" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc5" Visible="false" runat="server"></asp:Label><br /><br />
             <asp:Label ID="Label5" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button5_Click" ID="Button5" runat="server" Text="View Details" />
            <asp:Label ID="lblp5" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
             <asp:ImageButton ID="ImageButton6" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton6_Click" runat="server" /><br />
            <asp:Label ID="LabelPName6" Visible="false" Font-Bold="true" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc6" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label6" Visible="false" Font-Size="Medium" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button6_Click" ID="Button6" runat="server" Text="View Details" />
            <asp:Label ID="lblp6" Visible="false" runat="server"></asp:Label>
        </div>
    </div>
    <br /><br /><br />
    <div class="container">
        <div class="col-md-4" style="text-align:center">
            <asp:ImageButton ID="ImageButton7" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton7_Click" runat="server" /><br />
            <asp:Label ID="LabelPName7" Font-Bold="true" Visible="false" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc7" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label7" Visible="false" Font-Size="Medium" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button7_Click" ID="Button7" runat="server" Text="View Details" />
            <asp:Label ID="lblp7" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
            <asp:ImageButton ID="ImageButton8" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton8_Click" runat="server" /><br />
            <asp:Label ID="LabelPName8" Visible="false" Font-Bold="true" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc8" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label8" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button8_Click" ID="Button8" runat="server" Text="View Details" />
            <asp:Label ID="lblp8" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
             <asp:ImageButton ID="ImageButton9" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton9_Click" runat="server" /><br />
            <asp:Label ID="LabelPName9" Visible="false" Font-Bold="true" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc9" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label9" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button9_Click" ID="Button9" runat="server" Text="View Details" />
            <asp:Label ID="lblp9" Visible="false" runat="server"></asp:Label>
        </div>
    </div>
    <br /><br /><br />
    <div class="container">
        <div class="col-md-4" style="text-align:center">
            <asp:ImageButton ID="ImageButton10" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton10_Click" runat="server" /><br />
            <asp:Label ID="LabelPName10" Font-Bold="true" Visible="false" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc10" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label10" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button10_Click" ID="Button10" runat="server" Text="View Details" />
            <asp:Label ID="lblp10" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
            <asp:ImageButton ID="ImageButton11" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton11_Click" runat="server" /><br />
            <asp:Label ID="LabelPName11" Font-Bold="true" Visible="false" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc11" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label11" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button11_Click" ID="Button11" runat="server" Text="View Details" />
            <asp:Label ID="lblp11" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="col-md-4" style="text-align:center">
             <asp:ImageButton ID="ImageButton12" Visible="false" Width="200px" Height="300px"  OnClick="ImageButton12_Click" runat="server" /><br />
            <asp:Label ID="LabelPName12" Font-Bold="true" Visible="false" runat="server" ></asp:Label><br />
            <asp:Label ID="LabelDesc12" Visible="false" runat="server"></asp:Label><br /><br />
            <asp:Label ID="Label12" Font-Size="Medium" Visible="false" runat="server"></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success" Visible="false" OnClick="Button12_Click" ID="Button12" runat="server" Text="View Details" />
            <asp:Label ID="lblp12" Visible="false" runat="server"></asp:Label>
        </div>
    </div>
        
        <br />
        <br />
        <asp:Button ID="ButtonPrev" runat="server" Text="|&lt; Previous" />&nbsp;&nbsp;
        <asp:Button ID="ButtonNxt" runat="server" Text="Next &gt;|" />
        <asp:Label ID="LabelOne" runat="server" Text="0" Visible="False"></asp:Label>
        <asp:Label ID="LabelTwo" runat="server" Text="0" Visible="False"></asp:Label>
        <br />
</asp:Content>

