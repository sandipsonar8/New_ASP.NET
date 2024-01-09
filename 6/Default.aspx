<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_6_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            border-color: #808080;
            background-color: #cccccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            

           
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [stud]"></asp:SqlDataSource>
            <table class="auto-style1">
                <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate><tr>
                    <td>NAME</td>
                    <td>ID</td>
                </tr></HeaderTemplate>
                <AlternatingItemTemplate >
                    <tr><td style ="background-color :Gray ;"><%#Eval("name") %></td>
                    <td style ="background-color :Gray;"><%#Eval("id")%> </td></tr>
                </AlternatingItemTemplate>
                <ItemTemplate><tr>
                    <td><%#Eval("name") %></td>
                    <td><%#Eval("id") %></td>
                </tr></ItemTemplate>

                </asp:Repeater>
            </table>
            <br />
            

        </div>
    </form>
</body>
</html>
