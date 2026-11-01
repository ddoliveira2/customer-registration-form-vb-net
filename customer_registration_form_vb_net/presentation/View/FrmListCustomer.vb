Imports presentation.presentation.Bll

Public Class FrmListCustomer

    Private _bll As CustomerBll

    Public Sub New()

        InitializeComponent()
        _bll = New CustomerBll()

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim create As New FrmCreateUpdateCustomer("")
        create.ShowDialog()

        CarregaGrid()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmListCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CarregaGrid()
    End Sub

    Private Sub dgvCustomer_DoubleClick(sender As Object, e As EventArgs) Handles dgvCustomer.DoubleClick
        If dgvCustomer.Rows.Count > 0 Then

            Dim update As New FrmCreateUpdateCustomer(dgvCustomer.CurrentRow.Cells("id").Value.ToString())

            update.ShowDialog()

            CarregaGrid()

        End If
    End Sub

    Private Sub CarregaGrid()

        dgvCustomer.DataSource = _bll.GetListCustomer(txtName.Text, txtRg.Text, txtCpf.Text)

        dgvCustomer.Columns("status").Visible = False

        dgvCustomer.Columns("id").Width = 150
        dgvCustomer.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCustomer.Columns("id").HeaderText = "Código"

        dgvCustomer.Columns("name").Width = 150
        dgvCustomer.Columns("name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCustomer.Columns("name").HeaderText = "Nome"
        dgvCustomer.Columns("name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        dgvCustomer.Columns("rg").Width = 150
        dgvCustomer.Columns("rg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCustomer.Columns("rg").HeaderText = "RG"

        dgvCustomer.Columns("cpf").Width = 150
        dgvCustomer.Columns("cpf").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCustomer.Columns("cpf").HeaderText = "CPF"

    End Sub
End Class