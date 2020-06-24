<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="OnlineApplication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>Sign Up</p>
        <div>
            <table>
               <tr>
                    <td>User Id</td>
                    <td>
                        <asp:TextBox ID="TextId" runat="server"></asp:TextBox>
                    </td>
                   </tr>
                   <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="TextUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>UserPassword</td>
                    <td>
                        <asp:TextBox ID="TextPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Enter_Signup" style="height: 26px" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Enter_Back" style="height: 26px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </table>
        </div>
    </form>
</body>
</html>
