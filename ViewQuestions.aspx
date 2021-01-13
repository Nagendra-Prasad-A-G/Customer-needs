<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="ViewQuestions.aspx.cs" Inherits="ViewQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
        
        <h4 class="modal-title">Selected Question</h4>
      </div>
      <div class="modal-body">
          <asp:Label ID="LabelQid" runat="server" Text="" Visible="false"></asp:Label>
          <asp:Label ID="Label2" runat="server" Text="Product Name : "></asp:Label><asp:Label ID="LabelPname" Font-Bold="true" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label3" runat="server" Text="Question : "></asp:Label>
          <asp:Label ID="LabelQuestion" runat="server" Font-Bold="true" Font-Size="Large"></asp:Label>
          <br />
          <br />
          <asp:Label ID="Label1" runat="server" Text="Answer : "></asp:Label>
          <asp:TextBox ID="TextBoxAns" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
      </div>
      <div class="modal-footer">
        <asp:Button ID="btnUpdate" CommandName="Update" CssClass="btn btn-warning" runat="server" Text="Submit" OnClick="btnUpdate_Click" />
        <asp:Button ID="ButtonClose" CssClass="btn btn-danger" runat="server" Text="Cancel" OnClick="ButtonClose_Click" />
      </div>
    </div>
</asp:Panel>
    <div class="container">
     <h2>Reply to Questions</h2>
        <asp:Label ID="LabelRid" runat="server" Visible="false" Text=""></asp:Label>
         <br /><br />
     <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" 
             BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
             CellSpacing="2" ForeColor="Black" Width="100%" 
            onrowcommand="GridView1_RowCommand" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="ID"/>
             <asp:BoundField HeaderText="Question" DataField="Question"/>
              <asp:BoundField HeaderText="Product ID" DataField="Pid"/>
               <asp:BoundField HeaderText="Date" DataField="Date"/>
            <asp:TemplateField HeaderText="Reply" SortExpression="">
                <ItemTemplate>
                    <asp:LinkButton ID="yes" runat="server" CommandArgument='<%#Eval("Id")%>' Font-Bold="true" Text='Reply'
                        CommandName="Reply" ForeColor="Blue"></asp:LinkButton>
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
        <asp:Label ID="Label4" runat="server" Visible="false" Text="Currently, there are no questions pending..!!"></asp:Label>
    </div>
</asp:Content>

