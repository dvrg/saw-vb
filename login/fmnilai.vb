Public Class fmnilai

    Private Sub btnnilaii_Click(sender As Object, e As EventArgs) Handles btnnilaii.Click
        fmpenilaian.Show()
        Hide()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        fmhitung.Show()
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click
        fmkontak.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fmhasil.Show()
        Hide()
    End Sub
End Class