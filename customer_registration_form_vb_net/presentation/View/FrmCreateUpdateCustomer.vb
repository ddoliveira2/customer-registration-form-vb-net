Imports presentation.presentation.Bll

Public Class FrmCreateUpdateCustomer
    Private _bll As CustomerBll
    Private _id As String
    Private _msg As String

    Public Sub New(id As String)

        InitializeComponent()

        Me._id = id
        Me._bll = New CustomerBll()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        txtName.Clear()
        txtCpf.Clear()
        txtRg.Clear()
        txtName.Focus()
    End Sub

    Private Sub FrmCreateUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id As Int64 = 0

        Int64.TryParse(Me._id, id)
        Me.Text = "Cadastrar Cliente"

        If id > 0 Then
            Me.Text = "Alterar Cliente"
            Dim update As CustomerDto = _bll.GetOneCustome(Me._id)

            txtCode.Text = Me._id
            txtName.Text = update.name
            txtRg.Text = update.rg
            txtCpf.Text = update.cpf

            If update.status = True Then
                cboStatus.SelectedIndex = 0
            Else
                cboStatus.SelectedIndex = 1
            End If

        End If

        txtName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not String.IsNullOrEmpty(txtCode.Text) Then

            Dim update As New CustomerDto With {
                .name = txtName.Text,
                .rg = txtRg.Text,
                .cpf = txtCpf.Text,
                .status = If(cboStatus.SelectedIndex = 0, True, False)
            }

            _bll.UpdateCustomer(txtCode.Text, update, _msg)

            MessageBox.Show(_msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else

            Dim create As New CustomerDto With {
                .name = txtName.Text,
                .rg = txtRg.Text,
                .cpf = txtCpf.Text,
                .status = If(cboStatus.SelectedIndex = 0, True, False)
            }

            _bll.CreateCustomer(create, _msg)

            MessageBox.Show(_msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If
    End Sub
End Class