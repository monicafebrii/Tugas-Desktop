<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.txtNPM = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.Location = New System.Drawing.Point(16, 19)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(43, 20)
        Me.lblNIP.TabIndex = 0
        Me.lblNIP.Text = "NPM"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(16, 79)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(51, 20)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(16, 138)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(70, 20)
        Me.lblFakultas.TabIndex = 2
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(16, 195)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(66, 20)
        Me.lblJurusan.TabIndex = 3
        Me.lblJurusan.Text = "Jurusan"
        '
        'txtNPM
        '
        Me.txtNPM.Location = New System.Drawing.Point(111, 16)
        Me.txtNPM.Name = "txtNPM"
        Me.txtNPM.Size = New System.Drawing.Size(235, 26)
        Me.txtNPM.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(111, 73)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(235, 26)
        Me.txtNama.TabIndex = 5
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Location = New System.Drawing.Point(119, 130)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(227, 28)
        Me.cmbFakultas.TabIndex = 6
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(119, 187)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(227, 28)
        Me.cmbJurusan.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(20, 249)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 30)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Proses"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 312)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNPM)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblFakultas)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNIP As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblFakultas As System.Windows.Forms.Label
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents txtNPM As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button

End Class
