Public Class _frmregion1

    Private Sub _pbpangasinan_Click(sender As Object, e As EventArgs) Handles _pbpangasinan.Click
        MsgBox("Pangasinan")
    End Sub

    Private Sub _pblaunion_Click(sender As Object, e As EventArgs) Handles _pblaunion.Click
        MsgBox("La Union")
    End Sub

    Private Sub _pbilocossur_Click(sender As Object, e As EventArgs) Handles _pbilocossur.Click
        MsgBox("Ilocos Sur")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Ilocos Norte")
    End Sub

    Private Sub _btback_Click(sender As Object, e As EventArgs) Handles _btback.Click
        Me.Close()
    End Sub
End Class