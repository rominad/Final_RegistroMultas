Public Class Multa
    Private _fecha As Date
    Private _latitud As Decimal
    Private _longitud As Decimal
    Private _unidades As UShort
    Private _MontoUnidad As Decimal
    Private _vehiculo As Vehiculo
    Private _registro As Registro
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            'If value > Today Then
            '    Throw New ArgumentException("La fecha no debe ser superior a la fecha actual!")
            'End If
            _fecha = value
        End Set
    End Property
    Public Property Latitud As Decimal
        Get
            Return _latitud
        End Get
        Set(value As Decimal)
            If value < -90 And value > 90 Then
                Throw New Exception("Latitud no puede ser menor a  -90 o mayor a 90!!")
            End If
            _latitud = value
        End Set
    End Property
    Public Property Longitud As Decimal
        Get
            Return _longitud
        End Get
        Set(value As Decimal)
            If value < -180 And value > 180 Then
                Throw New Exception("Longitud no puede ser menor a  -90 o mayor a 90!!")
            End If
            _longitud = value
        End Set
    End Property
    Public Property Unidades As UShort
        Get
            Return _unidades
        End Get
        Set(value As UShort)
            If value < 0 Then
                Throw New Exception("Unidades no puede ser menor a cero!!")
            End If
            _unidades = value

        End Set
    End Property
    Public Property MontoUnidad As Decimal
        Get
            Return _MontoUnidad
        End Get
        Set(value As Decimal)
            If value < 0 Then
                Throw New Exception("MontoUnidad no puede ser menor a cero!!")
            End If
            _MontoUnidad = value
        End Set
    End Property
    Public Property Vehiculo As Vehiculo
        Get
            Return _vehiculo
        End Get
        Friend Set(value As Vehiculo)
            Vehiculo.AddMulta(Me)
            _vehiculo = value
        End Set
    End Property
    Public Property Registro As Registro
        Get
            Return _registro
        End Get
        Set(value As Registro)
            _registro = value
        End Set
    End Property
    Public Function CalcularMonto() As Decimal
        Return MontoUnidad
    End Function
    Sub New(vehiculo As Vehiculo, fecha As Date, latitud As Decimal, longitud As Decimal, unidades As UShort)
        Me.Vehiculo = vehiculo
        Me.Fecha = fecha
        Me.Latitud = latitud
        Me.Longitud = longitud
        Me.Unidades = unidades

    End Sub
    Public Overrides Function ToString() As String
        Return Vehiculo.ToString() + " - " + Fecha
    End Function
End Class
