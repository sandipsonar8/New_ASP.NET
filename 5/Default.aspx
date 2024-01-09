<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_5_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>DropDownList</h2>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Id" DataValueField="Name">
            </asp:DropDownList>
            <br />
            <asp:Label ID="dl" runat="server"></asp:Label>
            <br />
            <h2>CheckBoxList</h2>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="cb" runat="server"></asp:Label>
            <br />
            <h2>RadioButtonList</h2>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Id" DataValueField="Name">
            </asp:RadioButtonList>

            <br />
            <asp:Label ID="rb" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />

        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
    </form>
</body>
</html>
