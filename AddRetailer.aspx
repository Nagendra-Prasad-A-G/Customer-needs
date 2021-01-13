<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="AddRetailer.aspx.cs" Inherits="AddRetailer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Retailer Form</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="style.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="well form-horizontal">
            <fieldset>

<!-- Form Name -->
<legend>
  <center>
    <h2><b>Retailer Form</b></h2>
  </center>
</legend>
<br>

<!-- Text input-->
<div class="wrapper">

    <div class="form-group">
  <label class="col-md-4 control-label">Retailer ID :</label>  
    <div class="col-md-4 inputGroupContainer">
    <div class="input-group">
    <asp:TextBox ID="TextBoxRid" placeholder="RID" CssClass="form-control" runat="server" TextMode="Number" required></asp:TextBox>
    </div>
  </div>
</div>

    <div class="form-group">
  <label class="col-md-4 control-label">Retailer Name :</label>  
  <div class="col-md-4 inputGroupContainer">
  <div class="input-group">
      <asp:TextBox ID="TextBoxName" placeholder="Retailer Name" CssClass="form-control" runat="server" required></asp:TextBox>
    </div>
  </div>
</div>

    <div class="form-group">
  <label class="col-md-4 control-label">Owner Name :</label>  
  <div class="col-md-4 inputGroupContainer">
  <div class="input-group">
      <asp:TextBox ID="TextBoxOwnerName" placeholder="Owner Name" CssClass="form-control" runat="server" required></asp:TextBox>
    </div>
  </div>
</div>

  <!-- Text input-->
       <div class="form-group">
  <label class="col-md-4 control-label">E-Mail :</label>  
    <div class="col-md-4 inputGroupContainer">
    <div class="input-group">
  <asp:TextBox ID="TextBoxEmail" placeholder="Email Address" CssClass="form-control" runat="server" required></asp:TextBox>
        
    </div>
        <asp:RegularExpressionValidator ID="RxvEmail" runat="Server" 
                                ControlToValidate="TextBoxEmail" ErrorMessage="** Invalid Email Id!" 
                                ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                style="font-family: Calibri Light"></asp:RegularExpressionValidator>
  </div>
</div>


<!-- Text input-->
       
<div class="form-group">
  <label class="col-md-4 control-label">Contact No :</label>  
    <div class="col-md-4 inputGroupContainer">
    <div class="input-group">
    <asp:TextBox ID="TextBoxContact" placeholder="(+91)" CssClass="form-control" runat="server" TextMode="Number" required></asp:TextBox>
    </div>
        <asp:RegularExpressionValidator ID="RxvMobNo" runat="Server" 
                                ControlToValidate="TextBoxContact" ErrorMessage="** Invalid Mobile no." 
                                ForeColor="#990000" ValidationExpression="^[7-9]\d{9}$" 
                                style="font-family: Calibri Light"></asp:RegularExpressionValidator>
  </div>
</div>

    <div class="form-group"> 
  <label class="col-md-4 control-label">Address :</label>
    <div class="col-md-4 inputGroupContainer">
    <div class="input-group">
    <!-- <input name="last_name" placeholder="Address" class="form-control"  type="textarea"> -->
        <asp:TextBox ID="TextBoxAddress" placeholder="Address" CssClass="form-control" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
  </div>
</div>
</div>
  
<!-- Text input-->

<div class="form-group">
  <label class="col-md-4 control-label" >Password :</label> 
    <div class="col-md-4 inputGroupContainer">
    <div class="input-group">
  <asp:TextBox ID="TextBoxPass" placeholder="Password" CssClass="form-control" runat="server" TextMode="Password" required></asp:TextBox>
    </div>
  </div>
</div>

<!-- Button -->
    <div class="form-group">
  <label class="col-md-4 control-label"></label>
  <div class="col-md-4"><br>
      <asp:Button ID="ButtonSubmit" CssClass="btn btn-success" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
  </div>
</div>

</div>

</fieldset>
        </div>
</asp:Content>

