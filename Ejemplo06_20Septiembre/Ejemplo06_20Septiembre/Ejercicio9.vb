Module Ejercicio9
    Sub main()
        'Escribir un programa que permita intercambiar los contenidos de dos variables x e y de un cierto tipo de datos.
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Console.WriteLine("Ingresa 1 número")
        x = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Ingresa otro número")
        y = Convert.ToInt32(Console.ReadLine())
        z = x
        x = y
        y = z
        Console.WriteLine("El valor de x es " & x)
        Console.WriteLine("El valor de y es " & y)
        Console.ReadLine()
    End Sub
End Module
