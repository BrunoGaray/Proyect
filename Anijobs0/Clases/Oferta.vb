Public Class Oferta
    Dim _numSerie As Integer
    Dim _puesto As String
    Dim _descripcion As String
    Dim _disponibilidad As String
    Dim _requisitos As String
    Dim _sueldo As Integer
    Dim _area As String
    Dim _edadRequerida As String

    Public Property NumSerie As Integer
        Get
            Return _numSerie
        End Get
        Set(value As Integer)
            _numSerie = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Disponibilidad As String
        Get
            Return _disponibilidad
        End Get
        Set(value As String)
            _disponibilidad = value
        End Set
    End Property

    Public Property Requisitos As String
        Get
            Return _requisitos
        End Get
        Set(value As String)
            _requisitos = value
        End Set
    End Property

    Public Property Sueldo As Integer
        Get
            Return _sueldo
        End Get
        Set(value As Integer)
            _sueldo = value
        End Set
    End Property

    Public Property Area As String
        Get
            Return _area
        End Get
        Set(value As String)
            _area = value
        End Set
    End Property

    Public Property EdadRequerida As String
        Get
            Return _edadRequerida
        End Get
        Set(value As String)
            _edadRequerida = value
        End Set
    End Property

    'Constructor'
    Sub New(nserie As Integer, psto As String, desc As String, disp As String, req As String, sdo As Integer, ara As String, edad As String)
        NumSerie = nserie
        Puesto = psto
        Descripcion = desc
        Disponibilidad = disp
        Requisitos = req
        Sueldo = sdo
        Area = ara
        EdadRequerida = edad
    End Sub
End Class
