Public Class GestorEmpresa
    Inherits Usuario
    Dim _empresa As Empresa


    Public Property Empresa As Empresa
        Get
            Return _empresa
        End Get
        Set(value As Empresa)
            _empresa = value
        End Set
    End Property

    'Constructor
    Sub New(nom As String, apell As String, cont As String, correo As String, tel As Integer, emp As Empresa, nac As Date)
        MyBase.New(nom, apell, cont, correo, tel, nac)
        Empresa = emp
    End Sub
End Class
