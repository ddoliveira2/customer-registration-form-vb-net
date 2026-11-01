Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("customer")>
Public Class CustomerDto
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property id As Int64
    Public Property name As String
    Public Property rg As String
    Public Property cpf As String
    Public Property status As Boolean

End Class
