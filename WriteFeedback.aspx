<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="WriteFeedback.aspx.cs" Inherits="WriteFeedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="well form-horizontal">

        <h2><b>Feedback Form</b></h2>

        <br>

        <!-- Text input-->
        <div class="wrapper">


            <div class="form-group">
                <label class="col-md-4 control-label">User Name :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox2" placeholder="User Name" Enabled="false" CssClass="form-control" runat="server" required></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <label class="col-md-4 control-label">Message :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox4" placeholder="Message" CssClass="form-control" Required="" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
            </div>


            <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label"></label>
                <div class="col-md-4">
                    <br>
                    <asp:Button ID="ButtonSubmit" CssClass="btn btn-success" OnClick="ButtonSubmit_Click" runat="server" Text="SUBMIT" />
                </div>
            </div>

        </div>
    </div>
</asp:Content>

