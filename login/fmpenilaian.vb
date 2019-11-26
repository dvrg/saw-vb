Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmpenilaian
    Dim bSource As New BindingSource
    Dim mysqlco As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim m As New MySqlConnection
    Dim key As Integer
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        fmhasil.Show()
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click
        fmkontak.Show()
        Hide()
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Hide()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Call buka_koneksi()
        If txtjabatan.Text = "" Or txtkerja.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            str = ("INSERT INTO `penilaian` (`nama`, `tgl_mulai_kerja`, `jabatan`, `ms_jab`, `team_leader`, `apraisal`, `nki`, `test`, `rekom`) VALUES ('" + cbnama.Text + "','" + txtkerja.Text + "', '" + txtjabatan.Text + "','" + Mid(cbMasaJabatan.Text, 1, 1) + "', '" + Mid(cbTeamLeader.Text, 1, 1) + "', '" + Mid(cbAparsial.Text, 1, 1) + "', '" + Mid(cbNki.Text, 1, 1) + "', '" + Mid(cbTest.Text, 1, 1) + "','" + Mid(cbRekomdasi.Text, 1, 1) + "')")
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                mysql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA TERSIMPAN")
                mysql.Close()
                Call loaddata()
                Call clearform()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub clearform()
        cbnama.ResetText()
        txtkerja.Clear()
        txtjabatan.Clear()
        cbMasaJabatan.Text = "-- pilih --"
        cbTeamLeader.Text = "-- pilih --"
        cbAparsial.Text = "-- pilih --"
        cbRekomdasi.Text = "-- pilih --"
        cbNki.Text = "-- pilih --"
        cbTest.Text = "-- pilih --"
    End Sub


    Private Sub fmpenilaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
        Call loaddata()
    End Sub

    Sub loaddata()
        mysqlco = "server=localhost;user id=root;database=spk"
        da = New MySqlDataAdapter("SELECT * FROM `penilaian`", mysqlco)
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        da.Fill(dt)
        dg3.DataSource = dt
    End Sub

    Sub tampilDataComboBox()
        Call buka_koneksi()
        Dim str As String
        str = "select nama from karyawan"
        cmd = New MySqlCommand(str, mysqlcon)
        read = cmd.ExecuteReader
        cbnama.Items.Clear()
        Do While read.Read
            cbnama.Items.Add(read.Item(0))
        Loop
        cmd.Dispose()
        read.Close()
        mysql.Close()
    End Sub
    Private Sub cbnama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnama.SelectedIndexChanged
        Call buka_koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT nama,tgl_kerja,posisi FROM karyawan WHERE nama = '" & cbnama.Text & "'", mysqlcon)
        read = cmd.ExecuteReader
        read.Read()
        If read.HasRows Then
            txtkerja.Text = read.Item(1)
            txtjabatan.Text = read.Item(2)
            txtkerja.Focus()
        End If
        read.Close()
        mysql.Close()
    End Sub

    Private Sub dg3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg3.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dg3.Rows(e.RowIndex)
            key = row.Cells("idnilai").Value
            cbnama.Text = row.Cells("nama").Value.ToString
            txtkerja.Text = row.Cells("tgl_mulai_kerja").Value.ToString
            txtjabatan.Text = row.Cells("jabatan").Value.ToString
            cbMasaJabatan.Text = row.Cells("ms_jab").Value.ToString
            cbTeamLeader.Text = row.Cells("team_leader").Value.ToString
            cbAparsial.Text = row.Cells("apraisal").Value.ToString
            cbRekomdasi.Text = row.Cells("rekom").Value.ToString
            cbNki.Text = row.Cells("nki").Value.ToString
            cbTest.Text = row.Cells("test").Value.ToString
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        If txtjabatan.Text = "" Or txtkerja.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            str = "UPDATE `penilaian` SET `nama` = '" + cbnama.Text + "', `tgl_mulai_kerja` = '" + txtkerja.Text + "', `jabatan` =  '" + txtjabatan.Text + "', `ms_jab` ='" + Mid(cbMasaJabatan.Text.ToString(), 1, 1) + "',`team_leader` ='" + Mid(cbTeamLeader.Text.ToString(), 1, 1) + "', `apraisal` = '" + Mid(cbAparsial.Text.ToString(), 1, 1) + "', `nki` = '" + Mid(cbNki.Text.ToString(), 1, 1) + "', `test` = '" + Mid(cbTest.Text.ToString(), 1, 1) + "', `rekom` = '" + Mid(cbRekomdasi.Text.ToString(), 1, 1) + "' WHERE `penilaian`.`idnilai`=" + key.ToString() + ""
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                mysql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA DIPERBAHARUI")
                mysql.Close()
                Call loaddata()
                Call clearform()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        da = New MySqlDataAdapter("SELECT * FROM `penilaian` WHERE nama LIKE '%" + txtSearch.Text + "%'", mysqlco)
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        da.Fill(dt)
        dg3.DataSource = dt
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand("DELETE FROM `penilaian` WHERE `penilaian`.`idnilai` = " + key.ToString + "", mysql)
        Try
            mysql.Open()
            read = cmd.ExecuteReader()
            read.Read()
            MessageBox.Show("DATA TERHAPUS")
            mysql.Close()
            Call clearform()
            Call loaddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Call loaddata()
        Call clearform()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim str As String
        str = "Hallo aku"
        MessageBox.Show(Mid(str, 1, 1))
    End Sub
End Class