<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateUpdateCustomer
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(212, 128)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(293, 128)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 17
        Me.btnClean.Text = "Limpar"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(374, 128)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Sair"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cboStatus.Location = New System.Drawing.Point(332, 24)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(117, 21)
        Me.cboStatus.TabIndex = 15
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(257, 102)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(192, 20)
        Me.txtCpf.TabIndex = 11
        '
        'txtRg
        '
        Me.txtRg.Location = New System.Drawing.Point(14, 102)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(237, 20)
        Me.txtRg.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(14, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(435, 20)
        Me.txtName.TabIndex = 13
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(14, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(89, 20)
        Me.txtCode.TabIndex = 14
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(329, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Status:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(254, 86)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(30, 13)
        Me.label5.TabIndex = 7
        Me.label5.Text = "CPF:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(11, 86)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(26, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "RG:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 47)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(38, 13)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Nome:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Código:"
        '
        'FrmCreateUpdateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtRg)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCreateUpdateCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCreateUpdateCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSave As Button
    Private WithEvents btnClean As Button
    Private WithEvents btnClose As Button
    Private WithEvents cboStatus As ComboBox
    Private WithEvents txtCpf As TextBox
    Private WithEvents txtRg As TextBox
    Private WithEvents txtName As TextBox
    Private WithEvents txtCode As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
End Class
