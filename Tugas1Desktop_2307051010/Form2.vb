Public Class Form2
    ' Constructor untuk menerima data dari Form1
    Public Sub New(npm As String, nama As String, jenisKelamin As String, fakultas As String, jurusan As String)
        ' Inisialisasi komponen
        InitializeComponent()

        ' Menampilkan data ke Label
        lblNPM.Text = "NPM: " & npm
        lblNama.Text = "Nama: " & nama
        lblFakultas.Text = "Fakultas: " & fakultas
        lblJurusan.Text = "Jurusan: " & jurusan

        ' Menentukan jenis kelamin berdasarkan parameter
        If jenisKelamin = "Laki-laki" Then
            rbLakilaki.Checked = True
        ElseIf jenisKelamin = "Perempuan" Then
            rbPerempuan.Checked = True
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        ' Kembali ke Form1
        Dim inputForm As New Form1()
        inputForm.Show()
        Me.Close()
    End Sub

    Private Function rbLaki() As Object
        Throw New NotImplementedException
    End Function

    Private Function rbPerempuan() As Object
        Throw New NotImplementedException
    End Function

End Class