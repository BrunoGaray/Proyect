Public Class Invitaciones
    Dim _codigo As Integer
    Dim _ubicacion As String
    Dim _nombreEmpresa As String
    Dim _puesto As String
    Dim _confirmacion As Boolean

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Ubicacion As String
        Get
            Return _ubicacion
        End Get
        Set(value As String)
            _ubicacion = value
        End Set
    End Property

    Public Property NombreEmpresa As String
        Get
            Return _nombreEmpresa
        End Get
        Set(value As String)
            _nombreEmpresa = value
        End Set
    End Property

    Public Property Puesto As String
        Get
            Return _puesto
        End Get
        Set(value As String)
            _puesto = value
        End Set
    End Property

    Public Property Confirmacion As Boolean
        Get
            Return _confirmacion
        End Get
        Set(value As Boolean)
            _confirmacion = value
        End Set
    End Property

    'Constructor'
    Sub New(cod As Integer, Ubic As String, nom As String, psto As String, confirm As Boolean)
        Codigo = cod
        Ubicacion = Ubic
        NombreEmpresa = nom
        Puesto = psto
        Confirmacion = confirm
    End Sub
End Class
