<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmkriteria
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
        Me.txtkriteria = New System.Windows.Forms.TextBox()
        Me.txtbobot = New System.Windows.Forms.TextBox()
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
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtatribut = New System.Windows.Forms.TextBox()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA KRITERIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BOBOT"
        '
        'txtkriteria
        '
        Me.txtkriteria.Location = New System.Drawing.Point(315, 157)
        Me.txtkriteria.Name = "txtkriteria"
        Me.txtkriteria.Size = New System.Drawing.Size(138, 20)
        Me.txtkriteria.TabIndex = 2
        '
        'txtbobot
        '
        Me.txtbobot.Location = New System.Drawing.Point(315, 189)
        Me.txtbobot.Name = "txtbobot"
        Me.txtbobot.Size = New System.Drawing.Size(138, 20)
        Me.txtbobot.TabIndex = 3
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
        Me.pnlLeftSide.Size = New System.Drawing.Size(158, 431)
        Me.pnlLeftSide.TabIndex = 4
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.Red
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 113)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(10, 31)
        Me.pnlOnButtonPosition.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.spk.My.Resources.Resources.telkom_akses_logo_7ECCB5449C_seeklogo_com
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(2, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 53)
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
        Me.btnkontak.Size = New System.Drawing.Size(155, 31)
        Me.btnkontak.TabIndex = 2
        Me.btnkontak.Text = "     Contact Us"
        Me.btnkontak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkontak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnkontak.UseVisualStyleBackColor = True
        '
        'btnhasil
        '
        Me.btnhasil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
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
        Me.pnlTopSide.Size = New System.Drawing.Size(493, 53)
        Me.pnlTopSide.TabIndex = 5
        '
        'btnminimize
        '
        Me.btnminimize.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_723__minus__minimize__website_3838428
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Location = New System.Drawing.Point(460, 0)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(14, 22)
        Me.btnminimize.TabIndex = 200
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_cancel_1303884
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(478, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(14, 22)
        Me.btnclose.TabIndex = 199
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(544, 236)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 193
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(544, 206)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 192
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnbaru
        '
        Me.btnbaru.Location = New System.Drawing.Point(544, 120)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(75, 23)
        Me.btnbaru.TabIndex = 191
        Me.btnbaru.Text = "New"
        Me.btnbaru.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(544, 148)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 190
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "DATA KRITERIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "KODE KRITERIA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 196
        Me.Label5.Text = "ATRIBUT"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(314, 128)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(138, 20)
        Me.txtkode.TabIndex = 197
        '
        'txtatribut
        '
        Me.txtatribut.Location = New System.Drawing.Point(315, 218)
        Me.txtatribut.Name = "txtatribut"
        Me.txtatribut.Size = New System.Drawing.Size(138, 20)
        Me.txtatribut.TabIndex = 198
        '
        'dg2
        '
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Location = New System.Drawing.Point(177, 269)
        Me.dg2.Name = "dg2"
        Me.dg2.Size = New System.Drawing.Size(442, 150)
        Me.dg2.TabIndex = 199
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(544, 177)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 200
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'fmkriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(651, 431)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.dg2)
        Me.Controls.Add(Me.txtatribut)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnbaru)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.txtbobot)
        Me.Controls.Add(Me.txtkriteria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmkriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "kriteria"
        Me.pnlLeftSide.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtkriteria As System.Windows.Forms.TextBox
    Friend WithEvents txtbobot As System.Windows.Forms.TextBox
    Friend WithEvents pnlLeftSide As System.Windows.Forms.Panel
    Friend WithEvents pnlOnButtonPosition As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnkontak As System.Windows.Forms.Button
    Friend WithEvents btnhasil As System.Windows.Forms.Button
    Friend WithEvents btnnilai As System.Windows.Forms.Button
    Friend WithEvents btndata As System.Windows.Forms.Button
    Friend WithEvents pnlTopSide As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnbaru As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents txtatribut As System.Windows.Forms.TextBox
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnedit As System.Windows.Forms.Button
End Class
