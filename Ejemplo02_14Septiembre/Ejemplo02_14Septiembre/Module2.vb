Module CalculoMedia
    Sub Main()
        'Zona declaración de variables
        Dim n1, n2, n3 As Integer
        Dim media As Single

        'Entrada: Leer n1,n2,n3
        n1 = 2
        n2 = 5
        n3 = 4

        'Proceso:(n1+n2+n3)/3
        media = (n1 + n2 + n3) / 3

        'Salida: Escribir...
        Console.WriteLine("Tienes una media de " & media)

        'Mostrar consola hasta que el usuario pulse Enter
        Console.ReadLine()
    End Sub
End Module
