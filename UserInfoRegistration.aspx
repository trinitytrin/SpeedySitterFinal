<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfoRegistration.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 115px;
            text-align: right;
        }

        .auto-style2 {
            width: 115px;
            text-align: right;
            height: 26px;
        }

        .auto-style3 {
            height: 26px;
            width: 429px;
        }

        .auto-style4 {
            width: 429px;
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
            <table align="center">
                <caption>
                    <strong>User Registration</strong></caption>
                <tr>
                    <td class="auto-style2">First Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxFname" runat="server" OnTextChanged="TextBoxFname_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderColor="Red" ControlToValidate="TextBoxFname" ErrorMessage="First Name required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Last Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxLname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BorderColor="Red" ControlToValidate="TextBoxLname" ErrorMessage="Last Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">DOB</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxDob" runat="server" Height="22px" Width="201px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxDob" ErrorMessage="Valid Date of birth is required" ForeColor="Red"></asp:RequiredFieldValidator>


                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Sex</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownListsex" runat="server">
                            <asp:ListItem>Sex</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownListsex" ErrorMessage="Choose Sex" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Phone</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="Phone Number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1">Email</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox1" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1">Type</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownListUsertype" runat="server">
                            <asp:ListItem>User Type</asp:ListItem>
                            <asp:ListItem>Parent</asp:ListItem>
                            <asp:ListItem>BabySitter</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownListUsertype" ErrorMessage="Select User Type" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1">Visa Status</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownListVisa" runat="server">
                            <asp:ListItem>VisaType</asp:ListItem>
                            <asp:ListItem>H4 EAD</asp:ListItem>
                            <asp:ListItem>USCitizen</asp:ListItem>
                            <asp:ListItem>Green Card</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownListVisa" ErrorMessage="Select Visa Status" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblname" runat="server" Visible="false"></asp:Label>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                        <td class="auto-style4">
                            <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" />
                        </td>

                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
