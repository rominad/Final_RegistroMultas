
Public MustInherit Class Propietario
    Implements iMultado

    Private _nombre As String
    Private _vehiculos As List(Of Vehiculo)
    'Private _multas As List(Of Multa)
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value = "" Then
                Throw New Exception("El nombre no puede estar vacio!!")
            End If
            _nombre = value
        End Set
    End Property

    Friend Sub AddVehiculo(value As Vehiculo)
        _vehiculos.Add(value)
    End Sub
    Friend Sub RemoveVehiculo(value As Vehiculo)
        _vehiculos.Remove(value)
    End Sub
    Public Function GetAllVehiculos() As List(Of Vehiculo)
        Return _vehiculos
    End Function
    Public Function GetAllMultas() As List(Of Multa) Implements iMultado.GetAllMultas
        Dim lista As New List(Of Multa)
        For Each vehiculo In _vehiculos
            For Each multa In vehiculo.GetAllMultas()
                lista.Add(multa)
            Next
        Next
        Return lista
    End Function

    Public Function GetTotalMultas() As Decimal Implements iMultado.GetTotalMultas
        Dim total As Decimal
        For Each multa In GetAllMultas()
            total += multa.CalcularMonto()
        Next
        Return total
    End Function
    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
