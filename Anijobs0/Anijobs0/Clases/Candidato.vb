Public Class Candidato
    Inherits Usuario
    Private _ci As Integer
    Private _direccion As String
    Private _rubro As String
    Private _ciudad As String
    Private _sexo As Boolean

    Public Property CI As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
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

    Public Property Sexo As Boolean
        Get
            Return _sexo
        End Get
        Set(value As Boolean)
            _sexo = value
        End Set
    End Property



    'Constructor
    Sub New(nom As String, apell As String, cont As String, correo As String, tel As Integer, cedula As Integer, dir As String, rub As String, ciu As String, sex As Boolean, nac As Date)
        MyBase.New(nom, apell, cont, correo, tel, nac)
        CI = cedula
        Direccion = dir
        Rubro = rub
        Ciudad = ciu
        Sexo = sex
    End Sub
End Class
