<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .imgban {
            width: 100%;
            height: 400px;
        }
        .div {
            margin-top: 2%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<div class="w3-container" style="padding:128px 16px" id="about">
  <h3 class="w3-center">ABOUT THE PROJECT</h3>
  <p class="w3-center w3-large">Key features of your Application</p>
  <div class="w3-row-padding w3-center" style="margin-top:64px">
  </div>
    <center>
        <h2 style="font-family: 'Century Gothic'; font-size: xx-large; width:80%">VIDEOS</h2>
        <hr />
    <table style="width:90%">
        <tr>
            <td style="width:50%">
<iframe width="560" height="315" src="https://www.youtube.com/embed/X8mULr-pVIE" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
            </td>
            <td style="width:50%">
                <iframe width="560" height="315" src="https://www.youtube.com/embed/xKJxxq74c-8" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
            </td>
        </tr>
    </table>
        </center>
    <br />
        <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
        </div>--%>

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <a href="Login.aspx"><asp:Image ID="Image1" CssClass="imgban img-thumbnail" ImageUrl="~/images/Men.jpg" runat="server" /></a>
            </div>
            <div class="col-md-12 div">
                <a href="Login.aspx"><asp:Image ID="Image2" CssClass="imgban img-thumbnail" ImageUrl="~/images/Women.jpg" runat="server" /></a>
            </div>
            <div class="col-md-12 div">
                <a href="Login.aspx"><asp:Image ID="Image3" CssClass="imgban img-thumbnail" ImageUrl="~/images/Kids.jpg" runat="server" /></a>
            </div>
            <div class="col-md-12 div">
                <a href="Login.aspx"><asp:Image ID="Image4" CssClass="imgban img-thumbnail" ImageUrl="~/images/offer.jpg" runat="server" /></a>
            </div>
            <div class="col-md-12 div">
                <a href="Login.aspx"><asp:Image ID="Image5" CssClass="imgban img-thumbnail" ImageUrl="~/images/summer_collection.png" runat="server" /></a>
            </div>
            <div class="col-md-12 div">
                <a href="Login.aspx"><asp:Image ID="Image6" CssClass="imgban img-thumbnail" ImageUrl="~/images/winter_collection.jpg" runat="server" /></a>
            </div>
            <div class="col-md-12 div">
                <a href="Login.aspx"><asp:Image ID="Image7" CssClass="imgban img-thumbnail" ImageUrl="~/images/traditional.jpg" runat="server" /></a>
            </div>
            <div class="col-md-12 div">
                <a href="Login.aspx"><asp:Image ID="Image8" CssClass="imgban img-thumbnail" ImageUrl="~/images/trending.png" runat="server" /></a>
            </div>
        </div>
    </div>

</asp:Content>

