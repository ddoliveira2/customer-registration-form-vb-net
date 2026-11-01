
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports presentation.Dal
Imports presentation.Dal.Dao
Imports presentation.Dto
Imports presentation.presentation.Dal

Namespace presentation.Bll

    Public Class CustomerBll

        Private _dal As CustomerDal

        Public Sub New()
            Me._dal = New CustomerDal()
        End Sub

        Public Function GetOneCustome(id As String) As CustomerDto
            Try
                Dim _id As Int64 = 0

                Int64.TryParse(id, _id)

                If _id > 0 Then
                    Return _dal.GetOneCustome(_id)
                End If

                Return New CustomerDto()

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GetListCustomer(name As String, rg As String, cpf As String) As List(Of CustomerDto)
            Try
                Return _dal.GetListCustomer(name, rg, cpf)

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function CreateCustomer(obj As CustomerDto, ByRef msg As String) As CustomerDto
            Try
                msg = "Cliente cadastrado com sucesso!"

                If String.IsNullOrEmpty(obj.name) OrElse
                   String.IsNullOrEmpty(obj.rg) OrElse
                   String.IsNullOrEmpty(obj.cpf) Then

                    msg = "Verificar se todos parametros foram preenchidos!"
                    Return New CustomerDto()
                End If

                Return _dal.CreateCustomer(obj)

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function UpdateCustomer(id As String, obj As CustomerDto, ByRef msg As String) As CustomerDto
            Try
                msg = "Cliente Atualizado com sucesso!"

                Dim _id As Int64 = 0

                Int64.TryParse(id, _id)

                If _id = 0 Then
                    msg = "Id do cliente não foi informado!"
                    Return New CustomerDto()
                End If

                If String.IsNullOrEmpty(obj.name) OrElse
                   String.IsNullOrEmpty(obj.rg) OrElse
                   String.IsNullOrEmpty(obj.cpf) Then

                    msg = "Verificar se todos parametros foram preenchidos!"
                    Return New CustomerDto()
                End If

                Return _dal.UpdateCustomer(_id, obj)

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function DeleteCustomer(id As String, ByRef msg As String) As CustomerDto
            Try
                msg = "Cliente Deletado com sucesso!"

                Dim _id As Int64 = 0

                Int64.TryParse(id, _id)

                If _id = 0 Then
                    msg = "Id do cliente não foi informado!"
                    Return New CustomerDto()
                End If

                Return _dal.DeleteCustomer(_id)

            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class

End Namespace
