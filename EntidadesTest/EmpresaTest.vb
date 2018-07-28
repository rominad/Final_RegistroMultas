Imports RegistroMultas
Module EmpresaTest
    Sub main()
        Try
            Dim empresa1 As New Empresa("Empresa1", 1212323)
            Console.WriteLine(empresa1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim empresa2 As New Empresa("", -2334)
            Console.WriteLine(empresa2.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
