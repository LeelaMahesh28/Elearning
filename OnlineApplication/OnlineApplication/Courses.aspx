<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="OnlineApplication.Courses" %>

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
        
                        <asp:Button ID="Button1" runat="server" Text="View Course" OnClick="Button1_Click" style="height: 26px" />
                    </td>
                
                    
                    <td>
        
                        <asp:Button ID="Button2" runat="server" Text="Register Course" OnClick="Button2_Click" style="height: 26px" />
                    </td>
                <td>
        
                        <asp:Button ID="Button3" runat="server" Text="Pay for course" OnClick="Button3_Click" style="height: 26px" />
                    </td>
                <td>
        
                        <asp:Button ID="Button4" runat="server" Text="Back" OnClick="Button4_Click" style="height: 26px" />
                    </td>
                </tr>
                <tr>
                    
                    <td>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                  </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
