<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="well form-horizontal">

        <center><h2><b>Admin Login</b></h2>

        <br>

        <div class="wrapper">

            <div class="form-group">
                <label class="col-md-4 control-label">Username :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox6" placeholder="Username" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>

            <!-- Text input-->

            <div class="form-group">
                <label class="col-md-4 control-label">Password :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox7" placeholder="Password" CssClass="form-control" runat="server" Type="Password"></asp:TextBox>
                    </div>
                </div>
            </div>

            <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label"></label>
                <div class="col-md-4">
                    <br>
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="LOGIN" 
                        onclick="Button1_Click" />
                </div>
            </div>

        </div>
</center>
    </div>
    
</asp:Content>

