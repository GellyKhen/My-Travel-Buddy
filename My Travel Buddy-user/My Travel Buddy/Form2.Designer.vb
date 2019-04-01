<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _frmregion1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_frmregion1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._pbilocossur = New System.Windows.Forms.PictureBox()
        Me._pblaunion = New System.Windows.Forms.PictureBox()
        Me._pbpangasinan = New System.Windows.Forms.PictureBox()
        Me._btback = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbilocossur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pblaunion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbpangasinan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(143, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 111)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        '_pbilocossur
        '
        Me._pbilocossur.Image = CType(resources.GetObject("_pbilocossur.Image"), System.Drawing.Image)
        Me._pbilocossur.Location = New System.Drawing.Point(143, 155)
        Me._pbilocossur.Name = "_pbilocossur"
        Me._pbilocossur.Size = New System.Drawing.Size(172, 112)
        Me._pbilocossur.TabIndex = 1
        Me._pbilocossur.TabStop = False
        '
        '_pblaunion
        '
        Me._pblaunion.Image = CType(resources.GetObject("_pblaunion.Image"), System.Drawing.Image)
        Me._pblaunion.Location = New System.Drawing.Point(143, 264)
        Me._pblaunion.Name = "_pblaunion"
        Me._pblaunion.Size = New System.Drawing.Size(172, 81)
        Me._pblaunion.TabIndex = 2
        Me._pblaunion.TabStop = False
        '
        '_pbpangasinan
        '
        Me._pbpangasinan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._pbpangasinan.Image = CType(resources.GetObject("_pbpangasinan.Image"), System.Drawing.Image)
        Me._pbpangasinan.Location = New System.Drawing.Point(143, 314)
        Me._pbpangasinan.Name = "_pbpangasinan"
        Me._pbpangasinan.Size = New System.Drawing.Size(172, 100)
        Me._pbpangasinan.TabIndex = 3
        Me._pbpangasinan.TabStop = False
        '
        '_btback
        '
        Me._btback.Location = New System.Drawing.Point(143, 453)
        Me._btback.Name = "_btback"
        Me._btback.Size = New System.Drawing.Size(172, 35)
        Me._btback.TabIndex = 4
        Me._btback.Text = "Back"
        Me._btback.UseVisualStyleBackColor = True
        '
        '_frmregion1
        '
        Me.AccessibleName = "_frmregion1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 513)
        Me.Controls.Add(Me._btback)
        Me.Controls.Add(Me._pbpangasinan)
        Me.Controls.Add(Me._pblaunion)
        Me.Controls.Add(Me._pbilocossur)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "_frmregion1"
        Me.Text = "Region 1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbilocossur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pblaunion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbpangasinan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _pbilocossur As System.Windows.Forms.PictureBox
    Friend WithEvents _pblaunion As System.Windows.Forms.PictureBox
    Friend WithEvents _pbpangasinan As System.Windows.Forms.PictureBox
    Friend WithEvents _btback As System.Windows.Forms.Button
End Class
