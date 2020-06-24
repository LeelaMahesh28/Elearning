<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="OnlineApplication.AdminPage" %>

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
                    <td>
        
                        <asp:Button ID="Button1" runat="server" Text="User Details" OnClick="Button1_Click" style="height: 26px" />
                    </td>
                    <td>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                  </td>
                </tr>
            <tr>
                    <td>
        
                        <asp:Button ID="Button2" runat="server" Text="User-Course Details" OnClick="Button2_Click" style="height: 26px" />
                    </td>
                    <td>
                    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                  </td>
                </tr>
                <tr>
                    <td>
        
                        <asp:Button ID="Button3" runat="server" Text="User-Pay Details" OnClick="Button3_Click" style="height: 26px" />
                    </td>
                    <td>
                    <asp:GridView ID="GridView3" runat="server"></asp:GridView>
                  </td>
                </tr>
                <tr>
                    <td>
        
                        <asp:Button ID="Button4" runat="server" Text="Back" OnClick="Button4_Click" />
                    </td>
                    </tr>
                </table>
        </div>
    </form>
</body>
</html>
