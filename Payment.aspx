<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPageMain.master" CodeFile="Payment.aspx.cs" Inherits="Payment" %>


   <asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <center>
      <asp:Label ID="Label19" runat="server" Text="Payment" style="font-family: gadugi; font-size: xx-large"></asp:Label>
        <br />
        <table width="40%">
            <tr>
                <td style="border-top-style: solid; border-top-width: 1px; border-top-color: #C0C0C0">&nbsp;</td>
            </tr>
        </table>
           &nbsp; <span class="auto-style2">Your total cost payable is&nbsp; Rs.</span>
       <asp:Label ID="Label6" runat="server" style="font-weight: 700; font-family: gadugi; font-size: large"></asp:Label>
           <span class="auto-style2">/-</span><br />
&nbsp;<br />
           <asp:Label ID="LabelUid" runat="server" Visible="false" Text=""></asp:Label>
   <table><tr><td class="style1">
       <asp:Label ID="Label1" runat="server" Text="Name on Card:" CssClass="auto-style1"></asp:Label>
       </td>
       <td>
           <asp:TextBox ID="T1" runat="server" Required="" CssClass="auto-style1"></asp:TextBox>
       </td></tr>
           <tr><td class="style1">
               &nbsp;</td>
       <td>
           &nbsp;</td></tr>
           <tr><td class="style1">
       <asp:Label ID="Label2" runat="server" Text="Credit card no:" CssClass="auto-style1"></asp:Label>
               </td>
       <td>
           <asp:TextBox ID="T2" runat="server" Required="" CssClass="auto-style1" MaxLength="16"></asp:TextBox>
               </td></tr>

           <tr><td class="style1">
               &nbsp;</td>
       <td>
           &nbsp;</td></tr>

           <tr><td class="style1">
       <asp:Label ID="Label3" runat="server" Text="CVV code:" CssClass="auto-style1"></asp:Label></td>
       <td>
           <asp:TextBox ID="T3" runat="server" Required="" CssClass="auto-style1" MaxLength="3"></asp:TextBox>
           <br />
               </td></tr>

           <tr><td class="style1">
               &nbsp;</td>
       <td>
           &nbsp;</td></tr>
           <tr><td class="style1">
       <asp:Label ID="Label4" runat="server" Text="Date of Expiry:" CssClass="auto-style1"></asp:Label></td>
       <td>
           <asp:TextBox ID="T4" runat="server" Type="Date" Required="" CssClass="auto-style1"></asp:TextBox>
       </td></tr>
       <tr><td colspan="2" style="text-align: center">
           <br />
           <asp:Button ID="Button1" runat="server" Text="Pay" onclick="Button1_Click" 
               Height="28px" Width="61px" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" Text="Cancel" Height="28px" Width="61px" />
           <br />
           <br />
           <br />
           <br />
           <br />
           </td></tr>
       

           </table>
           </center>
   </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            width: 159px;
        }
        .auto-style1 {
            font-family: gadugi;
            font-size: large;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</asp:Content>
