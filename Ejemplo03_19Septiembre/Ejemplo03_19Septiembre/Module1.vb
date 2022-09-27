Module Module1

    Sub Main()
        'Programa que calcula el precio final de una vivienda, teniendo en cuenta
        'los siguientes impuestos:
        ' La inmobiliaria se lleva el 3% del precio Inicial
        ' El ayuntamiento el 9% del precio inicial: impuesto Transf Patrimonio
        Dim PrecioInicial, PrecioFinal, impuestoInmobiliaria, impuestoAyuntamiento As Single
        'Entrada
        PrecioInicial = 500000
        'Cálculos
        impuestoInmobiliaria = PrecioInicial * 0.03
        impuestoAyuntamiento = PrecioInicial * 0.09
        PrecioFinal = PrecioInicial + impuestoAyuntamiento + impuestoInmobiliaria
        'Salida por pantalla
        Console.WriteLine("El precio inicial es " & PrecioInicial & " euros")
        Console.WriteLine("Cuota inmobiliaria " & impuestoInmobiliaria & " euros")
        Console.WriteLine("Impuesto Ayuntamiento " & impuestoAyuntamiento & " euros")
        Console.WriteLine("El precio final es " & PrecioFinal & " euros")
        Console.ReadLine()
    End Sub

End Module
