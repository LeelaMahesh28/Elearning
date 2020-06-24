<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="ADMIN" OnClick="Enter_Click" style="height: 26px" />
                    </td>
                    <td class="auto-style2">                         </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="USER" OnClick="Enter_User" style="height: 26px" />
                    </td>
                </tr>
               
            </table>
        </div>
    </form>
</body>
</html>
