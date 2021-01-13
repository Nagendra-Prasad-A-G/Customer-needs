<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="ManageRetailer.aspx.cs" Inherits="ManageRetailer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container">
    <h2>Manage Retailer</h2>
        <div class="col-md-12" align="right">
            <asp:LinkButton CssClass="btn btn-info" ID="LinkButton1" runat="server" 
                onclick="LinkButton1_Click">ADD RETAILER
                <i class="glyphicon glyphicon-plus"></i></asp:LinkButton>
        </div>
        <br /><br />
     <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" 
             BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
             CellSpacing="2" ForeColor="Black" Width="100%" 
            onrowcommand="GridView1_RowCommand" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="RID"/>
             <asp:BoundField HeaderText="Name" DataField="RetailerName"/>
              <asp:BoundField HeaderText="Owner" DataField="OwnerName"/>
               <asp:BoundField HeaderText="Email" DataField="Email"/>
               <asp:BoundField HeaderText="Contact" DataField="Contact"/>
                <asp:BoundField HeaderText="Address" DataField="Address"/>

            <asp:TemplateField HeaderText="Delete" SortExpression="">
                <ItemTemplate>
                    <asp:LinkButton ID="yes" runat="server" CommandArgument='<%#Eval("RID")%>' Font-Bold="true" Text='DELETE'
                        CommandName="yes" ForeColor="Red"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>
</asp:Content>

