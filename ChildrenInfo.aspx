<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChildrenInfo.aspx.cs" Inherits="ChildrenInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            width: 334px;
        }
    </style>
</head>
<body>

         <p>&nbsp;</p>
    <p>&nbsp;</p>
   <div style="float:left;width:50%">
     <img src="welcome.jpg" width="100%" />
       </div>


    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox5" runat="server" style="font-weight: 700" Width="261px">Enter Child Information Here</asp:TextBox>
    <table>
        <tr>
            <td class="auto-style1">First Name</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="First Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td class="auto-style1">Last Name</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Last Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

                
        </tr>
        <tr>
            <td class="auto-style1">DOB</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Date of birth is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

                
        </tr>
        <tr>
            <td class="auto-style1">Sex</td>
            <td class="auto-style2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Sex</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select Sex" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

                
        </tr>
        <tr>
            <td class="auto-style1">Special Needs</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="Special Needs is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

                
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="text-align: right" Width="156px" />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="157px" />
            </td>
        </tr>
    </table>
        <table>
    <tr>
    <td align="center">
        &nbsp;</td>
       </tr>
       </table>

    </div>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Go Back Home" Width="473px" />
        <br />
    </form>
</body>
</html>
