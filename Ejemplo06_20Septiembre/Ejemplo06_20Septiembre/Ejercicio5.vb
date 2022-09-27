Module Ejercicio5
    Sub Main()
        'Diseñar un programa que pide al usuario que introduzca el precio (variable Double) y la cantidad (variable Short) de un determinado producto.
        Dim precio As Double
        Dim cantidad As Short
        Console.WriteLine("Escriba el precio del producto ")
        precio = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Escriba la cantidad de productos ")
        cantidad = Convert.ToInt16(Console.ReadLine())
        'A continuación calcula el importe final que será precio*cantidad y muestra por pantalla el siguiente mensaje:
        '“El precio del producto es x euros y la cantidad que compra es y por lo tanto debe pagar z euros. Vuelva pronto.”
        Dim importeFinal As Double
        importeFinal = precio * cantidad
        Console.WriteLine("El precio del producto es " & precio & " euros y la cantidad que compra es " & cantidad & " por lo tanto debe pagar " & importeFinal & " euros. Vuelva pronto.")
        Console.ReadLine()
    End Sub
End Module
