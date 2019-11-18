<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmmenu
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
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.pnldata = New System.Windows.Forms.Panel()
        Me.pnlkaryawan = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlkriteria = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlnilai = New System.Windows.Forms.Panel()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.btnkaryawan = New System.Windows.Forms.Button()
        Me.btnkriteria = New System.Windows.Forms.Button()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnkontak = New System.Windows.Forms.Button()
        Me.btnhasil = New System.Windows.Forms.Button()
        Me.btnnilai = New System.Windows.Forms.Button()
        Me.btndata = New System.Windows.Forms.Button()
        Me.pnlLeftSide.SuspendLayout()
        Me.pnldata.SuspendLayout()
        Me.pnlkaryawan.SuspendLayout()
        Me.pnlkriteria.SuspendLayout()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlLeftSide.Size = New System.Drawing.Size(158, 429)
        Me.pnlLeftSide.TabIndex = 0
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.Red
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(1, 113)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(10, 31)
        Me.pnlOnButtonPosition.TabIndex = 7
        '
        'pnldata
        '
        Me.pnldata.BackColor = System.Drawing.Color.White
        Me.pnldata.Controls.Add(Me.pnlkaryawan)
        Me.pnldata.Controls.Add(Me.pnlkriteria)
        Me.pnldata.Location = New System.Drawing.Point(158, 53)
        Me.pnldata.Name = "pnldata"
        Me.pnldata.Size = New System.Drawing.Size(490, 369)
        Me.pnldata.TabIndex = 2
        '
        'pnlkaryawan
        '
        Me.pnlkaryawan.Controls.Add(Me.Label1)
        Me.pnlkaryawan.Controls.Add(Me.btnkaryawan)
        Me.pnlkaryawan.Location = New System.Drawing.Point(62, 99)
        Me.pnlkaryawan.Name = "pnlkaryawan"
        Me.pnlkaryawan.Size = New System.Drawing.Size(133, 117)
        Me.pnlkaryawan.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Karyawan"
        '
        'pnlkriteria
        '
        Me.pnlkriteria.Controls.Add(Me.Label2)
        Me.pnlkriteria.Controls.Add(Me.btnkriteria)
        Me.pnlkriteria.Location = New System.Drawing.Point(256, 99)
        Me.pnlkriteria.Name = "pnlkriteria"
        Me.pnlkriteria.Size = New System.Drawing.Size(133, 117)
        Me.pnlkriteria.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kriteria"
        '
        'pnlnilai
        '
        Me.pnlnilai.BackColor = System.Drawing.Color.White
        Me.pnlnilai.Location = New System.Drawing.Point(157, 50)
        Me.pnlnilai.Name = "pnlnilai"
        Me.pnlnilai.Size = New System.Drawing.Size(490, 369)
        Me.pnlnilai.TabIndex = 3
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.Red
        Me.pnlTopSide.Controls.Add(Me.btnminimize)
        Me.pnlTopSide.Controls.Add(Me.btnclose)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(158, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(490, 52)
        Me.pnlTopSide.TabIndex = 6
        '
        'btnkaryawan
        '
        Me.btnkaryawan.BackColor = System.Drawing.Color.Silver
        Me.btnkaryawan.BackgroundImage = Global.spk.My.Resources.Resources.user__1_
        Me.btnkaryawan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnkaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkaryawan.Location = New System.Drawing.Point(3, 35)
        Me.btnkaryawan.Name = "btnkaryawan"
        Me.btnkaryawan.Size = New System.Drawing.Size(127, 79)
        Me.btnkaryawan.TabIndex = 0
        Me.btnkaryawan.UseVisualStyleBackColor = False
        '
        'btnkriteria
        '
        Me.btnkriteria.BackColor = System.Drawing.Color.Silver
        Me.btnkriteria.BackgroundImage = Global.spk.My.Resources.Resources.testing__1_
        Me.btnkriteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnkriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkriteria.Location = New System.Drawing.Point(3, 35)
        Me.btnkriteria.Name = "btnkriteria"
        Me.btnkriteria.Size = New System.Drawing.Size(127, 79)
        Me.btnkriteria.TabIndex = 0
        Me.btnkriteria.UseVisualStyleBackColor = False
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.Red
        Me.btnminimize.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_723__minus__minimize__website_3838428
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Location = New System.Drawing.Point(460, 0)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(14, 22)
        Me.btnminimize.TabIndex = 13
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_cancel_1303884
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(474, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(14, 22)
        Me.btnclose.TabIndex = 12
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.spk.My.Resources.Resources.telkom_akses_logo_7ECCB5449C_seeklogo_com
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 53)
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
        'fmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(648, 429)
        Me.Controls.Add(Me.pnlnilai)
        Me.Controls.Add(Me.pnldata)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnldata.ResumeLayout(False)
        Me.pnlkaryawan.ResumeLayout(False)
        Me.pnlkaryawan.PerformLayout()
        Me.pnlkriteria.ResumeLayout(False)
        Me.pnlkriteria.PerformLayout()
        Me.pnlTopSide.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLeftSide As System.Windows.Forms.Panel
    Friend WithEvents btnkontak As System.Windows.Forms.Button
    Friend WithEvents btnhasil As System.Windows.Forms.Button
    Friend WithEvents btnnilai As System.Windows.Forms.Button
    Friend WithEvents btndata As System.Windows.Forms.Button
    Friend WithEvents pnldata As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlkriteria As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnkriteria As System.Windows.Forms.Button
    Friend WithEvents pnlkaryawan As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnkaryawan As System.Windows.Forms.Button
    Friend WithEvents pnlOnButtonPosition As System.Windows.Forms.Panel
    Friend WithEvents pnlTopSide As System.Windows.Forms.Panel
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents pnlnilai As System.Windows.Forms.Panel
End Class
