
Public Class Vehiculo
    Implements iMultado
    Private _patente As String
    Private _multas As List(Of Multa)
    Private _propietario As Propietario
    Public Property Patente As String
        Get
            Return _patente
        End Get
        Set(value As String)
            If value.Length > 8 Then
                Throw New Exception("Patente no debe tener mas de 8 caracteres!!")
            End If
            If value.Length < 6 Then
                Throw New Exception("Patente no debe tener menos de 6 caracteres!!")
            End If
            _patente = value
        End Set
    End Property
    Public Property Propietario As Propietario
        Get
            Return _propietario
        End Get
        Friend Set(value As Propietario)
            Propietario.AddVehiculo(Me)
            _propietario = value
        End Set
    End Property
    Friend Sub AddMulta(value As Multa)
        _multas.Add(value)
    End Sub
    Public Function GetAllMultas() As List(Of Multa) Implements iMultado.GetAllMultas
        Return _multas
    End Function

    Public Function GetTotalMultas() As Decimal Implements iMultado.GetTotalMultas
        Dim total As Decimal
        For Each multa In _multas
            total += multa.MontoUnidad
        Next
        Return total
    End Function
    Sub New(patente As String)
        Me.Patente = patente
        _multas = New List(Of Multa)
        Me.Propietario = Nothing
    End Sub
    Public Overrides Function ToString() As String
        Return Patente & " - " & Propietario.ToString()

    End Function


End Class
