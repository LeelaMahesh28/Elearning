<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="OnlineApplication.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 342px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="TextUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Userpassword</td>
                    <td>
                         <asp:TextBox ID="TextPassword" runat="server" style="margin-left: 0px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    
                    <td>
                        <asp:Button ID="Enter" runat="server" Text="Login" OnClick="Enter_Click" style="height: 26px" />
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Enter_Reg" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Forget Password" OnClick="Enter_Forgpass" />
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