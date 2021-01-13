<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="OrderPlaced.aspx.cs" Inherits="OrderPlaced" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />
    <center style="font-size: xx-small">
    <img src='images/Tick1.jpeg' alt='' width='6%'><br />
&nbsp;<br />
        <asp:Label ID="Label4" runat="server" style="font-size: xx-large; color: #666666" Text="Order Placed"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Order ID:" style="font-size: medium; color: #666666"></asp:Label>&nbsp;<asp:Label ID="LabelOid" runat="server" Font-Names="Century Gothic" style="font-size: large; font-weight: 700"></asp:Label>
        
    <br /><br />
    <asp:Button ID="Button1" CssClass="btn btn-info" runat="server" OnClick="Button1_Click" Text="Shop More" />
    <br /><br /><br />
    <br /><br />
        </center>
</asp:Content>

