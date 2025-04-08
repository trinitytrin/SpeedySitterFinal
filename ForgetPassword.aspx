<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgetPassword.aspx.cs" Inherits="ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="js/JScript.js" ></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr>
            <td>
                <asp:Label id="lblfirstname" runat="server" Text="FirstName"></asp:Label>
           
                <asp:TextBox ID="txtfirstname" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Label id="lblusername" runat="server" Text="UserName"></asp:Label>
            
                <asp:TextBox ID="txtusername" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="lblpassword" runat="server" Text="Password"></asp:Label>
           
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" ></asp:TextBox>
            </td>
            
          
        </tr>
        <tr>
            <td>
               <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" />

            </td>
        </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
