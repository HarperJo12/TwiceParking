<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanOut
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanOut))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonScanIn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ButtonExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ButtonMoveable = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAvailable = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblNotifikasi = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDuration = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtOutTime = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtWallet = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.txtTotal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtInTime = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblTime = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ButtonStart = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lblInfo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpTanggal = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.ButtonScanIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonMoveable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.ButtonMoveable
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ButtonScanIn)
        Me.Panel2.Controls.Add(Me.ButtonExit)
        Me.Panel2.Controls.Add(Me.ButtonMoveable)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1067, 37)
        Me.Panel2.TabIndex = 4
        '
        'ButtonScanIn
        '
        Me.ButtonScanIn.BackColor = System.Drawing.Color.Transparent
        Me.ButtonScanIn.Image = Global.ProjectSistemParkir.My.Resources.Resources.Change_Theme_120apx
        Me.ButtonScanIn.ImageActive = Nothing
        Me.ButtonScanIn.Location = New System.Drawing.Point(963, 10)
        Me.ButtonScanIn.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonScanIn.Name = "ButtonScanIn"
        Me.ButtonScanIn.Size = New System.Drawing.Size(20, 18)
        Me.ButtonScanIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonScanIn.TabIndex = 3
        Me.ButtonScanIn.TabStop = False
        Me.ButtonScanIn.Zoom = 10
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.Image = CType(resources.GetObject("ButtonExit.Image"), System.Drawing.Image)
        Me.ButtonExit.ImageActive = Nothing
        Me.ButtonExit.Location = New System.Drawing.Point(1033, 10)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(20, 18)
        Me.ButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonExit.TabIndex = 2
        Me.ButtonExit.TabStop = False
        Me.ButtonExit.Zoom = 10
        '
        'ButtonMoveable
        '
        Me.ButtonMoveable.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMoveable.Image = Global.ProjectSistemParkir.My.Resources.Resources.Move2_50px
        Me.ButtonMoveable.ImageActive = Nothing
        Me.ButtonMoveable.Location = New System.Drawing.Point(999, 10)
        Me.ButtonMoveable.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMoveable.Name = "ButtonMoveable"
        Me.ButtonMoveable.Size = New System.Drawing.Size(20, 18)
        Me.ButtonMoveable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonMoveable.TabIndex = 1
        Me.ButtonMoveable.TabStop = False
        Me.ButtonMoveable.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtAvailable)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel1.Controls.Add(Me.lblNotifikasi)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel1.Controls.Add(Me.txtDuration)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.txtOutTime)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.txtWallet)
        Me.Panel1.Controls.Add(Me.lblTimer)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.txtInTime)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.ButtonStart)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.dtpTanggal)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 554)
        Me.Panel1.TabIndex = 5
        '
        'txtAvailable
        '
        Me.txtAvailable.BorderColorFocused = System.Drawing.Color.White
        Me.txtAvailable.BorderColorIdle = System.Drawing.Color.White
        Me.txtAvailable.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtAvailable.BorderThickness = 1
        Me.txtAvailable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAvailable.Enabled = False
        Me.txtAvailable.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailable.ForeColor = System.Drawing.Color.White
        Me.txtAvailable.isPassword = False
        Me.txtAvailable.Location = New System.Drawing.Point(442, 50)
        Me.txtAvailable.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.Size = New System.Drawing.Size(144, 65)
        Me.txtAvailable.TabIndex = 41
        Me.txtAvailable.Text = "99"
        Me.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(479, 24)
        Me.BunifuCustomLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(65, 23)
        Me.BunifuCustomLabel10.TabIndex = 40
        Me.BunifuCustomLabel10.Text = "Available"
        '
        'lblNotifikasi
        '
        Me.lblNotifikasi.AutoSize = True
        Me.lblNotifikasi.Font = New System.Drawing.Font("Tw Cen MT Condensed", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifikasi.ForeColor = System.Drawing.Color.White
        Me.lblNotifikasi.Location = New System.Drawing.Point(449, 474)
        Me.lblNotifikasi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotifikasi.Name = "lblNotifikasi"
        Me.lblNotifikasi.Size = New System.Drawing.Size(0, 39)
        Me.lblNotifikasi.TabIndex = 39
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(863, 356)
        Me.BunifuCustomLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(60, 23)
        Me.BunifuCustomLabel9.TabIndex = 38
        Me.BunifuCustomLabel9.Text = "Duration"
        '
        'txtDuration
        '
        Me.txtDuration.BorderColorFocused = System.Drawing.Color.White
        Me.txtDuration.BorderColorIdle = System.Drawing.Color.White
        Me.txtDuration.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtDuration.BorderThickness = 1
        Me.txtDuration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDuration.Enabled = False
        Me.txtDuration.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.ForeColor = System.Drawing.Color.White
        Me.txtDuration.isPassword = False
        Me.txtDuration.Location = New System.Drawing.Point(793, 382)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(190, 65)
        Me.txtDuration.TabIndex = 37
        Me.txtDuration.Text = "01:24:36"
        Me.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(861, 240)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(64, 23)
        Me.BunifuCustomLabel1.TabIndex = 36
        Me.BunifuCustomLabel1.Text = "Exit Time"
        '
        'txtOutTime
        '
        Me.txtOutTime.BorderColorFocused = System.Drawing.Color.White
        Me.txtOutTime.BorderColorIdle = System.Drawing.Color.White
        Me.txtOutTime.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtOutTime.BorderThickness = 1
        Me.txtOutTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOutTime.Enabled = False
        Me.txtOutTime.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutTime.ForeColor = System.Drawing.Color.White
        Me.txtOutTime.isPassword = False
        Me.txtOutTime.Location = New System.Drawing.Point(745, 266)
        Me.txtOutTime.Margin = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.txtOutTime.Name = "txtOutTime"
        Me.txtOutTime.Size = New System.Drawing.Size(297, 65)
        Me.txtOutTime.TabIndex = 35
        Me.txtOutTime.Text = "13:49:12"
        Me.txtOutTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(437, 271)
        Me.BunifuCustomLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(96, 23)
        Me.BunifuCustomLabel8.TabIndex = 34
        Me.BunifuCustomLabel8.Text = "Wallet Balance"
        '
        'txtWallet
        '
        Me.txtWallet.BorderColorFocused = System.Drawing.Color.DeepSkyBlue
        Me.txtWallet.BorderColorIdle = System.Drawing.Color.White
        Me.txtWallet.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue
        Me.txtWallet.BorderThickness = 1
        Me.txtWallet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWallet.Enabled = False
        Me.txtWallet.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtWallet.ForeColor = System.Drawing.Color.White
        Me.txtWallet.isPassword = False
        Me.txtWallet.Location = New System.Drawing.Point(443, 297)
        Me.txtWallet.Margin = New System.Windows.Forms.Padding(5)
        Me.txtWallet.Name = "txtWallet"
        Me.txtWallet.Size = New System.Drawing.Size(267, 31)
        Me.txtWallet.TabIndex = 33
        Me.txtWallet.Text = "225.000 IDR"
        Me.txtWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!)
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(7, 522)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(37, 23)
        Me.lblTimer.TabIndex = 32
        Me.lblTimer.Text = "time"
        '
        'txtTotal
        '
        Me.txtTotal.BorderColorFocused = System.Drawing.Color.White
        Me.txtTotal.BorderColorIdle = System.Drawing.Color.White
        Me.txtTotal.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtTotal.BorderThickness = 1
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.White
        Me.txtTotal.isPassword = False
        Me.txtTotal.Location = New System.Drawing.Point(443, 382)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(267, 65)
        Me.txtTotal.TabIndex = 31
        Me.txtTotal.Text = "25.000 IDR"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(856, 127)
        Me.BunifuCustomLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(72, 23)
        Me.BunifuCustomLabel7.TabIndex = 29
        Me.BunifuCustomLabel7.Text = "Entry Time"
        '
        'txtInTime
        '
        Me.txtInTime.BorderColorFocused = System.Drawing.Color.White
        Me.txtInTime.BorderColorIdle = System.Drawing.Color.White
        Me.txtInTime.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtInTime.BorderThickness = 1
        Me.txtInTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInTime.Enabled = False
        Me.txtInTime.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInTime.ForeColor = System.Drawing.Color.White
        Me.txtInTime.isPassword = False
        Me.txtInTime.Location = New System.Drawing.Point(745, 153)
        Me.txtInTime.Margin = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.txtInTime.Name = "txtInTime"
        Me.txtInTime.Size = New System.Drawing.Size(297, 65)
        Me.txtInTime.TabIndex = 28
        Me.txtInTime.Text = "12:24:36"
        Me.txtInTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTime.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(938, 11)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(84, 23)
        Me.lblTime.TabIndex = 27
        Me.lblTime.Text = "12:24:36"
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonStart.color = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonStart.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStart.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ButtonStart.ForeColor = System.Drawing.Color.White
        Me.ButtonStart.Image = Global.ProjectSistemParkir.My.Resources.Resources.QR_Code_96px
        Me.ButtonStart.ImagePosition = 5
        Me.ButtonStart.ImageZoom = 75
        Me.ButtonStart.LabelPosition = 0
        Me.ButtonStart.LabelText = ""
        Me.ButtonStart.Location = New System.Drawing.Point(187, 383)
        Me.ButtonStart.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(67, 62)
        Me.ButtonStart.TabIndex = 26
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tw Cen MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(116, 210)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(196, 47)
        Me.lblInfo.TabIndex = 25
        Me.lblInfo.Text = "PRESS TO SCAN"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(437, 127)
        Me.BunifuCustomLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(53, 23)
        Me.BunifuCustomLabel4.TabIndex = 24
        Me.BunifuCustomLabel4.Text = "Card ID"
        '
        'txtID
        '
        Me.txtID.BorderColorFocused = System.Drawing.Color.DeepSkyBlue
        Me.txtID.BorderColorIdle = System.Drawing.Color.White
        Me.txtID.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue
        Me.txtID.BorderThickness = 1
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.isPassword = False
        Me.txtID.Location = New System.Drawing.Point(443, 153)
        Me.txtID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(267, 31)
        Me.txtID.TabIndex = 23
        Me.txtID.Text = "12314463"
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(51, 43)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(184, 47)
        Me.BunifuCustomLabel2.TabIndex = 22
        Me.BunifuCustomLabel2.Text = "SEE YA LATER!"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.dtpTanggal.BorderRadius = 0
        Me.dtpTanggal.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggal.ForeColor = System.Drawing.Color.White
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTanggal.FormatCustom = Nothing
        Me.dtpTanggal.Location = New System.Drawing.Point(623, 0)
        Me.dtpTanggal.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(444, 47)
        Me.dtpTanggal.TabIndex = 19
        Me.dtpTanggal.Value = New Date(2018, 12, 20, 0, 17, 55, 0)
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(523, 356)
        Me.BunifuCustomLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(88, 23)
        Me.BunifuCustomLabel5.TabIndex = 18
        Me.BunifuCustomLabel5.Text = "Total Amount"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(437, 199)
        Me.BunifuCustomLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(43, 23)
        Me.BunifuCustomLabel3.TabIndex = 14
        Me.BunifuCustomLabel3.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BorderColorFocused = System.Drawing.Color.DeepSkyBlue
        Me.txtName.BorderColorIdle = System.Drawing.Color.White
        Me.txtName.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue
        Me.txtName.BorderThickness = 1
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.isPassword = False
        Me.txtName.Location = New System.Drawing.Point(443, 225)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(267, 31)
        Me.txtName.TabIndex = 13
        Me.txtName.Text = "Jono"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectSistemParkir.My.Resources.Resources.QR_Code_120px
        Me.PictureBox1.Location = New System.Drawing.Point(60, 123)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Timer3
        '
        '
        'Timer2
        '
        '
        'Timer1
        '
        '
        'ScanOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScanOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScanOut"
        Me.Panel2.ResumeLayout(False)
        CType(Me.ButtonScanIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonMoveable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonScanIn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ButtonExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ButtonMoveable As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtWallet As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblTimer As Label
    Friend WithEvents txtTotal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtInTime As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblTime As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ButtonStart As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblInfo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpTanggal As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDuration As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtOutTime As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblNotifikasi As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtAvailable As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
