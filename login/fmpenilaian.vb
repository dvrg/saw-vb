Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmpenilaian
    Dim bSource As New BindingSource
    Dim mysqlco As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim m As New MySqlConnection
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
        mysqlco = "server=localhost;user id=root;database=spk"
        If cbnama.Text = "" Then
            MessageBox.Show("Isi Data")
            cbnama.Focus()
        Else
            str = ("INSERT INTO 'penilaian' ('nama','tgl_mulai_kerja','jabatan','nm_kriteria','input_nilai') values ('" & cbnama.Text & "')")
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, MySql)
            read.Read()
            If read.HasRows Then
                txtkerja.Text = read.Item(2)
                txtjabatan.Text = read.Item(3)
                txtkriteria.Focus()
            End If
            Try
                MySql.Open()
                read = cmd.ExecuteReader()
                MessageBox.Show("DATA TERSIMPAN")
                MySql.Close()
                cbnama.Text = ""
                txtkerja.Text = ""
                txtjabatan.Text = ""
                cbkriteria.Text = ""
                txtkriteria.Text = ""

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub fmpenilaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
        Call tampilkriteria()
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
    Sub tampilkriteria()
        Call buka_koneksi()
        Dim str As String
        str = "select nm_kriteria from kriteria"
        cmd = New MySqlCommand(str, mysqlcon)
        read = cmd.ExecuteReader
        cbkriteria.Items.Clear()
        Do While read.Read
            cbkriteria.Items.Add(read.Item(0))
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
            cbnama.Text = row.Cells("nama").Value.ToString
            txtkerja.Text = row.Cells("tgl_mulai_kerja").Value.ToString
            txtjabatan.Text = row.Cells("jabatan").Value.ToString
            cbkriteria.Text = row.Cells("").Value.ToString
            txtkriteria.Text = row.Cells("").Value.ToString
        End If
    End Sub
End Class