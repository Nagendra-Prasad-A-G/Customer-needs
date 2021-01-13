<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Product Details</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="style2.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container wrapper">
            <div class="row">
                <div class="col-md-6" style="text-align:center">
                    <asp:Label ID="LabelUid" runat="server" Visible="false" Text=""></asp:Label>
                    <asp:Label ID="LabelPid" runat="server" Visible="false" Text=""></asp:Label>
                    <asp:Label ID="LabelCategory" runat="server" Text=""></asp:Label>
                    <asp:Label ID="LabelSubCategory" runat="server" Text=""></asp:Label>
                    <asp:Image ID="Image1" Width="40%" ImageUrl="~/images/One-PLus.png" runat="server" />
                    <div class="btndiv">
                    <asp:Button CssClass="btn btn-warning btnaddtoca" ID="ButtonCart" OnClick="ButtonCart_Click" runat="server" Text="Add To Cart" />
                        <asp:Button CssClass="btn btn-success btnbuynow" ID="ButtonBuy" OnClick="ButtonBuy_Click" runat="server" Text="Buy Now" />
                    </div>
                    <br />
                    <hr />
                    <span style="font-size:large; font-weight:bold">Questions & Answers</span>
                    <hr />
                    <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text=""></asp:Label>
                    <h2 class="heading1">Ask a Question ?</h2>
                    <asp:TextBox ID="TextBox1" CssClass="inputtxt" placeholder="Question ?" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" CssClass="btn btn-info btntxt" runat="server" OnClick="Button1_Click" Text="Ask" /><br />
                    <asp:Label ID="Labelsuccess" runat="server" Visible="false" Text=""></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="LabelPName" CssClass="heading" runat="server" Text="OnePlus 6 (Mirror Black 6GB RAM + 64GB Memory)"></asp:Label>
                    <hr />
                    <br />

                    <asp:Label ID="LabelDesc" CssClass="para1" runat="server" Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop."></asp:Label><br /><br />
                    <asp:Label ID="Label1" CssClass="span1" runat="server" Text="Price: "></asp:Label><asp:Label ID="LabelCost" CssClass="span1" runat="server" Text="Price: 34,999.00"></asp:Label>
                </div>
            </div>
        </div>
</asp:Content>

