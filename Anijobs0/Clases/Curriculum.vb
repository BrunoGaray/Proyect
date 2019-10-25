Public Class Curriculum
    Dim _identificador As Integer
    Dim _referencias As String
    Dim _experiencia As String
    Dim _educacion As String
    Dim _idiomas As String
    Dim _nombre As String
    Dim _apellido As String
    Dim _mailCandidato As String

    Public Property Identificador As Integer
        Get
            Return _identificador
        End Get
        Set(value As Integer)
            _identificador = value
        End Set
    End Property

    Public Property Referencias As String
        Get
            Return _referencias
        End Get
        Set(value As String)
            _referencias = value
        End Set
    End Property

    Public Property Experiencia As String
        Get
            Return _experiencia
        End Get
        Set(value As String)
            _experiencia = value
        End Set
    End Property

    Public Property Educacion As String
        Get
            Return _educacion
        End Get
        Set(value As String)
            _educacion = value
        End Set
    End Property

    Public Property Idiomas As String
        Get
            Return _idiomas
        End Get
        Set(value As String)
            _idiomas = value
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

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property MailCandidato As String
        Get
            Return _mailCandidato
        End Get
        Set(value As String)
            _mailCandidato = value
        End Set
    End Property

    'Constructor'
    Sub New(id As Integer, ref As String, exp As String, edu As String, idms As String, nom As String, apell As String, mail As String)
        Identificador = id
        Referencias = ref
        Experiencia = exp
        Educacion = edu
        Idiomas = idms
        Nombre = Nombre
        Apellido = apell
        MailCandidato = mail
    End Sub
End Class
