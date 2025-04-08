<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
</head>
<body>

     <p>&nbsp;</p>
    <p>&nbsp;</p>
   <div style="float:left;width:50%">
     <img src="welcome.jpg" width="100%" />
       </div>


    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr>
            <td>
                <asp:Label id="lblname" runat="server" Text="Username"></asp:Label>

                <asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
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
               <asp:Button ID="btnsubmit" runat="server" Text="Log in" OnClick="btnsubmit_Click" />
                <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" />

            </td>
        </tr>
         <tr>
            <td>
               <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="btnregister_Click" />
                <asp:Button ID="btnforget" runat="server" Text="ForgetPassword" OnClick="btnforget_Click" />

            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
