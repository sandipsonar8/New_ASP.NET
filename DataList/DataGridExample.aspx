<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataGridExample.aspx.cs" Inherits="DataList_DataGridExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <h2>DataGrid Example</h2>

            <asp:DataGrid ID="dataGridProducts" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                oneditcommand="dataGridProducts_EditCommand" 
                oncancelcommand="dataGridProducts_CancelCommand" 
                onupdatecommand="dataGridProducts_UpdateCommand">
                <Columns>
                    <asp:BoundColumn HeaderText="Product ID" DataField="ProductID" ReadOnly="True" />
                    <asp:TemplateColumn HeaderText="Product Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtProductName" runat="server" Text='<%# Bind("ProductName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblProductName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Price">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrice" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("Price", "{0:C}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" />
                </Columns>
            </asp:DataGrid>

            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [stud]"></asp:SqlDataSource>
            <br />
            <asp:DataGrid runat="server" DataSourceID="SqlDataSource1">

            </asp:DataGrid>

        </div>
    </form>
</body>
</html>
