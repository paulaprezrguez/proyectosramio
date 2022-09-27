Module Ejercicio10
    Sub main()
        Dim horas, salariobruto, salarioneto, dinerodia, IRPF, Dias, tasahora As Double
        Console.WriteLine("Vamos a calcular los salario neto y bruto de un trabajador")
        Console.ReadLine()
        Console.WriteLine("El número de horas trabajadas por día: ")
        horas = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Inserte los días que va a trabajar al mes: ")
        Dias = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Inserte la cantidad de dinero que gana por hora: ")
        tasahora = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Cuánto es el IRPF?")
        IRPF = Convert.ToDouble(Console.ReadLine())
        dinerodia = tasahora * horas
        salariobruto = dinerodia * Dias
        salarioneto = salariobruto - (IRPF * salariobruto) / 100
        Console.WriteLine("El salario bruto de la persona que trabaja es de: " & salariobruto & " euros")
        Console.ReadLine()
        Console.WriteLine("El salario neto de la persona que trabaja es de: " & salarioneto & " euros")
        Console.ReadLine()
    End Sub
End Module
