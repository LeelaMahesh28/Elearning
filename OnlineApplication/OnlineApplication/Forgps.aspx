<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forgps.aspx.cs" Inherits="OnlineApplication.Forgps" %>

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
                    <td>User Id</td>
                    <td><asp:TextBox ID="TextId" runat="server" style="margin-left: 0px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>User New Password</td>
                    <td><asp:TextBox ID="TextPassword" runat="server" style="margin-left: 0px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="Button1" runat="server" Text="Reset" OnClick="Enter_Reset" /></td>
                </tr>
                <tr>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </tr>
            </table>
        </div>
    </form>
</body>
</html>
