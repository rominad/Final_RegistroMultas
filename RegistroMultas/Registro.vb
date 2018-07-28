Public Class Registro
    Private _multas As List(Of Multa)
    Private _propietarios As List(Of Propietario)
    Private _persona As List(Of Persona)
    Public Shared Function GetMultasByMultado(value As iMultado) As List(Of Multa)
        Return value.GetAllMultas()
    End Function
    Public Shared Function getAllPropietariosMultados() As List(Of Propietario)
        Dim lista As New List(Of Propietario)
        'crear segunda lista de propitarios y cuando se hace el add multa ... tomo el propietario de y agrego el propietario
        Return lista
    End Function

    'Public Shared Function getPersonaByDNI(dni As UInteger) As Persona
    '    For Each multa In _multas
    '        For Each pesona In multa.vehiculo.propietario

    '        Next
    '    Next
    '    For Each persona In _multas.Vehiculo.propietario.persona
    '        If persona.dni = dni Then
    '            Return persona
    '        End If
    '    Next
    ' haces una lista de personas, type of persona = agrego a la lista. o persona.faind(persona.id) y retorna un objeto. agregar 
    'excepcion
    Private Shared Function addMulta(value As Multa) As List(Of Multa)
        'Return _multas.Add(value)
    End Function


End Class
