<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Product Form</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="style.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="well form-horizontal">
    <center><h2><b>Add New Product</b></h2></center>
                <br>

                <!-- Text input-->
                <div class="wrapper">

                    <div class="form-group">
                        <label class="col-md-4 control-label">Product ID :</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:textbox id="TextBoxPid" placeholder="PID" cssclass="form-control" runat="server" textmode="Number" required></asp:textbox>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-md-4 control-label">Product Name :</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:textbox id="TextBoxName" placeholder="Product Name" cssclass="form-control" runat="server" required></asp:textbox>
                            </div>
                        </div>
                    </div>

                    <!-- Text input-->

                    <div class="form-group">
                        <label class="col-md-4 control-label">Cost :</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:textbox id="TextBoxCost" placeholder="cost" cssclass="form-control" runat="server" textmode="Number" required></asp:textbox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-4 control-label">Category :</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:DropDownList ID="DropDownListCategory" AutoPostBack="true" OnSelectedIndexChanged="DropDownListCategory_SelectedIndexChanged" CssClass="btn btn-default" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-4 control-label">Sub-Category :</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:DropDownList ID="DropDownListSubCategory" Visible="false" CssClass="btn btn-default" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-4 control-label">Description :</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:textbox id="TextBoxDesc" placeholder="Description" cssclass="form-control" runat="server" rows="5" textmode="MultiLine"></asp:textbox>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-md-4 control-label">Stock/Quantity :</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:textbox id="TextBoxStock" placeholder="Stock/Quantity" cssclass="form-control" runat="server" textmode="Number" required></asp:textbox>
                            </div>
                        </div>
                    </div>
                     <div class="form-group">
                        <label class="col-md-4 control-label">Product Image</label>
                        <div class="col-md-4 inputGroupContainer">
                            <div class="input-group">
                                <asp:FileUpload ID="FileUpload1" CssClass="btn btn-default" runat="server"/>
                                <asp:Button ID="ButtonUpload" runat="server" CssClass="btn btn-info" Text="Upload" onclick="ButtonUpload_Click" />
                                <br />
                                <asp:Image ID="Image1" Visible="false" runat="server" Height="100px" Width="99px" />
                            </div>
                        </div>
                    </div>
                    <!-- Button -->
                    <div class="form-group">
                        <label class="col-md-4 control-label"></label>
                        <div class="col-md-4">
                            <hr>
                            <asp:button id="ButtonSubmit" OnClick="ButtonSubmit_Click" cssclass="btn btn-success" runat="server" text="SUBMIT" />
                        </div>
                    </div>
                </div>
        </div>
</asp:Content>

