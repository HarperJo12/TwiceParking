<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseTab))
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ButtonMember = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonParking = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonCard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'ButtonMember
        '
        Me.ButtonMember.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMember.BorderRadius = 0
        Me.ButtonMember.ButtonText = "MEMBER"
        Me.ButtonMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonMember, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonMember.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonMember.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMember.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonMember.Iconimage = CType(resources.GetObject("ButtonMember.Iconimage"), System.Drawing.Image)
        Me.ButtonMember.Iconimage_right = Nothing
        Me.ButtonMember.Iconimage_right_Selected = Nothing
        Me.ButtonMember.Iconimage_Selected = Nothing
        Me.ButtonMember.IconMarginLeft = 0
        Me.ButtonMember.IconMarginRight = 0
        Me.ButtonMember.IconRightVisible = True
        Me.ButtonMember.IconRightZoom = 0R
        Me.ButtonMember.IconVisible = False
        Me.ButtonMember.IconZoom = 90.0R
        Me.ButtonMember.IsTab = False
        Me.ButtonMember.Location = New System.Drawing.Point(0, 95)
        Me.ButtonMember.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonMember.Name = "ButtonMember"
        Me.ButtonMember.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonMember.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonMember.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonMember.selected = False
        Me.ButtonMember.Size = New System.Drawing.Size(175, 57)
        Me.ButtonMember.TabIndex = 10
        Me.ButtonMember.Text = "MEMBER"
        Me.ButtonMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMember.Textcolor = System.Drawing.Color.White
        Me.ButtonMember.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonParking
        '
        Me.ButtonParking.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonParking.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonParking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonParking.BorderRadius = 0
        Me.ButtonParking.ButtonText = "PARKING"
        Me.ButtonParking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonParking, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonParking.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonParking.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParking.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonParking.Iconimage = CType(resources.GetObject("ButtonParking.Iconimage"), System.Drawing.Image)
        Me.ButtonParking.Iconimage_right = Nothing
        Me.ButtonParking.Iconimage_right_Selected = Nothing
        Me.ButtonParking.Iconimage_Selected = Nothing
        Me.ButtonParking.IconMarginLeft = 0
        Me.ButtonParking.IconMarginRight = 0
        Me.ButtonParking.IconRightVisible = True
        Me.ButtonParking.IconRightZoom = 0R
        Me.ButtonParking.IconVisible = False
        Me.ButtonParking.IconZoom = 90.0R
        Me.ButtonParking.IsTab = False
        Me.ButtonParking.Location = New System.Drawing.Point(0, 225)
        Me.ButtonParking.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonParking.Name = "ButtonParking"
        Me.ButtonParking.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonParking.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonParking.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonParking.selected = False
        Me.ButtonParking.Size = New System.Drawing.Size(175, 57)
        Me.ButtonParking.TabIndex = 9
        Me.ButtonParking.Text = "PARKING"
        Me.ButtonParking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonParking.Textcolor = System.Drawing.Color.White
        Me.ButtonParking.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonCard
        '
        Me.ButtonCard.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCard.BorderRadius = 0
        Me.ButtonCard.ButtonText = "CARD"
        Me.ButtonCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonCard, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonCard.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonCard.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCard.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonCard.Iconimage = CType(resources.GetObject("ButtonCard.Iconimage"), System.Drawing.Image)
        Me.ButtonCard.Iconimage_right = Nothing
        Me.ButtonCard.Iconimage_right_Selected = Nothing
        Me.ButtonCard.Iconimage_Selected = Nothing
        Me.ButtonCard.IconMarginLeft = 0
        Me.ButtonCard.IconMarginRight = 0
        Me.ButtonCard.IconRightVisible = True
        Me.ButtonCard.IconRightZoom = 0R
        Me.ButtonCard.IconVisible = False
        Me.ButtonCard.IconZoom = 90.0R
        Me.ButtonCard.IsTab = False
        Me.ButtonCard.Location = New System.Drawing.Point(0, 160)
        Me.ButtonCard.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonCard.Name = "ButtonCard"
        Me.ButtonCard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonCard.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonCard.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonCard.selected = False
        Me.ButtonCard.Size = New System.Drawing.Size(175, 57)
        Me.ButtonCard.TabIndex = 8
        Me.ButtonCard.Text = "CARD"
        Me.ButtonCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCard.Textcolor = System.Drawing.Color.White
        Me.ButtonCard.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DatabaseTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ButtonMember)
        Me.Controls.Add(Me.ButtonParking)
        Me.Controls.Add(Me.ButtonCard)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "DatabaseTab"
        Me.Size = New System.Drawing.Size(175, 480)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonMember As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonParking As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonCard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
End Class
