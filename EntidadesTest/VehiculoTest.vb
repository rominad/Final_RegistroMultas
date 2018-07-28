Imports RegistroMultas
Module VehiculoTest
    Sub main()
        Try
            Dim vehiculo1 As New Vehiculo("patente")
            Console.WriteLine(vehiculo1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim vehiculo2 As New Vehiculo("")
            Console.WriteLine(vehiculo2.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
