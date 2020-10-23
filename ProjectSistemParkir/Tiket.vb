Public Class Tiket
    Dim _jamMsk, _jamKlr As DateTime
    Dim _id, _noparkir, _notransaksi As String
    Dim _totalBiaya As Integer

    Public Sub New(ByVal jmMsk As DateTime, ByVal jmKlr As DateTime, ByVal tot As Integer, ByVal id As String, ByVal noparkir As String)
        _jamMsk = jmMsk
        _jamKlr = jmKlr
        _totalBiaya = tot
        _id = id
        _noparkir = noparkir
    End Sub

    Public Sub New(ByVal notrans As String, ByVal jmMsk As DateTime, ByVal jmKlr As DateTime, ByVal tot As Integer, ByVal id As String, ByVal noparkir As String)
        _notransaksi = notrans
        _jamMsk = jmMsk
        _jamKlr = jmKlr
        _totalBiaya = tot
        _id = id
        _noparkir = noparkir
    End Sub

    Public Property jamMsk() As DateTime
        Get
            Return _jamMsk
        End Get
        Set(ByVal value As DateTime)
            _jamMsk = value
        End Set
    End Property

    Public Property jamKlr() As DateTime
        Get
            Return _jamKlr
        End Get
        Set(ByVal value As DateTime)
            _jamKlr = value
        End Set
    End Property

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property noparkir() As String
        Get
            Return _noparkir
        End Get
        Set(ByVal value As String)
            _noparkir = value
        End Set
    End Property

    Public Property totalbiaya() As Integer
        Get
            Return _totalBiaya
        End Get
        Set(ByVal value As Integer)
            _totalBiaya = value
        End Set
    End Property

    Public Property notransaksi() As String
        Get
            Return _notransaksi
        End Get
        Set(ByVal value As String)
            _notransaksi = value
        End Set
    End Property

End Class
