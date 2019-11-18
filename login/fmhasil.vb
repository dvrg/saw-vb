Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc
Public Class fmhasil
    Dim bSource As New BindingSource
    Dim mysqlco As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim m As New MySqlConnection
    Dim mmas_jab, mjab_tl, mnilai_apraisal, mnilai_nki, mnilai_ujian, mrekom_atsn As Single
    Dim mas_jab, jab_tl, nilai_apraisal, nilai_nki, nilai_ujian, rekom_atsn As Single
    Dim nmas_jab, njab_tl, nnilai_apraisal, nnilai_nki, nnilai_ujian, nrekom_atsn As Single
    Dim preferensi As Single
    Sub gridtampil()
        Call buka_koneksi()
        str = "SELECT * FROM nilai"
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        dt.Load(cmd.ExecuteReader)
        dgnilai.DataSource = dt
        'mengatur judul
        dgnilai.Columns(0).HeaderText = "NIK"
        dgnilai.Columns(1).HeaderText = "NAMA"
        dgnilai.Columns(2).HeaderText = "MASA JABATAN"
        dgnilai.Columns(3).HeaderText = "JABATAN"
        dgnilai.Columns(4).HeaderText = "NILAI APRAISAL"
        dgnilai.Columns(5).HeaderText = "NILAI NKI"
        dgnilai.Columns(6).HeaderText = "NILAI UJIAN"
        dgnilai.Columns(7).HeaderText = "REKOMENDASI ATASAN"
        dgnilai.Columns(8).HeaderText = "nMASA JABATAN"
        dgnilai.Columns(9).HeaderText = "nJABATAN"
        dgnilai.Columns(10).HeaderText = "nNILAI APRAISAL"
        dgnilai.Columns(11).HeaderText = "nNILAI NKI"
        dgnilai.Columns(12).HeaderText = "nNILAI UJIAN"
        dgnilai.Columns(13).HeaderText = "nREKOMENDASI ATASAN"
        dgnilai.Columns(14).HeaderText = "PREFERENSI"
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

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click
        fmkontak.Show()
        Hide()
    End Sub

    Private Sub fmhasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridtampil()
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click

        'validasi sudah dihitung atau belum
        comnilai = New MySqlCommand("SELECT * FROM nilai", mysqlcon)
        drnilai = comnilai.ExecuteReader
        If drnilai.HasRows Then
            MsgBox("Data Sudah Diproses", , "Info")
            Return
        End If

        'mencari nilai max dan min
        compenilaian = New MySqlCommand("Select max(ms_jab), max(jab_tl), max(nilai_apraisal), max(nilai_nki), max(nilai_ujian), min(rekom_atsn)", mysqlcon)
        If drpenilaian.HasRows Then
            mmas_jab = drpenilaian.Item(0)
            mjab_tl = drpenilaian.Item(1)
            mnilai_apraisal = drpenilaian.Item(2)
            mnilai_nki = drpenilaian.Item(3)
            mnilai_ujian = drpenilaian.Item(4)
            mrekom_atsn = drpenilaian.Item(5)
        End If

        'baca data
        compenilaian = New MySqlCommand("Select * From penilaian", mysqlcon)
        drpenilaian = compenilaian.ExecuteReader
        If drpenilaian.HasRows Then
            'mengambil data
            mas_jab = drpenilaian.Item(5)
            jab_tl = drpenilaian.Item(6)
            nilai_apraisal = drpenilaian.Item(7)
            nilai_nki = drpenilaian.Item(8)
            nilai_ujian = drpenilaian.Item(9)
            rekom_atsn = drpenilaian.Item(10)

            'menghitung normalisasi
            nmas_jab = mas_jab / mmas_jab
            njab_tl = jab_tl / mjab_tl
            nnilai_apraisal = nilai_apraisal / mnilai_apraisal
            nnilai_nki = nilai_nki / mnilai_nki
            nnilai_ujian = nilai_ujian / mnilai_ujian
            nrekom_atsn = mrekom_atsn / rekom_atsn

            'menghitung preferensi
            preferensi = (0.2 * nmas_jab) + (0.2 * njab_tl) + (0.15 * nnilai_apraisal) + (0.15 * nnilai_nki) + (0.15 * nnilai_ujian) + (0.15 * nrekom_atsn)

        Else
            MsgBox("Data Belum Dimasukkan", , "info")
            Return
        End If
    End Sub
End Class