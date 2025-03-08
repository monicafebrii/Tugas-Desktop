<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblNPM = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNPM
        '
        Me.lblNPM.AutoSize = True
        Me.lblNPM.Location = New System.Drawing.Point(16, 24)
        Me.lblNPM.Name = "lblNPM"
        Me.lblNPM.Size = New System.Drawing.Size(13, 20)
        Me.lblNPM.TabIndex = 0
        Me.lblNPM.Text = ":"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(16, 77)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(13, 20)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = ":"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(16, 150)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(13, 20)
        Me.lblFakultas.TabIndex = 2
        Me.lblFakultas.Text = ":"
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(16, 200)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(13, 20)
        Me.lblJurusan.TabIndex = 3
        Me.lblJurusan.Text = ":"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(173, 259)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(82, 30)
        Me.btnKembali.TabIndex = 4
        Me.btnKembali.Text = "Submit"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Location = New System.Drawing.Point(16, 115)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(13, 20)
        Me.lblJenisKelamin.TabIndex = 5
        Me.lblJenisKelamin.Text = ":"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 372)
        Me.Controls.Add(Me.lblJenisKelamin)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblFakultas)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNPM)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNPM As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblFakultas As System.Windows.Forms.Label
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents lblJenisKelamin As System.Windows.Forms.Label
End Class
