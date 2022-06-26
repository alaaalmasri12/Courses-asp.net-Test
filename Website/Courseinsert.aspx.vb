Public Class Courseinsert
    Inherits sitebasepage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            FillCourses()
            FillDepartments()
        End If

    End Sub

    Protected Sub FillCourses()
        CoursesList.Items.Add(New ListItem("please Select", "-999"))
        Dim Courses = dbcontext.SelectAllCoursesBylanugaeID(1).ToList().Where(Function(x) x.IsDeleted = False)
        For Each item In Courses
            CoursesList.Items.Add(New ListItem(item.Course_Name, item.ID))
        Next

    End Sub

    Protected Sub CoursesList_SelectedIndexChanged(sender As Object, e As EventArgs)
        PreDropDownList.Items.Clear()
        Dim precourse = dbcontext.SelectAllCoursesjoinByylanugaeID(1).ToList().Where(Function(x) x.ID = CoursesList.SelectedValue)
        If precourse.ToList().Count > 0 Then
            For Each item In precourse
                PreDropDownList.Items.Add(New ListItem(item.course_name, item.prerequisite_course_id))
            Next
        Else
            CoursesList.Items.Add(New ListItem("No PreCourse", "-999"))

        End If

    End Sub
    Protected Sub FillDepartments()
        DepartmentsList.Items.Clear()
        Dim Departments = dbcontext.SelectAllDepartmentByLanguageID(1).ToList().Where(Function(x) x.IsDeleted = False).ToList()
        If Departments.Count() > 0 Then
            For Each item In Departments
                DepartmentsList.Items.Add(New ListItem(item.Department_Name, item.ID))
            Next
        Else
            PreDropDownList.Items.Add(New ListItem("node data", "-999"))

        End If

    End Sub

    Protected Sub submit_Click(sender As Object, e As EventArgs)
        Dim precourse As Integer = PreDropDownList.SelectedValue
        Dim Course As String = coursename.text
        Dim Department As Integer = DepartmentsList.SelectedValue
        Dim Couesecode As String = CourseCode.Text
        Dim courseDescription As String = Description.Text
        dbcontext.InsertCourses(Department, Course, Couesecode, courseDescription, False, 1)
        Dim lastid = dbcontext.SelectAllCoursesBylanugaeID(1).LastOrDefault().ID
        dbcontext.InsertPrerequisite(lastid, CoursesList.SelectedValue, 1)
    End Sub
End Class