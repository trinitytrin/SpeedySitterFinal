<%@ Page Title="Parent Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ParentRegister.aspx.cs" Inherits="ParentRegister" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

       <div style="float:left;width:50%">
     <img src="welcome.jpg" width="100%" />
       </div>
 <h3>Please fill out the form and complete registration.</h3>
   					<table width="100%">
                         <tr>
							<td><label><input type="radio" name="type" id="type" value="parent" onClick="_onTypeSelect('parent');" checked="checked"/>Parents</label></td>
							<td><input type="radio" name="type" id="type" value="babysitter" onClick="_onTypeSelect('babysitter');"/>Baby Sitter</td>
						</tr>

						<tr>
							<td><label for="fname"><b>First Name</b></label></td>
							<td><input type="text" id="fname" name="fname" required></td>
						</tr>
						<tr>
							<td><label for="lname"><b>Last Name</b></label></td>
							<td><input type="text" id="lanme" name="lname" required></td>
						</tr>
						<tr>
							<td><label for="email"><b>Email Id</b></label></td>
							<td><input type="email" id="email" name="email" required></td>
						</tr>
						<tr>
							<td><label for="username"><b>Username</b></label></td>
							<td><input type="text" id="username" name="username" required></td>
						</tr>
						<tr>
							<td><label for="password"><b>Password</b></label></td>
							<td><input type="password" id="password" name="password" required></td>
						</tr>
						<tr>
							<td><label for="dob"><b>Date of Birth</b></label></td>
							<td><input type="date" id="dob" name="dob" required></td>
						</tr>
						<tr id="workpermitrow" style="display: none;">
							<td><label for="workpermit"><b>Work Permit</b></label></td>
							<td><select name="workpermit">
								<option value="uscitizen">US Citizen</option>
								<option value="prholder">Permit Residency Holder</option>
								<option value="other" selected>Others</option>
							</select></td>
						</tr>
						<tr>
							<td colspan="2" align="center"><input type="submit" value="Register"></td>
						</tr>
                           </table>


    </asp:Content>
