Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Public Class ScanOut
    Dim koneksi As New Koneksi
    Dim DATABARU As Boolean
    Private adapter As MySqlDataAdapter
    Private tkt As Tiket
    Private mbr As Member

    WithEvents MyWebcam As WebCamCapture
    Dim totalBiaya, Id As String
    Dim waktuMasuk As DateTime
    Dim Reader As QRCodeDecoder
    Dim timer As Integer = 0

    Private Sub MyWebcam_ImageCaptured(ByVal source As Object, ByVal e As WebcamEventArgs) Handles MyWebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub

    Private Sub ClearData()
        txtID.Text = ""
        txtWallet.Text = ""
        txtName.Text = ""
        lblNotifikasi.Text = ""
        txtInTime.Text = ""
        lblNotifikasi.Text = ""
        txtInTime.Text = ""
        txtOutTime.Text = ""
        txtDuration.Text = ""
        txtTotal.Text = ""
        PictureBox1.Image = ProjectSistemParkir.My.Resources.Resources.QR_Code_120px
        lblInfo.Visible = True
    End Sub

    Private Sub StartWebcam()
        Try
            StopWebcam()
            MyWebcam = New WebCamCapture
            MyWebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopWebcam()
        Try
            MyWebcam.Stop()
            MyWebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1250
        lblTimer.Text = timer.ToString
        timer += 1

        If timer = 18 Then
            timer = 0
            StopWebcam()
            ClearData()
            Timer1.Enabled = False
            ButtonStart.Enabled = True
        Else
            If (timer Mod 5 = 0) Then
                Try
                    lblNotifikasi.Text = ""
                    StopWebcam()
                    Reader = New QRCodeDecoder
                    txtID.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
                    'timer = 0

                    If Not (txtID.Text = String.Empty Or txtID.Text = " ") Then
                        If getDataMember() And simpanData() Then
                            Timer3.Start()
                            Timer1.Enabled = False
                            timer = 0
                            pdf()
                            sendEmail()
                            lblNotifikasi.Text = "Terimakasih dan hati-hati dijalan"
                        Else
                            StartWebcam()
                        End If
                    End If
                Catch ex As Exception
                    StartWebcam()
                End Try
            End If
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        dtpTanggal.Value = DateTime.Now.ToString("dd-MMM-yyyy")
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        getSisaParkir()
    End Sub

    Private Sub FormKeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearData()
        Timer2.Start()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        StartWebcam()
        ClearData()
        Timer2.Start()
        Timer1.Enabled = True
        lblInfo.Visible = False
        ButtonStart.Enabled = False
    End Sub

    Public Function getWaktuKeluar() As DateTime
        Dim waktu As DateTime
        waktu = dtpTanggal.Value.ToString("dd-MMM-yyyy") & " " & lblTime.Text
        Return waktu
    End Function

    Public Function getDataMember() As Boolean
        koneksi.bukaKoneksi()
        Dim cmd As New MySqlCommand("SELECT Id_kartu, k.no_id, nama, alamat, telepon, wallet, email FROM kartu k join member m ON k.no_ID = m.no_ID WHERE Id_kartu = @Id_kartu", koneksi.getConn())
        cmd.Parameters.Add("@Id_kartu", MySqlDbType.String).Value = txtID.Text
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        If reader.Read() Then
            mbr = New Member(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            tkt = New Tiket(Nothing, Nothing, Nothing, reader(1), Nothing)
            Id = reader(1)
            txtName.Text = reader(2)
            txtWallet.Text = reader(5)

            koneksi.tutupKoneksi()
            Timer2.Stop()
            Return True
        Else
            txtID.Text = ""
            lblNotifikasi.Text = "ID member tidak terdeteksi"

            koneksi.tutupKoneksi()
            Timer2.Stop()
            Return False
        End If
    End Function

    Private Sub insertData(ByVal str1 As String)
        Dim sqlstr As String = str1
        Dim dt As New DataTable
        Try
            adapter = New MySqlDataAdapter(sqlstr, koneksi.getConn())
            adapter.Fill(dt)
            'MsgBox(dt.Rows(0)(0).ToString, MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox(ex.Message.ToString,
                   MsgBoxStyle.Information, "Pesan")
        End Try
        koneksi.tutupKoneksi()
    End Sub

    Public Function getNoTransaksi() As String
        Dim notrans As String
        koneksi.bukaKoneksi()
        Dim cmd As New MySqlCommand("SELECT MAX(no_transaksi) 'notrans', MAX(jam_masuk)  FROM transaksi_parkir WHERE noID = @noID GROUP BY 'notrans'", koneksi.getConn())
        cmd.Parameters.Add("@noID", MySqlDbType.String).Value = tkt.id
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        If reader.Read() Then
            notrans = reader(0)
            tkt.jamMsk = reader(1)
            'waktuMasuk = reader(1)
            'MessageBox.Show(tkt.jamMsk.ToString("dd-MMM-yyyy HH:mm:ss"))
        Else
            notrans = ""
        End If

        koneksi.tutupKoneksi()

        Return notrans
    End Function

    Public Function simpanData() As Boolean
        Dim simpan, simpan1, simpan2, no_parkir As String
        Dim elapseTime As TimeSpan
        Dim elapseDay, elapseMinute, elapseHour, elapseTotal, totalBiaya, sisa As Integer
        If (txtID.Text = "") Then
            Exit Function
        End If

        tkt.notransaksi = getNoTransaksi()
        tkt.jamKlr = getWaktuKeluar()
        elapseTime = tkt.jamKlr - DateTime.Parse(tkt.jamMsk.ToString("dd-MMM-yyyy HH:mm:ss"))
        txtInTime.Text = tkt.jamMsk.ToString("dd-MMM-yyyy HH:mm:ss")
        txtOutTime.Text = tkt.jamKlr.ToString("dd-MMM-yyyy HH:mm:ss")
        txtDuration.Text = elapseTime.ToString
        'MessageBox.Show(elapseTime.ToString)

        If elapseTime.Minutes > 0 Then
            elapseMinute = 1
        Else
            elapseMinute = 0
        End If

        no_parkir = getNoParkir()

        sisa = CInt(txtAvailable.Text) + 1

        elapseDay = elapseTime.Days * 24
        elapseHour = elapseTime.Hours
        elapseTotal = elapseDay + elapseHour + elapseMinute
        totalBiaya = elapseTotal * getTarifParkir()
        tkt.totalbiaya = totalBiaya
        txtTotal.Text = totalBiaya.ToString & " IDR"
        If tkt.totalbiaya <= mbr.wallet Then
            mbr.wallet = mbr.wallet - totalBiaya

            simpan = "Call updateTransaksiParkiran('" & tkt.notransaksi & "', '" & Format(tkt.jamKlr, "yyyy-MM-dd HH:mm:ss") & "', '" & tkt.totalbiaya & "')"
            simpan1 = "Call updateJumlahTersedia('" & no_parkir & "', '" & CInt(sisa) & "')"
            simpan2 = "Call updateMember('" & mbr.id & "', '" & mbr.nama & "', '" & mbr.alamat & "', '" & mbr.telepon & "', '" & mbr.wallet & "', '" & mbr.email & "')"

            insertData(simpan)
            insertData(simpan1)
            insertData(simpan2)

            Me.Cursor = Cursors.WaitCursor
            Me.Cursor = Cursors.Default
            Return True
        Else
            lblNotifikasi.Text = "Wallet tidak mencukupi! harap top up wallet"
            Me.Cursor = Cursors.WaitCursor
            Me.Cursor = Cursors.Default
            Return False
        End If
    End Function

    Public Function getTarifParkir() As Integer
        Dim tarif As Integer
        koneksi.bukaKoneksi()
        Dim cmd As New MySqlCommand("SELECT tarif_per_jam FROM parkiran WHERE no_parkiran = @no_parkiran", koneksi.getConn())
        cmd.Parameters.Add("@no_parkiran", MySqlDbType.String).Value = 1
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        If reader.Read() Then
            tarif = reader(0)
        End If

        koneksi.tutupKoneksi()
        Return tarif
    End Function

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Interval = 1000
        lblTimer.Text = timer.ToString
        timer += 1
        'MessageBox.Show("Sini1")
        If timer = 10 Then
            timer = 0
            Timer2.Start()
            Timer3.Stop()
            ClearData()
            ButtonStart.Enabled = True
        End If
    End Sub

    Public Sub getSisaParkir()
        koneksi.bukaKoneksi()
        Dim cmd As New MySqlCommand("SELECT jumlah_tersedia FROM parkiran ", koneksi.getConn())
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        If reader.Read() Then
            txtAvailable.Text = reader(0)
        End If

        koneksi.tutupKoneksi()
    End Sub

    Public Function getNoParkir() As String
        koneksi.bukaKoneksi()
        Dim noparkir As String
        Dim cmd As New MySqlCommand("SELECT MAX(jam_masuk), no_parkir FROM transaksi_parkir WHERE noid = '" & Id & "' ", koneksi.getConn())
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader

        If reader.Read() Then
            noparkir = reader(1)
        Else
            noparkir = ""
        End If

        koneksi.tutupKoneksi()
        Return noparkir
    End Function

    Private Sub sendEmail()
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim attachment As System.Net.Mail.Attachment

            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("twiceparking@gmail.com", "blackpink")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("twiceparking@gmail.com")
            e_mail.To.Add(mbr.email)
            e_mail.Subject = "Keluar Parkir"
            e_mail.IsBodyHtml = True
            e_mail.Body = "Anda berhasil keluar parkir twice <BR> ***One in A Million!***"

            attachment = New System.Net.Mail.Attachment(My.Computer.FileSystem.SpecialDirectories.Desktop & "/Report_Keluar.pdf") 'file path
            e_mail.Attachments.Add(attachment) 'attachment
            Smtp_Server.Send(e_mail)
            Smtp_Server.Dispose()
            'MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Private Sub pdf()
        Dim prg As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A6, 10, 10, 10, 10)

        doc.AddTitle("TWICE PARKING SYSTEM")
        Dim write As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(My.Computer.FileSystem.SpecialDirectories.Desktop & "/Report_Keluar.pdf", FileMode.Create))
        doc.Open()

        Dim fontJudul As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim fontIsi As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim judulTabel As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim fontTabel As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        prg = New iTextSharp.text.Paragraph(New Chunk("TWICE PARKING SYSTEM", fontJudul))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("NOWHERE FROM HERE", fontIsi))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("email: twiceparking@gmail.com", fontIsi))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Tanggal             : " & Format(Now, "dd-MM-yyyy / HH:mm"), fontIsi))
        prg.Alignment = Element.ALIGN_LEFT
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("========================================", fontIsi))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Selamat Jalan", fontIsi))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Nama             :" & mbr.nama, fontIsi))
        prg.Alignment = Element.ALIGN_LEFT
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Saldo            :" & mbr.wallet, fontIsi))
        prg.Alignment = Element.ALIGN_LEFT
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Biaya            :" & tkt.totalbiaya, fontIsi))
        prg.Alignment = Element.ALIGN_LEFT
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Jam Masuk    :" & tkt.jamMsk.ToString("dd-MMM-yyyy HH:mm:ss"), fontIsi))
        prg.Alignment = Element.ALIGN_LEFT
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Jam Keluar    :" & dtpTanggal.Value.ToString("dd-MMM-yyyy") & " " & lblTime.Text, fontIsi))
        prg.Alignment = Element.ALIGN_LEFT
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("========================================", fontIsi))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        prg = New iTextSharp.text.Paragraph(New Chunk("Terimakasih dan Hati-hati saat berkendara", fontIsi))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)
        doc.Close()
    End Sub

    Private Sub ButtonScanIn_Click(sender As Object, e As EventArgs) Handles ButtonScanIn.Click
        ScanIn.Show()
        Me.Close()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class