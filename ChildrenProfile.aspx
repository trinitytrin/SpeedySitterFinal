<%@ Page Title="Children Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ChildrenProfile.aspx.cs" Inherits="ChildrenProfile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    
 <h3>Child Information Show/edit page.</h3>
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
    </p>
<p>
    <asp:TextBox ID="TxtID" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TxtName" runat="server" Width="170px"></asp:TextBox>
    </p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="fName" HeaderText="fName" SortExpression="fName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestDB1ConnectionString %>" SelectCommand="SELECT [id], [fName] FROM [UserInfo] WHERE [id]=2"></asp:SqlDataSource>
</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
   


    </asp:Content>
