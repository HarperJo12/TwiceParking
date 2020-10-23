<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrontMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontMenu))
        Me.Round = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Drag = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuImageButtonMoveable = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ShowForm = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.HideForm = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.ButtonNewMember = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ButtonTopUp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonReport = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonDatabase = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonTransaction = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.InOutTransactionTab11 = New ProjectSistemParkir.InOutTransactionTab()
        Me.DatabaseTab1 = New ProjectSistemParkir.DatabaseTab()
        Me.ReportTab1 = New ProjectSistemParkir.ReportTab()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.BunifuImageButtonMoveable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonNewMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Round
        '
        Me.Round.ElipseRadius = 10
        Me.Round.TargetControl = Me
        '
        'Drag
        '
        Me.Drag.Fixed = True
        Me.Drag.Horizontal = True
        Me.Drag.TargetControl = Me.BunifuImageButtonMoveable
        Me.Drag.Vertical = True
        '
        'BunifuImageButtonMoveable
        '
        Me.BunifuImageButtonMoveable.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButtonMoveable.Image = Global.ProjectSistemParkir.My.Resources.Resources.Move2_50px
        Me.BunifuImageButtonMoveable.ImageActive = Nothing
        Me.BunifuImageButtonMoveable.Location = New System.Drawing.Point(143, 449)
        Me.BunifuImageButtonMoveable.Name = "BunifuImageButtonMoveable"
        Me.BunifuImageButtonMoveable.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButtonMoveable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButtonMoveable.TabIndex = 0
        Me.BunifuImageButtonMoveable.TabStop = False
        Me.BunifuImageButtonMoveable.Zoom = 10
        '
        'ShowForm
        '
        Me.ShowForm.Delay = 1
        '
        'HideForm
        '
        Me.HideForm.Delay = 1
        '
        'ButtonNewMember
        '
        Me.ButtonNewMember.BackColor = System.Drawing.Color.SeaGreen
        Me.ButtonNewMember.Image = Global.ProjectSistemParkir.My.Resources.Resources.MENU_GIF_MEMBER_175
        Me.ButtonNewMember.ImageActive = Nothing
        Me.ButtonNewMember.Location = New System.Drawing.Point(282, 294)
        Me.ButtonNewMember.Name = "ButtonNewMember"
        Me.ButtonNewMember.Size = New System.Drawing.Size(175, 175)
        Me.ButtonNewMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonNewMember.TabIndex = 5
        Me.ButtonNewMember.TabStop = False
        Me.ButtonNewMember.Zoom = 10
        '
        'ButtonTopUp
        '
        Me.ButtonTopUp.BackColor = System.Drawing.Color.SeaGreen
        Me.ButtonTopUp.Image = Global.ProjectSistemParkir.My.Resources.Resources.Top_Up1
        Me.ButtonTopUp.ImageActive = Nothing
        Me.ButtonTopUp.Location = New System.Drawing.Point(493, 294)
        Me.ButtonTopUp.Name = "ButtonTopUp"
        Me.ButtonTopUp.Size = New System.Drawing.Size(175, 175)
        Me.ButtonTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ButtonTopUp.TabIndex = 2
        Me.ButtonTopUp.TabStop = False
        Me.ButtonTopUp.Zoom = 10
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.ButtonReport)
        Me.BunifuGradientPanel1.Controls.Add(Me.ButtonExit)
        Me.BunifuGradientPanel1.Controls.Add(Me.ButtonDatabase)
        Me.BunifuGradientPanel1.Controls.Add(Me.ButtonTransaction)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 100
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(225, 480)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TWICE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ProjectSistemParkir.My.Resources.Resources.liquid_preloader_dribbble_v2
        Me.PictureBox1.Location = New System.Drawing.Point(-16, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ButtonReport
        '
        Me.ButtonReport.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonReport.BackColor = System.Drawing.Color.Transparent
        Me.ButtonReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonReport.BorderRadius = 0
        Me.ButtonReport.ButtonText = "REPORT"
        Me.ButtonReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReport.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonReport.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonReport.Iconimage = CType(resources.GetObject("ButtonReport.Iconimage"), System.Drawing.Image)
        Me.ButtonReport.Iconimage_right = Nothing
        Me.ButtonReport.Iconimage_right_Selected = Nothing
        Me.ButtonReport.Iconimage_Selected = Nothing
        Me.ButtonReport.IconMarginLeft = 0
        Me.ButtonReport.IconMarginRight = 0
        Me.ButtonReport.IconRightVisible = True
        Me.ButtonReport.IconRightZoom = 0R
        Me.ButtonReport.IconVisible = False
        Me.ButtonReport.IconZoom = 90.0R
        Me.ButtonReport.IsTab = True
        Me.ButtonReport.Location = New System.Drawing.Point(0, 346)
        Me.ButtonReport.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Normalcolor = System.Drawing.Color.Transparent
        Me.ButtonReport.OnHovercolor = System.Drawing.Color.Gray
        Me.ButtonReport.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonReport.selected = False
        Me.ButtonReport.Size = New System.Drawing.Size(225, 57)
        Me.ButtonReport.TabIndex = 7
        Me.ButtonReport.Text = "REPORT"
        Me.ButtonReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonReport.Textcolor = System.Drawing.Color.White
        Me.ButtonReport.TextFont = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonExit
        '
        Me.ButtonExit.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExit.BorderRadius = 0
        Me.ButtonExit.ButtonText = "EXIT"
        Me.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExit.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonExit.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonExit.Iconimage = CType(resources.GetObject("ButtonExit.Iconimage"), System.Drawing.Image)
        Me.ButtonExit.Iconimage_right = Nothing
        Me.ButtonExit.Iconimage_right_Selected = Nothing
        Me.ButtonExit.Iconimage_Selected = Nothing
        Me.ButtonExit.IconMarginLeft = 0
        Me.ButtonExit.IconMarginRight = 0
        Me.ButtonExit.IconRightVisible = True
        Me.ButtonExit.IconRightZoom = 0R
        Me.ButtonExit.IconVisible = False
        Me.ButtonExit.IconZoom = 90.0R
        Me.ButtonExit.IsTab = False
        Me.ButtonExit.Location = New System.Drawing.Point(0, 411)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Normalcolor = System.Drawing.Color.Transparent
        Me.ButtonExit.OnHovercolor = System.Drawing.Color.Gray
        Me.ButtonExit.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonExit.selected = False
        Me.ButtonExit.Size = New System.Drawing.Size(225, 57)
        Me.ButtonExit.TabIndex = 2
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExit.Textcolor = System.Drawing.Color.White
        Me.ButtonExit.TextFont = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonDatabase
        '
        Me.ButtonDatabase.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonDatabase.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDatabase.BorderRadius = 0
        Me.ButtonDatabase.ButtonText = "DATABASE"
        Me.ButtonDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDatabase.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonDatabase.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonDatabase.Iconimage = CType(resources.GetObject("ButtonDatabase.Iconimage"), System.Drawing.Image)
        Me.ButtonDatabase.Iconimage_right = Nothing
        Me.ButtonDatabase.Iconimage_right_Selected = Nothing
        Me.ButtonDatabase.Iconimage_Selected = Nothing
        Me.ButtonDatabase.IconMarginLeft = 0
        Me.ButtonDatabase.IconMarginRight = 0
        Me.ButtonDatabase.IconRightVisible = True
        Me.ButtonDatabase.IconRightZoom = 0R
        Me.ButtonDatabase.IconVisible = False
        Me.ButtonDatabase.IconZoom = 90.0R
        Me.ButtonDatabase.IsTab = True
        Me.ButtonDatabase.Location = New System.Drawing.Point(0, 281)
        Me.ButtonDatabase.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonDatabase.Name = "ButtonDatabase"
        Me.ButtonDatabase.Normalcolor = System.Drawing.Color.Transparent
        Me.ButtonDatabase.OnHovercolor = System.Drawing.Color.Gray
        Me.ButtonDatabase.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonDatabase.selected = False
        Me.ButtonDatabase.Size = New System.Drawing.Size(225, 57)
        Me.ButtonDatabase.TabIndex = 1
        Me.ButtonDatabase.Text = "DATABASE"
        Me.ButtonDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDatabase.Textcolor = System.Drawing.Color.White
        Me.ButtonDatabase.TextFont = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonTransaction
        '
        Me.ButtonTransaction.Activecolor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonTransaction.BackColor = System.Drawing.Color.Transparent
        Me.ButtonTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTransaction.BorderRadius = 0
        Me.ButtonTransaction.ButtonText = "TRANSACTION"
        Me.ButtonTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTransaction.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTransaction.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonTransaction.Iconimage = CType(resources.GetObject("ButtonTransaction.Iconimage"), System.Drawing.Image)
        Me.ButtonTransaction.Iconimage_right = Nothing
        Me.ButtonTransaction.Iconimage_right_Selected = Nothing
        Me.ButtonTransaction.Iconimage_Selected = Nothing
        Me.ButtonTransaction.IconMarginLeft = 0
        Me.ButtonTransaction.IconMarginRight = 0
        Me.ButtonTransaction.IconRightVisible = True
        Me.ButtonTransaction.IconRightZoom = 0R
        Me.ButtonTransaction.IconVisible = False
        Me.ButtonTransaction.IconZoom = 90.0R
        Me.ButtonTransaction.IsTab = True
        Me.ButtonTransaction.Location = New System.Drawing.Point(0, 216)
        Me.ButtonTransaction.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonTransaction.Name = "ButtonTransaction"
        Me.ButtonTransaction.Normalcolor = System.Drawing.Color.Transparent
        Me.ButtonTransaction.OnHovercolor = System.Drawing.Color.Gray
        Me.ButtonTransaction.OnHoverTextColor = System.Drawing.Color.White
        Me.ButtonTransaction.selected = False
        Me.ButtonTransaction.Size = New System.Drawing.Size(225, 57)
        Me.ButtonTransaction.TabIndex = 0
        Me.ButtonTransaction.Text = "TRANSACTION"
        Me.ButtonTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTransaction.Textcolor = System.Drawing.Color.White
        Me.ButtonTransaction.TextFont = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButtonMoveable)
        Me.BunifuGradientPanel2.Controls.Add(Me.InOutTransactionTab11)
        Me.BunifuGradientPanel2.Controls.Add(Me.DatabaseTab1)
        Me.BunifuGradientPanel2.Controls.Add(Me.ReportTab1)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Gainsboro
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Gainsboro
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Gainsboro
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Gainsboro
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(625, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(175, 480)
        Me.BunifuGradientPanel2.TabIndex = 1
        '
        'InOutTransactionTab11
        '
        Me.InOutTransactionTab11.BackColor = System.Drawing.Color.Gainsboro
        Me.InOutTransactionTab11.Location = New System.Drawing.Point(0, 0)
        Me.InOutTransactionTab11.Name = "InOutTransactionTab11"
        Me.InOutTransactionTab11.Size = New System.Drawing.Size(175, 480)
        Me.InOutTransactionTab11.TabIndex = 1
        Me.InOutTransactionTab11.Visible = False
        '
        'DatabaseTab1
        '
        Me.DatabaseTab1.BackColor = System.Drawing.Color.Gainsboro
        Me.DatabaseTab1.Location = New System.Drawing.Point(0, 0)
        Me.DatabaseTab1.Name = "DatabaseTab1"
        Me.DatabaseTab1.Size = New System.Drawing.Size(175, 480)
        Me.DatabaseTab1.TabIndex = 2
        Me.DatabaseTab1.Visible = False
        '
        'ReportTab1
        '
        Me.ReportTab1.BackColor = System.Drawing.Color.Gainsboro
        Me.ReportTab1.Location = New System.Drawing.Point(0, 0)
        Me.ReportTab1.Name = "ReportTab1"
        Me.ReportTab1.Size = New System.Drawing.Size(175, 480)
        Me.ReportTab1.TabIndex = 3
        Me.ReportTab1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.ProjectSistemParkir.My.Resources.Resources.parking_in_kavala
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(800, 480)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'FrontMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.ButtonNewMember)
        Me.Controls.Add(Me.ButtonTopUp)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrontMenu"
        Me.Opacity = 0R
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.BunifuImageButtonMoveable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonNewMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Round As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ButtonTopUp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Drag As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButtonMoveable As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ButtonExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonDatabase As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonTransaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonReport As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonNewMember As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents InOutTransactionTab11 As InOutTransactionTab
    Friend WithEvents DatabaseTab1 As DatabaseTab
    Friend WithEvents ReportTab1 As ReportTab
    Friend WithEvents ShowForm As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents HideForm As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents PictureBox1 As PictureBox
End Class
