<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportTab))
        Me.ButtonParkingTrans = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonTopUpTrans = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SuspendLayout()
        '
        'ButtonParkingTrans
        '
        Me.ButtonParkingTrans.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonParkingTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonParkingTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonParkingTrans.BorderRadius = 0
        Me.ButtonParkingTrans.ButtonText = "PARKING TRANSACTION"
        Me.ButtonParkingTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonParkingTrans, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonParkingTrans.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonParkingTrans.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParkingTrans.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonParkingTrans.Iconimage = CType(resources.GetObject("ButtonParkingTrans.Iconimage"), System.Drawing.Image)
        Me.ButtonParkingTrans.Iconimage_right = Nothing
        Me.ButtonParkingTrans.Iconimage_right_Selected = Nothing
        Me.ButtonParkingTrans.Iconimage_Selected = Nothing
        Me.ButtonParkingTrans.IconMarginLeft = 0
        Me.ButtonParkingTrans.IconMarginRight = 0
        Me.ButtonParkingTrans.IconRightVisible = True
        Me.ButtonParkingTrans.IconRightZoom = 0R
        Me.ButtonParkingTrans.IconVisible = False
        Me.ButtonParkingTrans.IconZoom = 90.0R
        Me.ButtonParkingTrans.IsTab = False
        Me.ButtonParkingTrans.Location = New System.Drawing.Point(0, 95)
        Me.ButtonParkingTrans.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonParkingTrans.Name = "ButtonParkingTrans"
        Me.ButtonParkingTrans.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonParkingTrans.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonParkingTrans.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonParkingTrans.selected = True
        Me.ButtonParkingTrans.Size = New System.Drawing.Size(175, 57)
        Me.ButtonParkingTrans.TabIndex = 13
        Me.ButtonParkingTrans.Text = "PARKING TRANSACTION"
        Me.ButtonParkingTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonParkingTrans.Textcolor = System.Drawing.Color.White
        Me.ButtonParkingTrans.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParkingTrans.Visible = False
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDashboard.BorderRadius = 0
        Me.ButtonDashboard.ButtonText = "DASHBOARD"
        Me.ButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonDashboard, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonDashboard.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonDashboard.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonDashboard.Iconimage = CType(resources.GetObject("ButtonDashboard.Iconimage"), System.Drawing.Image)
        Me.ButtonDashboard.Iconimage_right = Nothing
        Me.ButtonDashboard.Iconimage_right_Selected = Nothing
        Me.ButtonDashboard.Iconimage_Selected = Nothing
        Me.ButtonDashboard.IconMarginLeft = 0
        Me.ButtonDashboard.IconMarginRight = 0
        Me.ButtonDashboard.IconRightVisible = True
        Me.ButtonDashboard.IconRightZoom = 0R
        Me.ButtonDashboard.IconVisible = False
        Me.ButtonDashboard.IconZoom = 90.0R
        Me.ButtonDashboard.IsTab = False
        Me.ButtonDashboard.Location = New System.Drawing.Point(0, 225)
        Me.ButtonDashboard.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonDashboard.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonDashboard.selected = True
        Me.ButtonDashboard.Size = New System.Drawing.Size(175, 57)
        Me.ButtonDashboard.TabIndex = 12
        Me.ButtonDashboard.Text = "DASHBOARD"
        Me.ButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDashboard.Textcolor = System.Drawing.Color.White
        Me.ButtonDashboard.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Visible = False
        '
        'ButtonTopUpTrans
        '
        Me.ButtonTopUpTrans.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonTopUpTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonTopUpTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTopUpTrans.BorderRadius = 0
        Me.ButtonTopUpTrans.ButtonText = "TOP UP TRANSACTION"
        Me.ButtonTopUpTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonTopUpTrans, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonTopUpTrans.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonTopUpTrans.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTopUpTrans.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonTopUpTrans.Iconimage = CType(resources.GetObject("ButtonTopUpTrans.Iconimage"), System.Drawing.Image)
        Me.ButtonTopUpTrans.Iconimage_right = Nothing
        Me.ButtonTopUpTrans.Iconimage_right_Selected = Nothing
        Me.ButtonTopUpTrans.Iconimage_Selected = Nothing
        Me.ButtonTopUpTrans.IconMarginLeft = 0
        Me.ButtonTopUpTrans.IconMarginRight = 0
        Me.ButtonTopUpTrans.IconRightVisible = True
        Me.ButtonTopUpTrans.IconRightZoom = 0R
        Me.ButtonTopUpTrans.IconVisible = False
        Me.ButtonTopUpTrans.IconZoom = 90.0R
        Me.ButtonTopUpTrans.IsTab = False
        Me.ButtonTopUpTrans.Location = New System.Drawing.Point(0, 160)
        Me.ButtonTopUpTrans.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonTopUpTrans.Name = "ButtonTopUpTrans"
        Me.ButtonTopUpTrans.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonTopUpTrans.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonTopUpTrans.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonTopUpTrans.selected = True
        Me.ButtonTopUpTrans.Size = New System.Drawing.Size(175, 57)
        Me.ButtonTopUpTrans.TabIndex = 11
        Me.ButtonTopUpTrans.Text = "TOP UP TRANSACTION"
        Me.ButtonTopUpTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTopUpTrans.Textcolor = System.Drawing.Color.White
        Me.ButtonTopUpTrans.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTopUpTrans.Visible = False
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation3
        '
        'ReportTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ButtonParkingTrans)
        Me.Controls.Add(Me.ButtonDashboard)
        Me.Controls.Add(Me.ButtonTopUpTrans)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "ReportTab"
        Me.Size = New System.Drawing.Size(175, 480)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonParkingTrans As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonTopUpTrans As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
End Class
