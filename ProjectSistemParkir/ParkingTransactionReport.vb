Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class ParkingTransactionReport
    Dim koneksi As Koneksi
    Dim DATABARU As Boolean
    Private adapter As MySqlDataAdapter

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        koneksi = New Koneksi()
        koneksi.bukaKoneksi()
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        Dim prg As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)

        tampilkanData()

        doc.AddTitle("TWICE PARKING SYSTEM")
        Dim write As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(My.Computer.FileSystem.SpecialDirectories.Desktop & "/Report_Transaksi_Parkir.pdf", FileMode.Create))
        doc.Open()

        ' Mempersiapkan font untuk judul dan table
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
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 10.0F
        doc.Add(prg)

        'Membuat Tabel
        Dim pdftbl As New PdfPTable(DataGridView1.Columns.Count - 1)

        'Setting Lebar Tabel
        pdftbl.TotalWidth = 400.0F
        pdftbl.LockedWidth = True

        'Mendeklarasikan PDF Cell
        Dim pdfpcell As PdfPCell = New PdfPCell

        'Membuat Header PDF Tabel
        For k As Integer = 1 To DataGridView1.Columns.Count - 1
            pdfpcell = New PdfPCell(New Phrase(New Chunk(DataGridView1.Columns(k).HeaderText, judulTabel)))

            'Alignment header table
            pdfpcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            'Menambahkan cell ke pdftable
            pdftbl.AddCell(pdfpcell)
        Next

        'Menambahkan data ke table pdf
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            For j As Integer = 1 To DataGridView1.Columns.Count - 1
                pdfpcell = New PdfPCell(New Phrase(DataGridView1(j, x).Value.ToString(), fontTabel))

                'Alignment data pada table
                pdfpcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                'Menambahkan cell ke pdftable
                pdftbl.AddCell(pdfpcell)
            Next
        Next

        'Menambahkan pdftable ke pdfdocument
        doc.Add(pdftbl)

        prg = New iTextSharp.text.Paragraph(New Chunk("========================================================", fontIsi))
        prg.Alignment = Element.ALIGN_CENTER
        prg.SpacingAfter = 5.0F
        doc.Add(prg)

        Process.Start(My.Computer.FileSystem.SpecialDirectories.Desktop & "/Report_Transaksi_Parkir.pdf")
        doc.Close()
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        tampilkanData()
    End Sub

    Private Sub tampilkanData()
        Dim awal, akhir As DateTime

        If dtpAwal.Value = Nothing Or dtpAkhir.Value = Nothing Then
            Exit Sub
        End If

        awal = dtpAwal.Value
        akhir = dtpAkhir.Value


        Dim dtable As New DataTable
        Try
            dtable = New DataTable
            adapter = New MySqlDataAdapter("SELECT no_transaksi, no_transaksi, jam_masuk, jam_keluar, total_biaya, t.noID, nama, alamat FROM transaksi_parkir t JOIN member m ON (t.noID = m.no_ID) WHERE jam_masuk BETWEEN '" & Format(awal, "yyyy/MM/dd hh:mm:ss") & "' AND '" & Format(akhir, "yyyy/MM/dd hh:mm:ss") & "'", koneksi.getConn())
            adapter.Fill(dtable)
            DataGridView1.DataSource = dtable

            DataGridView1.Columns(0).HeaderText = "No Transaksi"
            DataGridView1.Columns(1).HeaderText = "No Transaksi"
            DataGridView1.Columns(2).HeaderText = "Jam Masuk"
            DataGridView1.Columns(3).HeaderText = "Jam Keluar"
            DataGridView1.Columns(4).HeaderText = "Total Biaya"
            DataGridView1.Columns(5).HeaderText = "NO ID"
            DataGridView1.Columns(6).HeaderText = "Nama"
            DataGridView1.Columns(7).HeaderText = "Alamat"

            DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            With DataGridView1.ColumnHeadersDefaultCellStyle
                .BackColor = Color.DimGray
                .ForeColor = Color.White
                '.Font = New Font("Tw Cen MT", 12, FontStyle.Bold, GraphicsUnit.Point)
            End With

            With DataGridView1.DefaultCellStyle
                .BackColor = Color.Gray
                .ForeColor = Color.White
                '.Font = New Font("Century Gothic", 10, FontStyle.Regular, GraphicsUnit.Point)
            End With

            Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            'Me.DataGridView1.AutoResizeColumn(DataGridViewAutoSizeColumnMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class