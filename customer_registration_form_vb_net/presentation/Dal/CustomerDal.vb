
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports presentation.Dal.Dao
Imports presentation.Dto
Imports presentation.presentation.Dal.Dao

Namespace presentation.Dal

    Public Class CustomerDal

        Public Function GetOneCustome(id As Int64) As CustomerDto
            Try
                Using conn As New SqlServerContext()

                    Return conn.Customer.FirstOrDefault(Function(i) i.id = id)

                End Using
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetListCustomer(name As String, rg As String, cpf As String) As List(Of CustomerDto)
            Try
                Using conn As New SqlServerContext()

                    Return conn.Customer.Where(
                        Function(i) i.name.Contains(name) AndAlso
                                    i.rg.Contains(rg) AndAlso
                                    i.cpf.Contains(cpf)
                    ).ToList()

                End Using
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function CreateCustomer(obj As CustomerDto) As CustomerDto

            Dim insert As New CustomerDto()

            Using conn As New SqlServerContext()

                insert.name = obj.name
                insert.rg = obj.rg
                insert.cpf = obj.cpf
                insert.status = True

                conn.Customer.Add(insert)
                conn.SaveChanges()

                Return insert

            End Using

        End Function

        Public Function UpdateCustomer(id As Int64, obj As CustomerDto) As CustomerDto

            Using conn As New SqlServerContext()

                Dim selected As CustomerDto =
                    conn.Customer.FirstOrDefault(Function(i) i.id = id)

                If selected IsNot Nothing Then

                    selected.name = obj.name
                    selected.rg = obj.rg
                    selected.cpf = obj.cpf
                    selected.status = obj.status

                    conn.SaveChanges()

                End If

                Return selected

            End Using

        End Function

        Public Function DeleteCustomer(id As Int64) As CustomerDto

            Using conn As New SqlServerContext()

                Dim delete As CustomerDto =
                    conn.Customer.FirstOrDefault(Function(i) i.id = id)

                If delete IsNot Nothing Then

                    conn.Customer.Remove(delete)
                    conn.SaveChanges()

                End If

                Return delete

            End Using

        End Function

    End Class

End Namespace
