Public Class Courses
    Inherits sitebasepage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCourses()
    End Sub

    Protected Sub FillCourses()
        Courses.DataSource = dbcontext.SelectAllCoursesBylanugaeID(1).ToList()
        Courses.DataBind()
    End Sub


    Protected Sub Courses_ItemDataBound(sender As Object, e As ListViewItemEventArgs)
        Dim CourseDepartment As Label = CType(e.Item.FindControl("CourseDepartment"), Label)
        Dim DepartmentID As HiddenField = CType(e.Item.FindControl("DepartmentID"), HiddenField)
        CourseDepartment.Text = dbcontext.SelectAllDepartmentByLanguageID(1).Where(Function(x) x.ID = DepartmentID.Value).FirstOrDefault().Department_Name
    End Sub
End Class