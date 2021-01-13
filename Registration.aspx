<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="well form-horizontal">

        <h2><b>Registration Form</b></h2>

        <br>

        <!-- Text input-->
        <div class="wrapper">

            <div class="form-group">
                <label class="col-md-4 control-label">User ID :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox1" ReadOnly="true" placeholder="UID" CssClass="form-control" runat="server" Type="Number" required></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <label class="col-md-4 control-label">Name :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox2" placeholder="Name" CssClass="form-control" runat="server" required></asp:TextBox>
                    </div>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label">E-Mail :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox3" placeholder="Email Address" CssClass="form-control" runat="server" required></asp:TextBox>

                    </div>
                    <asp:RegularExpressionValidator ID="RxvEmail" runat="Server"
                        ControlToValidate="TextBox3" ErrorMessage="** Invalid Email Id!"
                        ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        Style="font-family: Calibri Light"></asp:RegularExpressionValidator>
                </div>
            </div>


            <!-- Text input-->

            <div class="form-group">
                <label class="col-md-4 control-label">Contact No :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox4" placeholder="(+91)" CssClass="form-control" runat="server" Type="Number" required></asp:TextBox>
                    </div>
                    <asp:RegularExpressionValidator ID="RxvMobNo" runat="Server"
                        ControlToValidate="TextBox4" ErrorMessage="** Invalid Mobile no."
                        ForeColor="#990000" ValidationExpression="^[7-9]\d{9}$"
                        Style="font-family: Calibri Light"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="form-group">
                <label class="col-md-4 control-label">Address :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <!-- <input name="last_name" placeholder="Address" class="form-control"  type="textarea"> -->
                        <asp:TextBox ID="TextBox5" placeholder="Address" CssClass="form-control" runat="server" Rows="5" Type="MultiLine"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-4" for="dob">Gender :</label>
                <div class="col-md-6">

                    <asp:RadioButtonList ID="RadioButtonList1" Width="40%" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>

                </div>
            </div>

            <div class="form-group">
                <label class="col-md-4 control-label">Age :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox6" placeholder="Age" CssClass="form-control" runat="server" Type="Number" required></asp:TextBox>
                    </div>
                </div>
            </div>

            <!-- Text input-->

            <div class="form-group">
                <label class="col-md-4 control-label">Password :</label>
                <div class="col-md-4 inputGroupContainer">
                    <div class="input-group">
                        <asp:TextBox ID="TextBox7" placeholder="Password" CssClass="form-control" runat="server" Type="Password" required></asp:TextBox>
                    </div>
                </div>
            </div>

            <!-- Select Basic -->

            <!-- Success message -->
            <!-- <div class="alert alert-success" role="alert" id="success_message">Success <i class="glyphicon glyphicon-thumbs-up"></i> Success!.</div> -->

            <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label"></label>
                <div class="col-md-4">
                    <br>
                    <asp:Button ID="ButtonSubmit" CssClass="btn btn-success" runat="server" 
                        Text="SUBMIT" onclick="ButtonSubmit_Click" />
                </div>
            </div>

        </div>

    </div>
    <!-- /.container -->
</asp:Content>

