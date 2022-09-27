Module Ejercicio11
    Sub Main()
        Dim espacio, tiempo, velocidad As Double
        Console.WriteLine("Dime un valor para espacio: ")
        espacio = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Dime un valor para los segundos: ")
        tiempo = Convert.ToDouble(Console.ReadLine())
        velocidad = espacio / tiempo
        Console.WriteLine("La velocidad es de: " & velocidad & "metros/segundo.")
        Console.ReadLine()
    End Sub
End Module
