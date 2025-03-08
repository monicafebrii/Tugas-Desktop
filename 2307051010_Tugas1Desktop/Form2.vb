Public Class Form2

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim nip As Long
        If Not Long.TryParse(txtNIP.Text.Trim(), nip) Then
            MessageBox.Show("NIP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim nama As String = txtNama.Text.Trim()
        Dim fakultas As String = cbFakultas.Text.Trim()
        Dim jurusan As String = cbJurusan.Text.Trim()

        Dim jenisKelamin As String = ""
        If rbL.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rbP.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class