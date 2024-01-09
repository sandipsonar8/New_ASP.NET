<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_4_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 68%;
            border-right-color: #C0C0C0;
            border-bottom-color: #C0C0C0;
            background-color: #CCCCCC;
        }
        .auto-style2 {
            text-align: right;
            width: 303px;
        }
        .auto-style3 {
            width: 409px;
            text-align: center;
        }
        .auto-style4 {
            width: 452px;
        }
        .auto-style5 {
            text-align: right;
            width: 303px;
            height: 29px;
        }
        .auto-style6 {
            width: 409px;
            text-align: center;
            height: 29px;
        }
        .auto-style7 {
            width: 452px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h2>Registration Page</h2>
            </center>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">First Name :</td>
            <center>
                <td class="auto-style3">
                    <asp:TextBox ID="fn" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fn" ErrorMessage="Can't leave this feild empty" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Last Name :</td>
            <center>
                <td class="auto-style3">
                    <asp:TextBox ID="ln" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Email ID :</td>
            <center>
                <td class="auto-style3">
                    <asp:TextBox ID="eid" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="eid" ErrorMessage="Invalid E-mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Password :</td>
            <center>
                <td class="auto-style3">
                    <asp:TextBox ID="pw" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">Re-Enter Password :</td>
            <center>
                <td class="auto-style3">
                    <asp:TextBox ID="rpw" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pw" ControlToValidate="rpw" ErrorMessage="wrong pass"></asp:CompareValidator>
                                    </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style2">Age :</td>
            <center>
                <td class="auto-style3">
                    <asp:TextBox ID="age" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" ErrorMessage="&gt;18 and &lt;50" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>
                                        </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">Mobile Number :</td>
            <center>
                <td class="auto-style3">
                    <asp:TextBox ID="mob" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="mob" ErrorMessage="Invalid Mob No" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                                            </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style5">User ID :</td>
            <center>
                <td class="auto-style6">
                    <asp:TextBox ID="uid" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="uid" ErrorMessage="Wrong ID" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                                                </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style2">&nbsp;</td>
            <center>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style2">&nbsp;</td>
            <center>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
                <td class="auto-style4">&nbsp;</td>
                                                        </tr>
                                                </table>
                                            </center>
                                        </center>
                                    </center>
                                </center>
                            </center>
                        </center>
                    </center>
                </center>
                </center>
            </center>
        </div>
    </form>
    </body>
</html>
