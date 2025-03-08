Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan item ke dalam ComboBox Fakultas
        cbFakultas.Items.Add("FMIPA")
        cbFakultas.Items.Add("FKIP")
        cbFakultas.Items.Add("FEB")

        ' Menambahkan item ke dalam ComboBox Jurusan
        cbJurusan.Items.Add("Matematika")
        cbJurusan.Items.Add("Kimia")
        cbJurusan.Items.Add("Biologi")
        cbJurusan.Items.Add("Fisika")
        cbJurusan.Items.Add("Ilmu Komputer")
    End Sub

    Private Sub txtNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIP.KeyPress
        ' Hanya memperbolehkan input angka di NIP
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        ' Tampilan MassageBox Seperti Gambar
        Dim message As String = "Hai : " & txtNIP.Text & vbCrLf &
                                "Nip : " & txtNama.Text & vbCrLf &
                                "Fakultas : " & cbFakultas.SelectedItem.ToString() & vbCrLf &
                                "Jurusan : " & cbJurusan.SelectedItem.ToString()
        MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class