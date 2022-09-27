Module Ejercicio14
    Sub main()
        'Diseñar un programa que calcule la rebaja realizada sobre un determinado producto a partir del precio inicial y el porcentaje de descuento.
        'El programa debe mostrar un mensaje informando: 
        '“Al aplicar un … por ciento de descuento el precio final del producto es de precio final y por lo tanto se ahorra … euros.”
        Dim rebaja, precioInicial, porcentaje, preciofinal As Double
        precioInicial = Convert.ToDouble(InputBox("cuál es el precio inicial?"))
        porcentaje = Convert.ToDouble(InputBox("Cuál es el porcentaje del descuento? "))
        rebaja = precioInicial - (porcentaje * precioInicial) / 100
        preciofinal = precioInicial - rebaja
        Console.WriteLine("Al aplicar un " & porcentaje & " por ciento de descuento el precio final del producto es de " & preciofinal & " y por lo tanto se ahorra" & rebaja & "euros.")
        Console.ReadLine()
    End Sub
End Module
