Module Ejercicio7
    Sub main()
        ' Una temperatura dada en grados Celsius (centígrados) puede ser convertida a
        'una temperatura equivalente Fahrenheit de acuerdo a la siguiente fórmula 
        'f = (9 / 5) * C + 32
        'Escribir un programa que lea la temperatura en grados centígrados y la convierta en grados Fahrenheit.
        Dim celsius As String
        Dim faharenheit As String
        Console.WriteLine("Ingrese el número de grados centígrados")
        celsius = Console.ReadLine()
        faharenheit = Convert.ToString((9 / 5) * Convert.ToDouble(celsius) + 32)
        Console.WriteLine("La temperatura de " & celsius & " es de " & faharenheit & " grados Fahrenheit.")
        Console.ReadLine()
    End Sub
End Module
