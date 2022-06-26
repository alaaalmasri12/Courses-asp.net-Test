Imports essenseClassLibrary
Public Class Departments
    Inherits sitebasepage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)

        FillDepartments()
    End Sub

    Protected Sub FillDepartments()
        Dim languageid As Integer = 1
        Departments.DataSource = dbcontext.SelectAllDepartmentByLanguageID(languageid).ToList()
        Departments.DataBind()

    End Sub

    Protected Sub Departments_ItemDataBound(sender As Object, e As ListViewItemEventArgs)
        Dim StudentCount As Label = CType(e.Item.FindControl("StudentCount"), Label)
        Dim DepartmentID As HiddenField = CType(e.Item.FindControl("DepartmentID"), HiddenField)
        StudentCount.Text = dbcontext.SelectAllCoursesBylanugaeID(1).Where(Function(x) x.Department_ID = DepartmentID.Value).ToList().Count()
    End Sub


End Class