<%@ Page Title="Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Service.aspx.cs" Inherits="Service" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>&nbsp;</p>
    <asp:Button ID="Button1" runat="server" BackColor="#99FF99" BorderStyle="Groove" Height="72px" OnClick="Button1_Click" Text="Geocode Address" Font-Size="Large" Width="460px" />

<p>&nbsp;</p>
<p>
    <asp:Button ID="Button2" runat="server" BackColor="#CC66FF" BorderStyle="Groove" Font-Bold="True" Font-Size="Medium" Height="83px" OnClick="Button2_Click" Text="Find Nearby Parent/BabySitter" Width="461px" />
</p>
<p>&nbsp;</p>
<p>
    <asp:Button ID="Button3" runat="server" BackColor="#66CCFF" BorderStyle="Groove" Font-Bold="True" Font-Size="Large" Height="79px" OnClick="Button3_Click" Text="Request Service" Width="462px" />
</p>
<p>&nbsp;</p>

    

   


    </asp:Content>