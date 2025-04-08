<%@ Page Title="Create New Baby Sitting Request" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CreateRequest.aspx.cs" Inherits="CreateRequest" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Choose Date: "></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>


    </p>
    <h3> Please specify the approximate time (in 24 hours format) schedule for you want the service  </h3>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Start Time: "></asp:Label>
            <asp:DropDownList ID="DropDownListSTime1" runat="server">
                
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
            </asp:DropDownList>

          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownListSTime1" ErrorMessage="Required field cannot be left blank." Display="Dynamic">

</asp:RequiredFieldValidator>

    </p>

        <p>
        <asp:Label ID="Label3" runat="server" Text="EndTime : "></asp:Label>
                        <asp:DropDownList ID="DropDownListETime1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
            </asp:DropDownList>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownListETime1" ErrorMessage="Required field cannot be left blank." Display="Dynamic">

</asp:RequiredFieldValidator>
    </p>

    <p>
        <asp:Label ID="Label4" runat="server" Text="Any Special Comments or Requirements: "></asp:Label>
        <asp:TextBox ID="TxtComment" runat="server"></asp:TextBox>

                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtComment" ErrorMessage="Required field cannot be left blank." Display="Dynamic">

</asp:RequiredFieldValidator>

    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="For your which Child?"></asp:Label>
    <asp:DropDownList ID="DropDownListSelectChild" runat="server" DataSourceID="SqlDataSourceSelectChild" DataTextField="fname" DataValueField="fname"></asp:DropDownList>
    </p>
    <asp:SqlDataSource ID="SqlDataSourceSelectChild" runat="server" ConnectionString="<%$ ConnectionStrings:TestDB1ConnectionString4 %>" SelectCommand="SELECT [fname] FROM [Child] WHERE ([pid] = @pid)">
        <SelectParameters>
            <asp:Parameter DefaultValue="3" Name="pid" Type="Int32" />
        </SelectParameters>
</asp:SqlDataSource>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownListSelectChild" ErrorMessage="Required field cannot be left blank." Display="Dynamic">

</asp:RequiredFieldValidator>
    <p>&nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save Request" />
</p>
    


</asp:Content>
