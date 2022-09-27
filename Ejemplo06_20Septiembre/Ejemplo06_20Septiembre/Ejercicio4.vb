Module Ejercicio4

    Sub Main()
        'El programa debe solicitar al usuario que ingrese un número. Este número es recogido en una variable de tipo Double llamada radio.
        Console.WriteLine("Ingrese un número ")
        Dim radio As Double
        radio = Convert.ToDouble(Console.ReadLine()) 'Devuelve un string, por eso se convierte
        'A continuación se debe calcular en sendas variables, la longitud del círculo, el área y el volumen de la esfera.
        Dim longitud, area, volumen As Double
        Const PI As Double = Math.PI
        'Para ello haced uso de una constante de tipo double denominada PI cuyo valor es 3.141516.
        'Longitud = 2 * PI * radio.
        'Area = PI * radio2
        'Volumen = (4 / 3) * PI * radio3
        longitud = 2 * PI * radio
        area = PI * Math.Pow(radio, 2)
        volumen = (4 / 3) * PI * radio
        'El programa debe mostrar estos resultados por pantalla.
        Console.WriteLine("La longitud del círculo es de " & longitud & " m")
        Console.WriteLine("El area del círculo es de " & area & " m2")
        Console.WriteLine("El volumen del círculo es de " & volumen & " m3")
        Console.ReadLine()
    End Sub

End Module
