Module Module1

    Sub Main()
        'Cambiar propiedades de la consola
        Console.Title = "Mi segundo programa"
        'Cambiar color de texto
        Console.ForegroundColor = ConsoleColor.White
        'Cambiar el color de fondo del texto
        Console.BackgroundColor = ConsoleColor.Red
        'Quitar el fondo del texto
        Console.BackgroundColor = Nothing


        Console.WriteLine("Me lo paso genial en clase de AO")
        'Mantener la consola abierta hasta que el usuario pulse Enter
        Console.Beep()
        Console.ReadLine()
    End Sub

End Module
