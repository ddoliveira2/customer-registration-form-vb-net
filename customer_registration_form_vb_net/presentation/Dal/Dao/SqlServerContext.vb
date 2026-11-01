Imports presentation.Dto
Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Runtime.Remoting.Contexts
Imports System.Text
Imports System.Threading.Tasks

Namespace presentation.Dal.Dao

    Public Class SqlServerContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("Server=localhost;Database=CustomerDb;User Id=sa;Password=123456;TrustServerCertificate=True;")
        End Sub

        Public Property Customer As DbSet(Of CustomerDto)

    End Class

End Namespace