<%@ Page Title="" Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Departments.aspx.vb" Inherits="Website.Departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
  <table class="table">
  <thead>
    <tr>
      <th scope="col">Department Name</th>
      <th scope="col">Departy StudentCount</th>
    </tr>
  </thead>
  <tbody>
      <asp:ListView ID="Departments" runat="server" ItemType="essenseClassLibrary.SelectAllDepartmentByLanguageIDResult"  OnItemDataBound="Departments_ItemDataBound">
          <ItemTemplate>
        <tr>    
      <td><%#Item.Department_Name %></td>
            <asp:HiddenField ID="DepartmentID" runat="server" Value="<%#Item.ID %>" />
      <td><asp:Label ID="StudentCount" runat="server"></asp:Label></td>
    </tr>
          </ItemTemplate>
      </asp:ListView>
   
  </tbody>
</table>
</asp:Content>
