Public NotInheritable Class Empresa
    Inherits Propietario
    Private _cuit As String
    Public Property CUIT As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value = "" Then
                Throw New Exception("El cuit no puede estar vacio!!")
            End If
            _cuit = value
        End Set
    End Property
    Sub New(nombre As String, dni As Integer)
        MyBase.New(nombre)
        Me.CUIT = dni
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.Nombre + " ( " + CUIT + " ) "
    End Function

End Class
