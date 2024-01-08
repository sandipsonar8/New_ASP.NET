<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_3_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>ViewState and Postback Demo</h2>

            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            
            <asp:DropDownList ID="DropDownList2" runat="server" EnableViewState="False"></asp:DropDownList>

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

        </div>
    </form>
</body>
</html>
