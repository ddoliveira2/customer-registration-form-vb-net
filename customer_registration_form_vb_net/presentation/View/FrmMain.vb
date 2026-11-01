Public Class FrmMain
    Private Sub mSair_Click(sender As Object, e As EventArgs) Handles mSair.Click
        If MessageBox.Show("Deseja sair?",
                   "Sair",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            Me.Close()

        End If
    End Sub

    Private Sub cadastraAlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cadastraAlterarToolStripMenuItem.Click

    End Sub

    Private Sub mClient_Click(sender As Object, e As EventArgs) Handles mClient.Click
        Dim frm As New FrmListCustomer()
        frm.TopLevel = False
        Me.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AdjustMainScreen()
    End Sub
End Class