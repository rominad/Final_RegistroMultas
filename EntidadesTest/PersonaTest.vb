Imports RegistroMultas
Module PersonaTest
    Sub main()
        Try
            Dim persona1 As New Persona("paola", 38021661)
            Console.WriteLine(persona1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim persona2 As New Persona("", -32322233)
            Console.WriteLine(persona2.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
