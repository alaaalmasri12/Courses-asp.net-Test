<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Courseinsert.aspx.vb" Inherits="Website.Courseinsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <updatepanel id="updatedetails" runat="server">
        <div class="CourseInsertDetails mt-5">
            <div class="form-group row">
                <label for="CourseName" class="col-sm-2 col-form-label">Courses:</label>
                <div class="col-sm-10">
                    <asp:DropDownList CssClass="form-control" ID="CoursesList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CoursesList_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group row">
                <label for="PreCourse" class="col-sm-2 col-form-label">PreCourse</label>
                <div class="col-sm-10">
                    <asp:DropDownList CssClass="form-control" ID="PreDropDownList" runat="server" OnSelectedIndexChanged="CoursesList_SelectedIndexChanged">
                    </asp:DropDownList>

                </div>
            </div>
                 <div class="form-group row">
                <label for="PreCourse" class="col-sm-2 col-form-label">Course Name:</label>
                <div class="col-sm-10">
                   <asp:TextBox ID="coursename" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
            </div>
            <div class="form-group row">
                <label for="Department" class="col-sm-2 col-form-label">Department</label>
                <div class="col-sm-10">
                    <asp:DropDownList CssClass="form-control" ID="DepartmentsList" runat="server">
                    </asp:DropDownList>

                </div>
            </div>
            <div class="form-group row">
                <label for="CourseCode" class="col-sm-2 col-form-label">Course Code:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="CourseCode" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="Description" class="col-sm-2 col-form-label">Description:</label>
                <div class="col-sm-10">
                    <asp:TextBox Rows="3" Columns="3" CssClass="form-control" ID="Description" runat="server"></asp:TextBox>
                </div>
            </div>

            <asp:Button ID="submit" CssClass="btn btn-primary" Text="submit" runat="server" OnClick="submit_Click" />
        </div>
    </updatepanel>
</asp:Content>
