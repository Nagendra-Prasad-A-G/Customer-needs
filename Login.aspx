<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="w3-container" style="padding: 100px 16px" id="about">
        <h3 class="w3-center">
            CHOOSE YOUR LOGIN</h3>
        <p class="w3-center w3-large">
        </p>
        <hr />
        <div class="w3-row-padding w3-center" style="margin-top: 64px">
            <a href="AdminLogin.aspx">
                <div class="w3-third">
                    <i class="fa fa-user-circle w3-margin-bottom w3-jumbo"></i>
                    <p class="w3-large">
                        ADMIN</p>
                </div>
            </a><a href="RetailerLogin.aspx">
                <div class="w3-third">
                    <i class="fa fa-user-circle w3-margin-bottom w3-jumbo"></i>
                    <p class="w3-large">
                        RETAILER</p>
                </div>
            </a><a href="UserLogin.aspx">
                <div class="w3-third">
                    <i class="fa fa-users w3-margin-bottom w3-jumbo"></i>
                    <p class="w3-large">
                        CONSUMER</p>
                </div>
            </a>
        </div>
        <hr />
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
