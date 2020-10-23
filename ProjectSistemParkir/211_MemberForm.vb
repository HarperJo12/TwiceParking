Imports MySql.Data.MySqlClient
Public Class _211_MemberForm
    Public Sub Smaller1DataGridSize()
        DataGridView1.Width -= 175
        Separator1.Width -= 175
    End Sub

    Public Sub Bigger1DataGridSize()
        DataGridView1.Width += 175
        Separator1.Width += 175
    End Sub

    Public Sub Smaller2DataGridSize()
        DataGridView1.Width -= 100
        Separator1.Width -= 100
    End Sub

    Public Sub Bigger2DataGridSize()
        DataGridView1.Width += 100
        Separator1.Width += 100
    End Sub

    Public Sub NormalSize()
        DataGridView1.Width = 475
        Separator1.Width = 475
    End Sub

    '----------------------------------------------CODE HERE------------------------------------------------------------------

    Dim koneksi As Koneksi
    Dim DATABARU As Boolean
    Private adapter As MySqlDataAdapter

    Public Sub _211_MemberForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        koneksi = New Koneksi()
        koneksi.bukaKoneksi()

        DATABARU = False
        'btnHapus.Enabled = False
        'btnSimpan.Enabled = False
        disableInput()

        tampilkanData()
    End Sub

    Public Sub tampilkanData()
        Dim dTable As New DataTable
        Try
            dTable = New DataTable
            adapter = New MySqlDataAdapter("SELECT no_id, nama, alamat, telepon, email FROM member", koneksi.getConn())
            adapter.Fill(dTable)
            DataGridView1.DataSource = dTable

            DataGridView1.Columns(0).HeaderText = "ID Member"
            DataGridView1.Columns(1).HeaderText = "Nama Member"
            DataGridView1.Columns(2).HeaderText = "Alamat"
            DataGridView1.Columns(3).HeaderText = "No Telpon"
            'DataGridView1.Columns(4).HeaderText = "Wallet"
            DataGridView1.Columns(4).HeaderText = "Email"

            DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            'DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            ' DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            With DataGridView1.ColumnHeadersDefaultCellStyle
                .BackColor = Color.DimGray
                .ForeColor = Color.White
                .Font = New Font("Tw Cen MT", 12, FontStyle.Bold, GraphicsUnit.Point)
            End With

            With DataGridView1.DefaultCellStyle
                .BackColor = Color.Gray
                .ForeColor = Color.White
                .Font = New Font("Century Gothic", 10, FontStyle.Regular, GraphicsUnit.Point)
            End With

            Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            'Me.DataGridView1.AutoResizeColumn(DataGridViewAutoSizeColumnMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub tambahDataMember()
        DATABARU = True
        clearData()
        enableInput()
        txtNamaMember.Focus()
        'btnHapus.Enabled = False
        'btnSimpan.Enabled = True
    End Sub

    Public Sub insertData(ByVal str1 As String)
        Dim sqlstr As String = str1
        Dim dt As New DataTable
        Try
            adapter = New MySqlDataAdapter(sqlstr, koneksi.getConn())
            adapter.Fill(dt)
            MsgBox(dt.Rows(0)(0).ToString,
                   MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox(ex.Message.ToString,
                   MsgBoxStyle.Information, "Pesan")
        End Try
        koneksi.tutupKoneksi()
    End Sub

    Private Sub isiTextBox(ByVal x As Integer)
        Try
            txtIDMember.Text = DataGridView1.Rows(x).Cells(0).Value
            txtNamaMember.Text = DataGridView1.Rows(x).Cells(1).Value
            txtAlamat.Text = DataGridView1.Rows(x).Cells(2).Value
            txtTelepon.Text = DataGridView1.Rows(x).Cells(3).Value
            txtEmail.Text = DataGridView1.Rows(x).Cells(4).Value
        Catch ex As Exception
        End Try
    End Sub

    Public Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        isiTextBox(e.RowIndex)
        DATABARU = False
    End Sub

    Public Sub simpanDataMember()
        Dim simpan As String
        Dim pesan As Integer

        If (txtNamaMember.Text = "" Or txtNamaMember.Text = "" Or txtAlamat.Text = "" Or txtTelepon.Text = "") Then
            Exit Sub
        End If

        If DATABARU Then
            pesan = MsgBox("Apakah Anda Yakin Data Akan ditambahkan ke Database ?", vbYesNo + vbInformation, "Perhatian")
            If pesan = vbYesNo Then
                Exit Sub
            End If
            simpan = "Call insertMember('" & txtNamaMember.Text & "',  '" & txtAlamat.Text & "', '" & txtTelepon.Text & "', '" & Nothing & "', '" & txtEmail.Text & "')"
            clearData()
            'btnBatal.PerformClick()
        Else
            pesan = MsgBox("Anda yakin data ini akan di update ?", vbYesNo + vbInformation, "Perhatian")
            If pesan = vbYesNo Then
                Exit Sub
            End If
            simpan = "Call updateMember('" & txtIDMember.Text & "', '" & txtNamaMember.Text & "', '" & txtAlamat.Text & "', '" & txtTelepon.Text & "', '" & txtWallet.Text & "', '" & txtEmail.Text & "')"
            clearData()
            'btnBatal.PerformClick()
        End If
        insertData(simpan)
        Me.Cursor = Cursors.WaitCursor
        DataGridView1.Refresh()
        tampilkanData()
        Me.Cursor = Cursors.Default
        'btnSimpan.Enabled = False
    End Sub

    Public Sub clearData()
        txtIDMember.Text = ""
        txtNamaMember.Text = ""
        txtAlamat.Text = ""
        txtTelepon.Text = ""
        txtEmail.Text = ""
        txtWallet.Text = ""
    End Sub

    Public Sub disableInput()
        txtIDMember.Enabled = False
        txtNamaMember.Enabled = False
        txtAlamat.Enabled = False
        txtTelepon.Enabled = False
        txtEmail.Enabled = False
        txtWallet.Text = False
    End Sub

    Public Sub enableInput()
        txtIDMember.Enabled = True
        txtNamaMember.Enabled = True
        txtAlamat.Enabled = True
        txtTelepon.Enabled = True
        txtEmail.Enabled = True
        txtWallet.Text = True
    End Sub

    Public Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        'btnTambah.Enabled = True
        'btnSimpan.Enabled = True
        'btnHapus.Enabled = True
        enableInput()
    End Sub

    Public Sub hapusDataMember()
        Dim hapussql As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data pada server .. " + txtNamaMember.Text, vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        hapussql = "Call deleteMember('" & txtIDMember.Text & "')"
        insertData(hapussql)
        Me.Cursor = Cursors.WaitCursor
        DataGridView1.Refresh()
        tampilkanData()
        Me.Cursor = Cursors.Default
        'btnBatal.PerformClick()
    End Sub

    Public Sub batal()
        clearData()
        disableInput()
        'btnSimpan.Enabled = False
        'btnHapus.Enabled = False
    End Sub

    Private Sub txtNamaMember_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaMember.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("hanya boleh karakter")
        End If

        If Len(txtNamaMember.Text) > 49 And Not (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("karakter melebihi batas")
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            MsgBox("Hanya Boleh Angka")
            e.Handled = True
        End If

        If Len(txtTelepon.Text) > 19 And Not (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("karakter melebihi batas")
        End If


    End Sub

    Private Sub txtIDMember_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDMember.KeyPress
        If Len(txtIDMember.Text) > 10 And Not (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("karakter melebihi batas")
        End If
    End Sub

    Private Sub txtAlamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlamat.KeyPress
        If Len(txtAlamat.Text) > 49 And Not (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("karakter melebihi batas")
        End If
    End Sub


    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If Len(txtEmail.Text) > 99 And Not (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("karakter melebihi batas")
        End If
    End Sub
End Class
