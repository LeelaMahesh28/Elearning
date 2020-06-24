<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="OnlineApplication.Pay" %>

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
                    <td> <asp:TextBox ID="TextUsid" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Course Id</td>
                    <td> <asp:TextBox ID="TextCsId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    
                    <td> <asp:Button ID="Button1" runat="server" Text="Pay" OnClick="Button1_Click" style="margin-top: 0px;" Width="70px" /></td>
                     <td> <asp:Button ID="Button3" runat="server" Text="Back" OnClick="Button3_Click" style="margin-top: 0px;" Width="70px" /></td>
                     
                </tr>
                <tr>
                    <td>Date</td>
                    <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td><asp:Label ID="Label2" runat="server" Text="Enter as MM/DD/YYYY"></asp:Label></td>
                    </tr>
                <tr>
                    <td> <asp:Button ID="Button2" runat="server" Text="Schedule Test" OnClick="Button2_Click" style="margin-bottom: 27px;" Height="37px" /></td>
               </tr>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </table>
        </div>
    </form>
</body>
</html>
