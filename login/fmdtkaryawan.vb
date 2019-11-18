Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmdtkaryawan
    Dim bSource As New BindingSource
    Dim mysqlco As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim m As New MySqlConnection
    Private Sub loaddata()
        dg1.DataSource = Nothing
        dg1.Refresh()
        str = "select * from karyawan"
        cmd = New MySqlCommand(str, mysql)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        dg1.DataSource = dt
    End Sub
    Public Sub FilterData(valueToSearch As String)
        m = New MySqlConnection("server=localhost;user id=root;database=spk")
        Dim searchQuery As String = "SELECT * FROM `karyawan` WHERE (`nik`) like '%" & txtcari.Text & "%'"
        Dim command As New MySqlCommand(searchQuery, m)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dg1.DataSource = table
    End Sub
    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Hide()
    End Sub

    Private Sub fmdtkaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlco = "server=localhost;user id=root;database=spk"
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM karyawan order by id asc", mysqlco)
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        da.Fill(dt)
        dg1.DataSource = dt
        dg1.Columns(0).HeaderText = "NO"
        dg1.Columns(1).HeaderText = "NIK"
        dg1.Columns(2).HeaderText = "NAMA"
        dg1.Columns(3).HeaderText = "TANGGAL LAHIR"
        dg1.Columns(4).HeaderText = "KOTA LAHIR"
        dg1.Columns(5).HeaderText = "AGAMA"
        dg1.Columns(6).HeaderText = "JENIS KELAMIN"
        dg1.Columns(7).HeaderText = "ALAMAT"
        dg1.Columns(8).HeaderText = "KOTA"
        dg1.Columns(9).HeaderText = "SUKU"
        dg1.Columns(10).HeaderText = "NO KTP"
        dg1.Columns(11).HeaderText = "TANGGAL BERLAKU KTP"
        dg1.Columns(12).HeaderText = "NO KK"
        dg1.Columns(13).HeaderText = "NO NPWP"
        dg1.Columns(14).HeaderText = "NO GSM"
        dg1.Columns(15).HeaderText = "EMAIL"
        dg1.Columns(16).HeaderText = "IBU KANDUNG"
        dg1.Columns(17).HeaderText = "GOLONGAN DARAH"
        dg1.Columns(18).HeaderText = "NO KARTU BPJS"
        dg1.Columns(19).HeaderText = "TANGGAL KARTU BPJS"
        dg1.Columns(20).HeaderText = "NO JAMSOSTEK"
        dg1.Columns(21).HeaderText = "TANGGAL JAMSOSTEK"
        dg1.Columns(22).HeaderText = "KODE FASKES"
        dg1.Columns(23).HeaderText = "KODE FASKES GIGI"
        dg1.Columns(24).HeaderText = "STATUS PERNIKAHAN"
        dg1.Columns(25).HeaderText = "TANGGAL PERNIKAHAN"
        dg1.Columns(26).HeaderText = "JUMLAH ANAK"
        dg1.Columns(27).HeaderText = "SUSUNAN KELUARGA"
        dg1.Columns(28).HeaderText = "STATUS TENAGA KERJA"
        dg1.Columns(29).HeaderText = "OBJECT ID"
        dg1.Columns(30).HeaderText = "POSITION NAME"
        dg1.Columns(31).HeaderText = "POSITION TITLE"
        dg1.Columns(32).HeaderText = "DIREKTORAT"
        dg1.Columns(33).HeaderText = "UNIT"
        dg1.Columns(34).HeaderText = "SUB UNIT"
        dg1.Columns(35).HeaderText = "SEKTOR"
        dg1.Columns(36).HeaderText = "RAYON"
        dg1.Columns(37).HeaderText = "ID PSA"
        dg1.Columns(38).HeaderText = "NAMA PSA"
        dg1.Columns(39).HeaderText = "WITEL"
        dg1.Columns(40).HeaderText = "TERITORY"
        dg1.Columns(41).HeaderText = "REGIONAL"
        dg1.Columns(42).HeaderText = "STATUS KERJA"
        dg1.Columns(43).HeaderText = "LAMA OJT"
        dg1.Columns(44).HeaderText = "STATUS INDUKSI"
        dg1.Columns(45).HeaderText = "TANGGAL MULAI KERJA"
        dg1.Columns(46).HeaderText = "TANGGAL KONTRAK PERTAMA"
        dg1.Columns(47).HeaderText = "TANGGAL AWAL KONTRAK"
        dg1.Columns(48).HeaderText = "TANGGAL AKHIR KONTRAK"
        dg1.Columns(49).HeaderText = "TAHUN KONTRAK"
        dg1.Columns(50).HeaderText = "BAND POSISI"
        dg1.Columns(51).HeaderText = "TANGGAL BAND POSISI"
        dg1.Columns(52).HeaderText = "LEVEL"
        dg1.Columns(53).HeaderText = "TANGGAL LEVEL"
        dg1.Columns(54).HeaderText = "STATUS PJ"
        dg1.Columns(55).HeaderText = "TANGGAL STATUS PJ"
        dg1.Columns(56).HeaderText = "TANGGAL FAS PERUMAHAN"
        dg1.Columns(57).HeaderText = "TANGGAL SELESAI FAS PERUMAHAN"
        dg1.Columns(58).HeaderText = "TANGGAL AWAL NOP"
        dg1.Columns(59).HeaderText = "TANGGAL KAHIR NOP"
        dg1.Columns(60).HeaderText = "TANGGAL AWAL COP"
        dg1.Columns(61).HeaderText = "TANGGAL AKHIR COP"
        dg1.Columns(62).HeaderText = "LEVEL PENDIDIKAN"
        dg1.Columns(63).HeaderText = "TANGGAL LEVEL PENDIDIKAN"
        dg1.Columns(64).HeaderText = "JURUSAN"
        dg1.Columns(65).HeaderText = "PENYELENGGARA PENDIDIKAN"
        dg1.Columns(66).HeaderText = "NO REKENING"
        dg1.Columns(67).HeaderText = "BANK"
        dg1.Columns(68).HeaderText = "KANTOR CABANG BANK"
        dg1.Columns(69).HeaderText = "ALAMAT BANK"
        dg1.Columns(70).HeaderText = "NAMA REKENING"
        dg1.Columns(71).HeaderText = "PIC HR"
        dg1.Columns(72).HeaderText = "TIME ZONE"
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        FilterData(txtcari.Text)
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        fmhitung.Show()
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click
        fmkontak.Show()
        Hide()
    End Sub
End Class