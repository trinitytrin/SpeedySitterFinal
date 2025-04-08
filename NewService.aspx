<%@ Page Title="Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="NewService.aspx.cs" Inherits="NewService" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    
 <h3>Get the service of finding baby sitters nearby</h3>
    <h3>&nbsp;</h3>
    <h3>
        <asp:HyperLink ID="geocodeAddress1" runat="server" href="GeocodeAddress.cshtml">Step 1: Save Your Geocode Address (Convert your current Address to Latitude and Longitude)</asp:HyperLink>
        <p> Save your current address to the system database to find nearby Baby sitters/Parents </p>
        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>

 <h3>
         <asp:HyperLink ID="ShowAddress" runat="server" href="ShowResultAddress.aspx">Step 2: Find your Nearby Parents/Baby Sitters</asp:HyperLink>
    </h3>
                <h3>
         <asp:HyperLink ID="findNearby" runat="server" href="CreateNewRequest.cshtml">Step 3: Create New Baby Sitting Service Request</asp:HyperLink>
    </h3>
   


    </asp:Content>
