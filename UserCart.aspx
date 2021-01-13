<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="UserCart.aspx.cs" Inherits="UserCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br /><br />
    <script type="text/javascript" language="javascript">
        function ShowPopup() {
            $('#mask').show();
            $('#<%=pnlpopup.ClientID %>').show();
        }
        function HidePopup() {
            $('#mask').hide();
            $('#<%=pnlpopup.ClientID %>').hide();
        }
        $(".btnClose").live('click', function () {
            HidePopup();
        });
    </script>

    <asp:Panel ID="pnlpopup" runat="server"  BackColor="White" Height="300px"
            Width="300px" Style="z-index:111; background:none; position: absolute; left: 40%; top: 15%; padding:5px;display:none">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        
        <h4 class="modal-title">Selected Product</h4>
      </div>
      <div class="modal-body">
          <asp:Label ID="LabelFid" runat="server" Text="" Visible="false"></asp:Label>
          <asp:Label ID="LabelP" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="LabelItemName" runat="server" Font-Size="X-Large"></asp:Label>
          <br />
          <br />
          <asp:Label ID="Label1" runat="server" Text="Quantity : "></asp:Label>
          <asp:TextBox ID="TextBoxQty" min="1" max="10" CssClass="form-control" type="number" runat="server"></asp:TextBox>
      </div>
      <div class="modal-footer">
        <asp:Button ID="btnUpdate" CommandName="Update" CssClass="btn btn-warning" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="ButtonClose" CssClass="btn btn-danger" runat="server" Text="Cancel" OnClick="ButtonClose_Click" />
      </div>
    </div>
</asp:Panel>
     
    <div class="container" style="text-align:center">
        <h3>Your Cart</h3>
        <hr />
        <asp:Label ID="LabelUid" runat="server" Visible="false" Text=""></asp:Label>
        <asp:Label ID="LabelErr" runat="server" Font-Size="X-Large" Text="Currently, there are no product in cart" ForeColor="#666666" Visible="False"></asp:Label>
        <br />
        <center>
        <asp:GridView ID="GridView1" CssClass="table table-bordered" AutoGenerateColumns="false" Width="60%" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnRowCommand="GridView1_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="PID" />
                <asp:BoundField HeaderText="Product Name" DataField="ProductName" />
            <asp:BoundField HeaderText="Cost" DataField="Cost" />
                <asp:BoundField HeaderText="Quantity" DataField="Qty" />
             <asp:BoundField HeaderText="Total Cost" DataField="TotCost" />
            <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("Pid")%>' CommandName="ShowPopup" Font-Bold="False" ForeColor="#009933" style="color: #00CC99" Text="Edit"></asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("Pid")%>' CommandName="Delete" Font-Bold="False" ForeColor="#009933" style="color: #00CC99" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
        </Columns>
        </asp:GridView>
            
        <div id="DivShow" runat="server">
         <table class="well well-sm" style="border: 1px solid #808080; width:60%; ">
            <tr>
                <td style="width: 60%; text-align: right; color: #333333; font-family: 'Century Gothic'; font-size: large; font-weight: normal;">Total :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:Label ID="LabelPrice" runat="server" Font-Bold="True" Font-Names="Century Gothic" Font-Size="XX-Large"></asp:Label>&nbsp;<asp:Label ID="Label2" runat="server" Text="/-" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
        </table>
            </div>
            </center>
         <br /><br />
         <div style="text-align:center">
         <asp:Button ID="ButtonPay" CssClass="btn btn-success" runat="server" OnClick="ButtonPay_Click" Text="Proceed to Pay" />
             </div>
    </div>

</asp:Content>

