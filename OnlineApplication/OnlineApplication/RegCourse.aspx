<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegCourse.aspx.cs" Inherits="OnlineApplication.RegCourse" %>

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
                    <td>
                        <asp:TextBox ID="TextUid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>User Name</td>
                    <td>
                        <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Course Id</td>
                    <td>
                         <asp:TextBox ID="TextCid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" style="height: 26px" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" style="height: 26px" />
                    </td>
                </tr>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </table>
        </div>
    </form>
</body>
</html>
