Public Class Persona
    Inherits Propietario
    Private _dni As Integer
    Public Property DNI As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New Exception("El dni no puede ser menor a cero!!")
            End If
            _dni = value
        End Set
    End Property
    Sub New(nombre As String, dni As Integer)
        MyBase.New(nombre)
        Me.DNI = dni
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.Nombre + " ( " + DNI + " ) "
    End Function
End Class
