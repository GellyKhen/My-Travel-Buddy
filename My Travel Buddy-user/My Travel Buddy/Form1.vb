Public Class _frmmainuser

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If _pbregion1.Visible = False Then
            _pbregion1.Visible = True
            _frmusermain.Visible = True
            _pbregion3.Visible = True
            _pbncr.Visible = True
            _pbcomingsoon.Visible = True
            _pblogo.Visible = False
            _pbphmap.Visible = True
            _lblncr.Visible = True
            _lblregion1.Visible = True
            _lblregion2.Visible = True
            _lblregion3.Visible = True
            _lblabout.Visible = True
            Button1.Visible = False
        Else
            _pblogo.Visible = True
            _pbregion1.Visible = False
            _frmusermain.Visible = False
            _pbregion3.Visible = False
            _pbncr.Visible = False
            _pbcomingsoon.Visible = False
            _pbphmap.Visible = False
            _lblncr.Visible = False
            _lblregion1.Visible = False
            _lblregion2.Visible = False
            _lblregion3.Visible = False
            _lblabout.Visible = False
        End If


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub _pblogo_Click(sender As Object, e As EventArgs) Handles _pblogo.Click, _pbphmap.Click

    End Sub

    Private Sub _pbregion1_Click(sender As Object, e As EventArgs) Handles _pbregion1.Click
        _frmregion1.Show()
    End Sub

    Private Sub _frmusermain_Click_1(sender As Object, e As EventArgs) Handles _frmusermain.Click
        _frmregion2.Show()
    End Sub

    Private Sub _pbregion3_Click(sender As Object, e As EventArgs) Handles _pbregion3.Click
        _frmregion3.Show()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click

    End Sub

    Private Sub _pbcomingsoon_Click(sender As Object, e As EventArgs) Handles _pbcomingsoon.Click

    End Sub

    Private Sub _lblregion1_Click(sender As Object, e As EventArgs) Handles _lblregion1.Click
        _frmregion1.Show()
    End Sub

    Private Sub _lblregion2_Click(sender As Object, e As EventArgs) Handles _lblregion2.Click
        _frmregion2.Show()
    End Sub

    Private Sub _lblregion3_Click(sender As Object, e As EventArgs) Handles _lblregion3.Click
        _frmregion3.Show()
    End Sub

    Private Sub _pbncr_Click(sender As Object, e As EventArgs) Handles _pbncr.Click
        _frmncr.Show()
    End Sub

    Private Sub _lblncr_Click(sender As Object, e As EventArgs) Handles _lblncr.Click
        _frmncr.Show()
    End Sub
End Class
