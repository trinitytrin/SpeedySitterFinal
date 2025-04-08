<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="NewHome.aspx.cs" Inherits="NewHome" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 
    <br />
 
    <html>   
        <body>
    <h2><%: Title %>.</h2>

    
   

     <img src="welcome.jpg" width="100%" />


    
    
       

                 
        </body>
            </html>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" href="MapShow">Click to view map</asp:HyperLink>
</asp:Content>
