Module Module1

    Sub Main()
        Dim valores(9) As Integer

        For i = 0 To 9 Step 1
            Console.WriteLine("Ingrese un valor: " & i + 1 & " :")
            valores(i) = Console.ReadLine()

        Next
        Console.WriteLine("")
        Console.WriteLine(" Valores ordenados de forma ascendente: ")
        Console.WriteLine("")
        Array.Sort(valores)
        For Each order As Integer In valores
            Console.WriteLine(order)
            Console.WriteLine("")

        Next

        Console.ReadLine()



    End Sub

End Module
