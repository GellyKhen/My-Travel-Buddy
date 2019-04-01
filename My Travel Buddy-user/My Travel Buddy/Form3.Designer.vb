<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _frmregion2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_frmregion2))
        Me._pbbatanes = New System.Windows.Forms.PictureBox()
        Me._pbcagayan = New System.Windows.Forms.PictureBox()
        Me._pbisabela = New System.Windows.Forms.PictureBox()
        Me._pbquirino = New System.Windows.Forms.PictureBox()
        Me._pbnuevavizcaya = New System.Windows.Forms.PictureBox()
        Me._btnback = New System.Windows.Forms.Button()
        CType(Me._pbbatanes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbcagayan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbisabela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbquirino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbnuevavizcaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pbbatanes
        '
        Me._pbbatanes.BackgroundImage = CType(resources.GetObject("_pbbatanes.BackgroundImage"), System.Drawing.Image)
        Me._pbbatanes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbbatanes.Location = New System.Drawing.Point(89, 12)
        Me._pbbatanes.Name = "_pbbatanes"
        Me._pbbatanes.Size = New System.Drawing.Size(174, 116)
        Me._pbbatanes.TabIndex = 0
        Me._pbbatanes.TabStop = False
        '
        '_pbcagayan
        '
        Me._pbcagayan.BackgroundImage = CType(resources.GetObject("_pbcagayan.BackgroundImage"), System.Drawing.Image)
        Me._pbcagayan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbcagayan.Location = New System.Drawing.Point(89, 125)
        Me._pbcagayan.Name = "_pbcagayan"
        Me._pbcagayan.Size = New System.Drawing.Size(174, 159)
        Me._pbcagayan.TabIndex = 1
        Me._pbcagayan.TabStop = False
        '
        '_pbisabela
        '
        Me._pbisabela.BackgroundImage = CType(resources.GetObject("_pbisabela.BackgroundImage"), System.Drawing.Image)
        Me._pbisabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbisabela.Location = New System.Drawing.Point(89, 279)
        Me._pbisabela.Name = "_pbisabela"
        Me._pbisabela.Size = New System.Drawing.Size(174, 80)
        Me._pbisabela.TabIndex = 2
        Me._pbisabela.TabStop = False
        '
        '_pbquirino
        '
        Me._pbquirino.BackgroundImage = CType(resources.GetObject("_pbquirino.BackgroundImage"), System.Drawing.Image)
        Me._pbquirino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbquirino.Location = New System.Drawing.Point(89, 356)
        Me._pbquirino.Name = "_pbquirino"
        Me._pbquirino.Size = New System.Drawing.Size(174, 64)
        Me._pbquirino.TabIndex = 4
        Me._pbquirino.TabStop = False
        '
        '_pbnuevavizcaya
        '
        Me._pbnuevavizcaya.BackgroundImage = CType(resources.GetObject("_pbnuevavizcaya.BackgroundImage"), System.Drawing.Image)
        Me._pbnuevavizcaya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbnuevavizcaya.Location = New System.Drawing.Point(89, 356)
        Me._pbnuevavizcaya.Name = "_pbnuevavizcaya"
        Me._pbnuevavizcaya.Size = New System.Drawing.Size(54, 64)
        Me._pbnuevavizcaya.TabIndex = 5
        Me._pbnuevavizcaya.TabStop = False
        '
        '_btnback
        '
        Me._btnback.Location = New System.Drawing.Point(89, 436)
        Me._btnback.Name = "_btnback"
        Me._btnback.Size = New System.Drawing.Size(174, 43)
        Me._btnback.TabIndex = 6
        Me._btnback.Text = "Back"
        Me._btnback.UseVisualStyleBackColor = True
        '
        '_frmregion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 491)
        Me.Controls.Add(Me._btnback)
        Me.Controls.Add(Me._pbnuevavizcaya)
        Me.Controls.Add(Me._pbquirino)
        Me.Controls.Add(Me._pbisabela)
        Me.Controls.Add(Me._pbcagayan)
        Me.Controls.Add(Me._pbbatanes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "_frmregion2"
        Me.Text = "Region 2"
        CType(Me._pbbatanes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbcagayan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbisabela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbquirino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbnuevavizcaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _pbbatanes As System.Windows.Forms.PictureBox
    Friend WithEvents _pbcagayan As System.Windows.Forms.PictureBox
    Friend WithEvents _pbisabela As System.Windows.Forms.PictureBox
    Friend WithEvents _pbquirino As System.Windows.Forms.PictureBox
    Friend WithEvents _pbnuevavizcaya As System.Windows.Forms.PictureBox
    Friend WithEvents _btnback As System.Windows.Forms.Button
End Class
