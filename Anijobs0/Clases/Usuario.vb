Public Class Usuario
    Private _nombre As String
    Private _apellido As String
    Private _contraseña As String
    Private _mail As String
    Private _telefono As Integer
    Private _fechaNac As Date

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Mail As String
        Get
            Return _mail
        End Get
        Set(value As String)
            _mail = value
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

    Public Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            _fechaNac = value
        End Set
    End Property

    'Constructor
    Sub New(nom As String, apell As String, contra As String, correo As String, tel As Integer, nac As Date)
        Nombre = nom
        Apellido = apell
        Contraseña = contra
        Mail = correo
        Telefono = tel
        FechaNac = nac
    End Sub
End Class
