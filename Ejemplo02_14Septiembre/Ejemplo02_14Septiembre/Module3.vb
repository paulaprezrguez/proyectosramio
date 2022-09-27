Module Module3
    Sub Main()
        'Zona de declaración de variables
        Dim precioInicial, rebaja, precioFinal As Single
        'Entrada: Leer precioInicial
        precioInicial = 30
        rebaja = precioInicial * 0.15
        'Proceso: precioFinal=precioInicial*0.15
        precioFinal = precioInicial * 0.15 - precioInicial
        'Salida: Escribir...
        Console.WriteLine("La rebaja es de " & rebaja)
        Console.WriteLine("El precio final es " & precioFinal)
        'Mostrar consola hasta que el usuario pulse Enter
        Console.ReadLine()
    End Sub
End Module
