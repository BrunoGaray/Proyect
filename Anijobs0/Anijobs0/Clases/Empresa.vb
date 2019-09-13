Public Class Empresa
    Dim _nombre As String
    Dim _direccion As String
    Dim _rubro As String
    Dim _ID As Integer
    Dim _ciudad As String
    Dim _telefono As Integer

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Rubro As String
        Get
            Return _rubro
        End Get
        Set(value As String)
            _rubro = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _ciudad
        End Get
        Set(value As String)
            _ciudad = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    'Constructor'
    Sub New(nomEmp As String, Telefo As Integer, direc As String, rubroEmp As String, IdEmp As Integer, ciud As String)
        Nombre = nomEmp
        Telefono = Telefo
        Direccion = direc
        Rubro = rubroEmp
        ID = IdEmp
        Ciudad = ciud
    End Sub
End Class
