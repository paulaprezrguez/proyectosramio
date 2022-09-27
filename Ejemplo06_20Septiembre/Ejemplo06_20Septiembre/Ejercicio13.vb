Module Ejercicio13
    Sub main()
        Dim a, b, h As Single
        a = Convert.ToSingle(InputBox("Dame un cateto del triángulo."))
        b = Convert.ToSingle(InputBox("Dame el otro cateto del triángulo. "))
        h = Convert.ToSingle(Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2))))
        Console.WriteLine("La hipotenusa es " & h & ". ")
        Console.ReadLine()
    End Sub
End Module
