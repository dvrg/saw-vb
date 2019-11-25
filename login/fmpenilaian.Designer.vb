<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmpenilaian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbnama = New System.Windows.Forms.ComboBox()
        Me.txtkerja = New System.Windows.Forms.TextBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnkontak = New System.Windows.Forms.Button()
        Me.btnhasil = New System.Windows.Forms.Button()
        Me.btnnilai = New System.Windows.Forms.Button()
        Me.btndata = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.dg3 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRekomdasi = New System.Windows.Forms.ComboBox()
        Me.cbTest = New System.Windows.Forms.ComboBox()
        Me.cbNki = New System.Windows.Forms.ComboBox()
        Me.cbAparsial = New System.Windows.Forms.ComboBox()
        Me.cbTeamLeader = New System.Windows.Forms.ComboBox()
        Me.cbMasaJabatan = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.dg3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TANGGAL MULAI KERJA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JABATAN"
        '
        'cbnama
        '
        Me.cbnama.FormattingEnabled = True
        Me.cbnama.Location = New System.Drawing.Point(323, 86)
        Me.cbnama.Name = "cbnama"
        Me.cbnama.Size = New System.Drawing.Size(121, 21)
        Me.cbnama.TabIndex = 5
        '
        'txtkerja
        '
        Me.txtkerja.Location = New System.Drawing.Point(323, 113)
        Me.txtkerja.Name = "txtkerja"
        Me.txtkerja.Size = New System.Drawing.Size(121, 20)
        Me.txtkerja.TabIndex = 6
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(323, 139)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(121, 20)
        Me.txtjabatan.TabIndex = 7
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.White
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.PictureBox1)
        Me.pnlLeftSide.Controls.Add(Me.btnkontak)
        Me.pnlLeftSide.Controls.Add(Me.btnhasil)
        Me.pnlLeftSide.Controls.Add(Me.btnnilai)
        Me.pnlLeftSide.Controls.Add(Me.btndata)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(158, 386)
        Me.pnlLeftSide.TabIndex = 10
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.Red
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 170)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(10, 31)
        Me.pnlOnButtonPosition.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.spk.My.Resources.Resources.telkom_akses_logo_7ECCB5449C_seeklogo_com
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 53)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnkontak
        '
        Me.btnkontak.FlatAppearance.BorderSize = 0
        Me.btnkontak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkontak.Image = Global.spk.My.Resources.Resources.contact__1_
        Me.btnkontak.Location = New System.Drawing.Point(2, 297)
        Me.btnkontak.Name = "btnkontak"
        Me.btnkontak.Size = New System.Drawing.Size(153, 31)
        Me.btnkontak.TabIndex = 2
        Me.btnkontak.Text = "     Contact Us"
        Me.btnkontak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkontak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnkontak.UseVisualStyleBackColor = True
        '
        'btnhasil
        '
        Me.btnhasil.FlatAppearance.BorderSize = 0
        Me.btnhasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhasil.Image = Global.spk.My.Resources.Resources.research
        Me.btnhasil.Location = New System.Drawing.Point(0, 233)
        Me.btnhasil.Name = "btnhasil"
        Me.btnhasil.Size = New System.Drawing.Size(156, 31)
        Me.btnhasil.TabIndex = 2
        Me.btnhasil.Text = "     Hasil Penilaian"
        Me.btnhasil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhasil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhasil.UseVisualStyleBackColor = True
        '
        'btnnilai
        '
        Me.btnnilai.FlatAppearance.BorderSize = 0
        Me.btnnilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnilai.Image = Global.spk.My.Resources.Resources.calculator
        Me.btnnilai.Location = New System.Drawing.Point(0, 170)
        Me.btnnilai.Name = "btnnilai"
        Me.btnnilai.Size = New System.Drawing.Size(156, 31)
        Me.btnnilai.TabIndex = 2
        Me.btnnilai.Text = "     Penilaian"
        Me.btnnilai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnilai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnilai.UseVisualStyleBackColor = True
        '
        'btndata
        '
        Me.btndata.FlatAppearance.BorderSize = 0
        Me.btndata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndata.Image = Global.spk.My.Resources.Resources.recruitment__2_
        Me.btndata.Location = New System.Drawing.Point(0, 113)
        Me.btndata.Name = "btndata"
        Me.btndata.Size = New System.Drawing.Size(156, 31)
        Me.btndata.TabIndex = 2
        Me.btndata.Text = "     Data Master"
        Me.btndata.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndata.UseVisualStyleBackColor = True
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.Red
        Me.pnlTopSide.Controls.Add(Me.btnminimize)
        Me.pnlTopSide.Controls.Add(Me.btnclose)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(158, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(847, 53)
        Me.pnlTopSide.TabIndex = 11
        '
        'btnminimize
        '
        Me.btnminimize.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_723__minus__minimize__website_3838428
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Location = New System.Drawing.Point(801, 3)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(14, 22)
        Me.btnminimize.TabIndex = 17
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_cancel_1303884
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(821, 3)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(14, 22)
        Me.btnclose.TabIndex = 16
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(590, 317)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(671, 317)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 13
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(752, 317)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(833, 317)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 15
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(509, 317)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 16
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'dg3
        '
        Me.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg3.Location = New System.Drawing.Point(510, 113)
        Me.dg3.Name = "dg3"
        Me.dg3.Size = New System.Drawing.Size(473, 198)
        Me.dg3.TabIndex = 17
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(784, 87)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 20)
        Me.txtSearch.TabIndex = 18
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(722, 90)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(56, 13)
        Me.lblSearch.TabIndex = 19
        Me.lblSearch.Text = "Cari Nama"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbRekomdasi)
        Me.GroupBox1.Controls.Add(Me.cbTest)
        Me.GroupBox1.Controls.Add(Me.cbNki)
        Me.GroupBox1.Controls.Add(Me.cbAparsial)
        Me.GroupBox1.Controls.Add(Me.cbTeamLeader)
        Me.GroupBox1.Controls.Add(Me.cbMasaJabatan)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 190)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kriteria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "REKOMENDASI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "NKI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "TEST"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "APRAISAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "TEAM LEADER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "MASA JABATAN"
        '
        'cbRekomdasi
        '
        Me.cbRekomdasi.FormattingEnabled = True
        Me.cbRekomdasi.Items.AddRange(New Object() {"1", "2"})
        Me.cbRekomdasi.Location = New System.Drawing.Point(141, 151)
        Me.cbRekomdasi.Name = "cbRekomdasi"
        Me.cbRekomdasi.Size = New System.Drawing.Size(121, 21)
        Me.cbRekomdasi.TabIndex = 5
        Me.cbRekomdasi.Text = "1"
        '
        'cbTest
        '
        Me.cbTest.FormattingEnabled = True
        Me.cbTest.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbTest.Location = New System.Drawing.Point(141, 124)
        Me.cbTest.Name = "cbTest"
        Me.cbTest.Size = New System.Drawing.Size(121, 21)
        Me.cbTest.TabIndex = 4
        Me.cbTest.Text = "1"
        '
        'cbNki
        '
        Me.cbNki.FormattingEnabled = True
        Me.cbNki.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbNki.Location = New System.Drawing.Point(141, 97)
        Me.cbNki.Name = "cbNki"
        Me.cbNki.Size = New System.Drawing.Size(121, 21)
        Me.cbNki.TabIndex = 3
        Me.cbNki.Text = "1"
        '
        'cbAparsial
        '
        Me.cbAparsial.FormattingEnabled = True
        Me.cbAparsial.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbAparsial.Location = New System.Drawing.Point(141, 70)
        Me.cbAparsial.Name = "cbAparsial"
        Me.cbAparsial.Size = New System.Drawing.Size(121, 21)
        Me.cbAparsial.TabIndex = 2
        Me.cbAparsial.Text = "1"
        '
        'cbTeamLeader
        '
        Me.cbTeamLeader.FormattingEnabled = True
        Me.cbTeamLeader.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbTeamLeader.Location = New System.Drawing.Point(141, 43)
        Me.cbTeamLeader.Name = "cbTeamLeader"
        Me.cbTeamLeader.Size = New System.Drawing.Size(121, 21)
        Me.cbTeamLeader.TabIndex = 1
        Me.cbTeamLeader.Text = "1"
        '
        'cbMasaJabatan
        '
        Me.cbMasaJabatan.FormattingEnabled = True
        Me.cbMasaJabatan.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbMasaJabatan.Location = New System.Drawing.Point(141, 16)
        Me.cbMasaJabatan.Name = "cbMasaJabatan"
        Me.cbMasaJabatan.Size = New System.Drawing.Size(121, 21)
        Me.cbMasaJabatan.TabIndex = 0
        Me.cbMasaJabatan.Text = "1"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(955, 84)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(28, 23)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Find"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'fmpenilaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 386)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dg3)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtkerja)
        Me.Controls.Add(Me.cbnama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmpenilaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "penilaian"
        Me.pnlLeftSide.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        CType(Me.dg3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbnama As System.Windows.Forms.ComboBox
    Friend WithEvents txtkerja As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents pnlLeftSide As System.Windows.Forms.Panel
    Friend WithEvents pnlOnButtonPosition As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnkontak As System.Windows.Forms.Button
    Friend WithEvents btnhasil As System.Windows.Forms.Button
    Friend WithEvents btnnilai As System.Windows.Forms.Button
    Friend WithEvents btndata As System.Windows.Forms.Button
    Friend WithEvents pnlTopSide As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents dg3 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbRekomdasi As System.Windows.Forms.ComboBox
    Friend WithEvents cbTest As System.Windows.Forms.ComboBox
    Friend WithEvents cbNki As System.Windows.Forms.ComboBox
    Friend WithEvents cbAparsial As System.Windows.Forms.ComboBox
    Friend WithEvents cbTeamLeader As System.Windows.Forms.ComboBox
    Friend WithEvents cbMasaJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
