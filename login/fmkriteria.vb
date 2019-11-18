Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmkriteria
    Dim bSource As New BindingSource
    Dim mysq As String
    Dim mysqlco As String
    Dim du As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim connection As New MySqlConnection("server=localhost;user id=root;database=spk")
    Function execommand(ByVal cmd As MySqlCommand) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Function
    Sub kosong()
        txtkode.Text = ""
        txtkriteria.Text = ""
        txtbobot.Text = ""
        txtatribut.Text = ""
    End Sub
    Private Sub loaddata()
        dg2.DataSource = Nothing
        dg2.Refresh()
        str = "select * from kriteria"
        cmd = New MySqlCommand(str, mysql)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        dg2.DataSource = dt
    End Sub
    Private Sub Autonumber()
        Dim strtemp As String = ""
        Dim strvalue As String = ""
        buka_koneksi()
        mycmd = New MySqlCommand("select * from kriteria order by kd_kriteria desc", mysqlcon)
        read = mycmd.ExecuteReader
        If read.Read Then
            strtemp = Mid(read.Item("kd_kriteria"), 1, 4)
        Else
            txtkode.Text = "0001"
            txtkode.Focus()
            Exit Sub
        End If
        strvalue = Val(strtemp) + 1
        txtkode.Text = "" + Mid("0000", 1, 4 - strvalue.Length) & strvalue
        txtkode.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Hide()
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        fmhitung.Show()
        Hide()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        If txtkode.Text = "" Then
            MessageBox.Show("Isi Data")
            txtkode.Focus()
        Else
            str = ("INSERT INTO `kriteria` (`kd_kriteria`,`nm_kriteria`,`bobot`,`atribut`) values ('" & txtkode.Text & "','" & txtkriteria.Text & "','" & txtbobot.Text & "','" & txtatribut.Text & "')")
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                mysql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA TERSIMPAN")
                mysql.Close()
                txtkode.Text = ""
                txtkriteria.Text = ""
                txtbobot.Text = ""
                txtatribut.Text = ""
                Autonumber()
                loaddata()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        Autonumber()
    End Sub

    Private Sub fmkriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlco = "server=localhost;user id=root;database=spk"
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM kriteria order by kd_kriteria asc", mysqlco)
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        da.Fill(dt)
        dg2.DataSource = dt
        dg2.Columns(0).HeaderText = "KODE KRITERIA"
        dg2.Columns(1).HeaderText = "NAMA KRITERIA"
        dg2.Columns(2).HeaderText = "BOBOT"
        dg2.Columns(3).HeaderText = "ATRIBUT"
    End Sub

    Private Sub dg2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dg2.Rows(e.RowIndex)
            txtkode.Text = row.Cells("kd_kriteria").Value.ToString
            txtkriteria.Text = row.Cells("nm_kriteria").Value.ToString
            txtbobot.Text = row.Cells("bobot").Value.ToString
            txtatribut.Text = row.Cells("atribut").Value.ToString
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim update_command As New MySqlCommand("UPDATE `kriteria` SET `nm_kriteria`='" & txtkriteria.Text & "',`bobot`='" & txtbobot.Text & "',`atribut`='" & txtatribut.Text & "' WHERE `kd_kriteria` = '" & txtkode.Text & "'", connection)

        If execommand(update_command) Then
            MessageBox.Show("Data Updated")
            loaddata()
        Else
            MessageBox.Show("Data NOT Updated")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dg2.SelectedRows.Count > 0 Then
            For i As Integer = dg2.SelectedRows.Count - 1 To 0 Step -1
                Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Caption", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    mysq = "server=localhost;user id=root;database=spk"
                    mysqlco = "DELETE FROM kriteria WHERE kd_kriteria='" & txtkode.Text & "'"
                    mysql = New MySqlConnection(mysq)
                    cmd = New MySqlCommand(mysqlco, mysql)
                    Try
                        mysql.Open()
                        cmd.ExecuteNonQuery()
                        dg2.Rows.RemoveAt(dg2.SelectedRows(i).Index)
                        MessageBox.Show("Data Berhasil Di hapus")
                        loaddata()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Tidak ada data yang dihapus")
                End If

            Next
        Else
            MessageBox.Show("No rows to select")
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        kosong()
    End Sub
End Class