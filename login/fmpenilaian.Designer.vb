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
        Me.txtkriteria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.cbkriteria = New System.Windows.Forms.ComboBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.dg3 = New System.Windows.Forms.DataGridView()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.dg3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TANGGAL MULAI KERJA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JABATAN"
        '
        'cbnama
        '
        Me.cbnama.FormattingEnabled = True
        Me.cbnama.Location = New System.Drawing.Point(336, 114)
        Me.cbnama.Name = "cbnama"
        Me.cbnama.Size = New System.Drawing.Size(121, 21)
        Me.cbnama.TabIndex = 5
        '
        'txtkerja
        '
        Me.txtkerja.Location = New System.Drawing.Point(336, 150)
        Me.txtkerja.Name = "txtkerja"
        Me.txtkerja.Size = New System.Drawing.Size(121, 20)
        Me.txtkerja.TabIndex = 6
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(336, 185)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(121, 20)
        Me.txtjabatan.TabIndex = 7
        '
        'txtkriteria
        '
        Me.txtkriteria.Location = New System.Drawing.Point(464, 220)
        Me.txtkriteria.Name = "txtkriteria"
        Me.txtkriteria.Size = New System.Drawing.Size(75, 20)
        Me.txtkriteria.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "KRITERIA"
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
        Me.pnlLeftSide.Size = New System.Drawing.Size(158, 527)
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
        Me.btnkontak.Size = New System.Drawing.Size(156, 31)
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
        Me.pnlTopSide.Size = New System.Drawing.Size(521, 53)
        Me.pnlTopSide.TabIndex = 11
        '
        'btnminimize
        '
        Me.btnminimize.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_723__minus__minimize__website_3838428
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Location = New System.Drawing.Point(483, 0)
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
        Me.btnclose.Location = New System.Drawing.Point(503, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(14, 22)
        Me.btnclose.TabIndex = 16
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(278, 268)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(359, 268)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 13
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(440, 268)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(521, 268)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 15
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'cbkriteria
        '
        Me.cbkriteria.FormattingEnabled = True
        Me.cbkriteria.Location = New System.Drawing.Point(336, 220)
        Me.cbkriteria.Name = "cbkriteria"
        Me.cbkriteria.Size = New System.Drawing.Size(121, 21)
        Me.cbkriteria.TabIndex = 9
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(197, 268)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 16
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'dg3
        '
        Me.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg3.Location = New System.Drawing.Point(182, 317)
        Me.dg3.Name = "dg3"
        Me.dg3.Size = New System.Drawing.Size(473, 198)
        Me.dg3.TabIndex = 17
        '
        'fmpenilaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 527)
        Me.Controls.Add(Me.dg3)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtkriteria)
        Me.Controls.Add(Me.cbkriteria)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbnama As System.Windows.Forms.ComboBox
    Friend WithEvents txtkerja As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkriteria As System.Windows.Forms.TextBox
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
    Friend WithEvents cbkriteria As System.Windows.Forms.ComboBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents dg3 As System.Windows.Forms.DataGridView
End Class
