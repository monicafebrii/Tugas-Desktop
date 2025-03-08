Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menghapus item sebelumnya agar tidak duplikasi
        cmbFakultas.Items.Clear()
        cmbJurusan.Items.Clear()

        ' Menambahkan pilihan fakultas ke ComboBox
        cmbFakultas.Items.Add("Fakultas Ekonomi dan Bisnis")
        cmbFakultas.Items.Add("Fakultas Teknik")
        cmbFakultas.Items.Add("Fakultas Kedokteran")
        cmbFakultas.Items.Add("Fakultas Matematika dan Ilmu Pengetahuan Alam")

        ' Menambahkan pilihan jurusan ke ComboBox
        cmbJurusan.Items.Add("Informatika")
        cmbJurusan.Items.Add("Ilmu Komputer")
        cmbJurusan.Items.Add("Akuntansi")
        cmbJurusan.Items.Add("Manajemen")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Pastikan semua input diisi
        If txtNPM.Text = "" Or txtNama.Text = "" Or cmbFakultas.Text = "" Or cmbJurusan.Text = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Pastikan salah satu radio button jenis kelamin dipilih
        Dim jenisKelamin As String = ""
        If rbLaki.Checked Then
            jenisKelamin = "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Harap pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Mengirim data ke Form2 dengan parameter
        Dim hasilForm As New Form2(txtNPM.Text, txtNama.Text, jenisKelamin, cmbFakultas.Text, cmbJurusan.Text)
        hasilForm.Show()
        Me.Hide()
    End Sub

    ' Jika tidak ada logika di sini, Anda bisa menghapus event handler ini
    Private Sub rbLaki_CheckedChanged(sender As Object, e As EventArgs) Handles rbLaki.CheckedChanged
        ' Logika tambahan jika diperlukan
    End Sub

    Private Sub rbLakiLaki_CheckedChanged(sender As Object, e As EventArgs) Handles rbLakiLaki.CheckedChanged

    End Sub
End Class