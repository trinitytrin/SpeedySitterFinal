<%@ Page Title="Set Preference" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="SetPreference.aspx.cs" Inherits="SetPreference" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

           <div style="float:left;width:50%">
     <img src="welcome.jpg" width="100%" />
       </div>

    				<form>
				<table width="100%" cellspacing="5" cellpadding="5">
					<tr>
						<td colspan="2"><label style="color: #B4886B;font-weight: bold; display: block; width: 150px;float: left;">Request as </label></td>
						<td colspan="4">
							<label><input type="radio" name="request_type" value="parent" checked/>Parent</label>
							<label><input type="radio" name="request_type" value="babysitter" />Baby Sitter</label>
						</td>
					</tr>
					<tr>
						<td><label style="color: #B4886B;font-weight: bold; display: block; width: 150px;float: left;">Start Time</label></td>
						<td><input type="text" id="starttime"/></td>
						<td><label style="color: #B4886B;font-weight: bold; display: block; width: 150px;float: left;">End Time</label></td>
						<td><input type="text" id="endtime"/></td>
						<td><label style="color: #B4886B;font-weight: bold; display: block; width: 150px;float: left;">Date</label></td>
						<td><input type="text" id="datepicker"/></td>
					</tr>
					<tr>
						<td colspan="2">
							<input type="button" style="padding:5px 10px;text-align:center;font-size:16px;color:#57B5F0;" name="search" value="Search" />
						</td>
					</tr>
				</table>
				</form>
    
    </asp:Content>