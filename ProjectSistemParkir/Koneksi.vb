Imports MySql.Data.MySqlClient
Public Class Koneksi

    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim conns As MySqlConnection
    Dim strKoneksi As String = "Server=localhost; user id=root; password=; database=sistem_parkir;"
    'Dim strKoneksi As String = "Data Source =//192.168.43.188,3306; Initial Catalog = sistem_parkir; user id=meh; password=meh;"
    Private conn As New MySqlConnection

    Public Sub bukaKoneksi()
        Dim constr As String
        constr = "Server=localhost; user id=root; password=; database=sistem_parkir; Convert Zero Datetime=True;"
        'constr = "Data Source =//192.168.43.188,3306; Initial Catalog = sistem_parkir; user id=meh; password=meh;"
        conn = New MySqlConnection(constr)
        conn.Open()
    End Sub

    Public Sub tutupKoneksi()
        conn.Close()
    End Sub

    Public Function getConn() As MySqlConnection
        Return conn
    End Function

    'Public Sub getDataMember()
    '    Dim con As MySqlConnection = New MySqlConnection("Server=localhost; user id=root; password=; database=sistem_parkir;")
    '    Dim cmd As MySqlCommand = New MySqlCommand("SELECT nama FROM member", con)
    '    Dim rec As MySqlDataReader = cmd.ExecuteReader()

    '    While rec.Read
    '        FormMasuk.TextBox2.Text = rec.Item("NamaMember")
    '    End While
    'End Sub

    'Public Function getData(ByVal getParamNoPolisi As String)
    '    Dim getData1 As String

    '    getData1 = ""

    '    conns = New MySqlConnection(strKoneksi)

    '    Try
    '        conns.Open()
    '        cmd = New MySqlCommand("SELECT j.tarif FROM Jenis_Mobil j join Mobil m ON (j.ID_Jenis = m.ID_Jenis) where No_Polisi = '" & getParamNoPolisi & "'", conns)
    '        dr = cmd.ExecuteReader()
    '        dr.Read()

    '        If dr.HasRows Then
    '            getData1 = dr.Item("tarif")
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try

    '    dr.Close()
    '    conns.Close()

    '    Return getData1
    'End Function
End Class
