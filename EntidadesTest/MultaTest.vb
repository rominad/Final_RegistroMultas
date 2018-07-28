Imports RegistroMultas
Module MultaTest
    Sub main()
        Dim vehiculo1 As New Vehiculo("patente123")
        Try
            Dim multa1 As New Multa(vehiculo1, Today, 200, 100, 12)
            Console.WriteLine(multa1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim multa2 As New Multa(vehiculo1, Today, 200, 100, 12)
            Console.WriteLine(multa2.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
