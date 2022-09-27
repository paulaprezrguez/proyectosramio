Module Ejercicio6
    Sub main()
        'Realizar un programa que solicite al usuario dos números
        Console.WriteLine("Ingrese un número")
        Dim n1 As Integer
        n1 = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Ingrese otro número")
        Dim n2 As Integer
        n2 = Convert.ToInt32(Console.ReadLine())
        'calcule guardándolo en SENDAS VARIABLES: la SUMA, la RESTA , y la MULTIPLICACIÓN de esos dos números
        Dim suma, resta, multiplicacion As Integer
        suma = n1 + n2
        resta = n1 - n2
        multiplicacion = n1 * n2

        'muestre por pantalla los resultados con mensajes como:
        '“La suma es “ , suma.
        Console.WriteLine("La suma es " & suma)
        '“La resta es “, resta.
        Console.WriteLine("La resta es " & resta)
        '“La multiplicación es “, multiplicación.
        Console.WriteLine("La multiplicación es " & multiplicacion)
        Console.ReadLine()
    End Sub
End Module
