<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cadastraAlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cadastraAlterarToolStripMenuItem, Me.mSair})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'cadastraAlterarToolStripMenuItem
        '
        Me.cadastraAlterarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mClient})
        Me.cadastraAlterarToolStripMenuItem.Name = "cadastraAlterarToolStripMenuItem"
        Me.cadastraAlterarToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.cadastraAlterarToolStripMenuItem.Text = "Cadastra / Alterar"
        '
        'mClient
        '
        Me.mClient.Name = "mClient"
        Me.mClient.Size = New System.Drawing.Size(180, 22)
        Me.mClient.Text = "Cliente"
        '
        'mSair
        '
        Me.mSair.Name = "mSair"
        Me.mSair.Size = New System.Drawing.Size(38, 20)
        Me.mSair.Text = "Sair"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.menuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmMain"
        Me.Text = "Principal"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents cadastraAlterarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents mClient As ToolStripMenuItem
    Private WithEvents mSair As ToolStripMenuItem
End Class
