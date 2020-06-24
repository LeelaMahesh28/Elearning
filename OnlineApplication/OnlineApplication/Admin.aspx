<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="OnlineApplication.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Admin name</td>
                    <td>
                        <asp:TextBox ID="TextAdmin" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Admin password</td>
                    <td>
                         <asp:TextBox ID="TextPassword" runat="server" style="margin-left: 0px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td>
                        <asp:Button ID="Enter" runat="server" Text="Login" OnClick="Enter_Login" style="height: 26px" />
                    </td>
                </tr>
                <tr>
                <td></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </td>
                <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
