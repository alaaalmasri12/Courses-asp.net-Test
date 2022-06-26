<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Courses.aspx.vb" Inherits="Website.Courses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-responsive mt-3">
          <thead>
    <tr>
      <th scope="col">Course Name</th>
      <th scope="col">Course Department</th>
      <th scope="col">Course code</th>
       <th scope="col">Course Description</th>

    </tr>
  </thead>
       <tbody>
    <asp:ListView ID="Courses" runat="server" ItemType="essenseClassLibrary.SelectAllCoursesBylanugaeIDResult" OnItemDataBound="Courses_ItemDataBound"  >
          <ItemTemplate>
        <tr>    
         <asp:HiddenField ID="DepartmentID" runat="server" Value="<%#Item.Department_ID %>" />
     <td><a  href="#" class="courseDetails" data-precourse="<%#Item.Course_Preid %>"> <%#Item.Course_Name %></a></td>
      <td><asp:Label ID="CourseDepartment" runat="server"></asp:Label></td>
       <td><%#Item.Course_Code %></td>
        <td><%#Item.Course_Description %></td>
    </tr>

          </ItemTemplate>
      </asp:ListView>
           </tbody>
        </table> 
    <div class="CoruseDetails">
     <table id="CoruseDetailsResult" class="table table-bordered">  
                <thead class="bg-primary text-white">  
                    <tr>  
                        <th>ID</th>  
                        <th>Name</th>  
                        <th>Position</th>  
                        <th>Office</th>  
                        <th>Age</th>  
                        <th>Salary</th>  
                    </tr>  
                </thead>  
                <tbody></tbody>  
            </table>  
        </div>
</asp:Content>
