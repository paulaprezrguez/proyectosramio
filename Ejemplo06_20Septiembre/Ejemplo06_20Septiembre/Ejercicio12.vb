Module Ejercicio12
    Sub main()
        Dim lado, perimetro, diagonal, area As Double
        Dim raiz As Double = Math.Sqrt(2)
        lado = Convert.ToDouble(InputBox("Dime el tamaño del lado: "))
        perimetro = 4 * lado
        diagonal = Math.Round(lado * raiz, 2)
        area = Math.Pow(lado, 2)
        Console.WriteLine("El área del cuadrado mide:" & area & ".")
        Console.ReadLine()
        Console.WriteLine("El perímetro del cuadrado mide: " & perimetro & ".")
        Console.ReadLine()
        Console.WriteLine("La diagonal del cuadrado mide: " & diagonal & ".")
        Console.ReadLine()

    End Sub
End Module
