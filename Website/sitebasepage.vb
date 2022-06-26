Imports essenseClassLibrary

Public Class sitebasepage
    Inherits System.Web.UI.Page



    Dim _dbcontext As essenseDataClassesDataContext

    Public ReadOnly Property dbcontext() As essenseDataClassesDataContext
        Get
            If IsNothing(_dbcontext) Then
                _dbcontext = New essenseDataClassesDataContext()

            End If
            Return _dbcontext
        End Get
    End Property

End Class
