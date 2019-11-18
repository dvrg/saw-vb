Public Class fmmenu

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        pnlOnButtonPosition.Height = btndata.Height
        pnlOnButtonPosition.Top = btndata.Top
        pnldata.Visible = True
        pnlnilai.Visible = False
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Hide()
    End Sub
    Private Sub btnkaryawan_Click(sender As Object, e As EventArgs) Handles btnkaryawan.Click
        fmkaryawan.Show()
        Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnkriteria_Click(sender As Object, e As EventArgs) Handles btnkriteria.Click
        fmkriteria.Show()
        Hide()
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        fmhasil.Show()
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click
        fmkontak.Show()
        Hide()
    End Sub
End Class