Public Class Member
    Dim _id, _nama, _alamat, _telepon, _email As String
    Dim _wallet As Integer

    Public Sub New(ByVal id As String, ByVal nama As String, ByVal alamat As String, ByVal telepon As String, ByVal wallet As Integer, ByVal email As String)
        _id = id
        _nama = nama
        _alamat = alamat
        _telepon = telepon
        _wallet = wallet
        _email = email
    End Sub

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property nama() As String
        Get
            Return _nama
        End Get
        Set(ByVal value As String)
            _nama = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return _alamat
        End Get
        Set(ByVal value As String)
            _alamat = value
        End Set
    End Property

    Public Property telepon() As String
        Get
            Return _telepon
        End Get
        Set(ByVal value As String)
            _telepon = value
        End Set
    End Property

    Public Property wallet() As Integer
        Get
            Return _wallet
        End Get
        Set(ByVal value As Integer)
            _wallet = value
        End Set
    End Property


    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
End Class
