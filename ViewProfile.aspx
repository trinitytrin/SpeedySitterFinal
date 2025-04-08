<%@ Page Title="View Profile Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ViewProfile.aspx.cs" Inherits="ViewProfile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>
        <asp:Button ID="Button1" runat="server" BackColor="#99CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" Height="81px" OnClick="Button1_Click" Text="View My Profile" Width="493px" />
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button2" runat="server" BackColor="#FF6699" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" Height="83px" OnClick="Button2_Click" Text="View Children Profile" Width="499px" />
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button3" runat="server" BackColor="#CCFF99" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" Height="80px" OnClick="Button3_Click" Text="View My Address" Width="500px" />
    </p>




    </asp:Content>
