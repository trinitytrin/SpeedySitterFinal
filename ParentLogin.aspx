<%@ Page Title="Parent Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ParentLogin.aspx.cs" Inherits="ParentLogin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   

    <h2><%: Title %>.</h2>

    
        <p>&nbsp;</p>
    <p>&nbsp;</p>
   <div style="float:left;width:50%">
     <img src="welcome.jpg" width="100%" />
       </div>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" Width="628px" Height="259px">
     </asp:Login>
   
    <p>&nbsp;</p>
    <p>&nbsp;</p>
   


    </asp:Content>

