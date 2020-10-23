<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InOutTransactionTab
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
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InOutTransactionTab))
        Me.ButtonTopUp = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonOut = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonIn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SuspendLayout()
        '
        'ButtonTopUp
        '
        Me.ButtonTopUp.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonTopUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonTopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTopUp.BorderRadius = 0
        Me.ButtonTopUp.ButtonText = "TOP UP"
        Me.ButtonTopUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonTopUp, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonTopUp.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonTopUp.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTopUp.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonTopUp.Iconimage = Nothing
        Me.ButtonTopUp.Iconimage_right = Nothing
        Me.ButtonTopUp.Iconimage_right_Selected = Nothing
        Me.ButtonTopUp.Iconimage_Selected = Nothing
        Me.ButtonTopUp.IconMarginLeft = 0
        Me.ButtonTopUp.IconMarginRight = 0
        Me.ButtonTopUp.IconRightVisible = True
        Me.ButtonTopUp.IconRightZoom = 0R
        Me.ButtonTopUp.IconVisible = False
        Me.ButtonTopUp.IconZoom = 90.0R
        Me.ButtonTopUp.IsTab = False
        Me.ButtonTopUp.Location = New System.Drawing.Point(0, 225)
        Me.ButtonTopUp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonTopUp.Name = "ButtonTopUp"
        Me.ButtonTopUp.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonTopUp.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonTopUp.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonTopUp.selected = True
        Me.ButtonTopUp.Size = New System.Drawing.Size(175, 57)
        Me.ButtonTopUp.TabIndex = 3
        Me.ButtonTopUp.Text = "TOP UP"
        Me.ButtonTopUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTopUp.Textcolor = System.Drawing.Color.White
        Me.ButtonTopUp.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTopUp.Visible = False
        '
        'ButtonOut
        '
        Me.ButtonOut.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonOut.BorderRadius = 0
        Me.ButtonOut.ButtonText = "SCAN - OUT TRANSACTION"
        Me.ButtonOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonOut, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonOut.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonOut.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOut.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonOut.Iconimage = Nothing
        Me.ButtonOut.Iconimage_right = Nothing
        Me.ButtonOut.Iconimage_right_Selected = Nothing
        Me.ButtonOut.Iconimage_Selected = Nothing
        Me.ButtonOut.IconMarginLeft = 0
        Me.ButtonOut.IconMarginRight = 0
        Me.ButtonOut.IconRightVisible = True
        Me.ButtonOut.IconRightZoom = 0R
        Me.ButtonOut.IconVisible = False
        Me.ButtonOut.IconZoom = 90.0R
        Me.ButtonOut.IsTab = False
        Me.ButtonOut.Location = New System.Drawing.Point(0, 160)
        Me.ButtonOut.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonOut.Name = "ButtonOut"
        Me.ButtonOut.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonOut.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonOut.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonOut.selected = True
        Me.ButtonOut.Size = New System.Drawing.Size(175, 57)
        Me.ButtonOut.TabIndex = 2
        Me.ButtonOut.Text = "SCAN - OUT TRANSACTION"
        Me.ButtonOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOut.Textcolor = System.Drawing.Color.White
        Me.ButtonOut.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOut.Visible = False
        '
        'ButtonIn
        '
        Me.ButtonIn.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonIn.BorderRadius = 0
        Me.ButtonIn.ButtonText = "SCAN - IN TRANSACTION"
        Me.ButtonIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ButtonIn, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonIn.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonIn.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIn.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonIn.Iconimage = Nothing
        Me.ButtonIn.Iconimage_right = Nothing
        Me.ButtonIn.Iconimage_right_Selected = Nothing
        Me.ButtonIn.Iconimage_Selected = Nothing
        Me.ButtonIn.IconMarginLeft = 0
        Me.ButtonIn.IconMarginRight = 0
        Me.ButtonIn.IconRightVisible = True
        Me.ButtonIn.IconRightZoom = 0R
        Me.ButtonIn.IconVisible = False
        Me.ButtonIn.IconZoom = 90.0R
        Me.ButtonIn.IsTab = False
        Me.ButtonIn.Location = New System.Drawing.Point(0, 95)
        Me.ButtonIn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonIn.Name = "ButtonIn"
        Me.ButtonIn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ButtonIn.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonIn.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonIn.selected = True
        Me.ButtonIn.Size = New System.Drawing.Size(175, 57)
        Me.ButtonIn.TabIndex = 1
        Me.ButtonIn.Text = "SCAN - IN TRANSACTION"
        Me.ButtonIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIn.Textcolor = System.Drawing.Color.White
        Me.ButtonIn.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIn.Visible = False
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
        'InOutTransactionTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ButtonTopUp)
        Me.Controls.Add(Me.ButtonOut)
        Me.Controls.Add(Me.ButtonIn)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "InOutTransactionTab"
        Me.Size = New System.Drawing.Size(175, 480)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonIn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonOut As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonTopUp As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
End Class
