Module Ejercicio8
    Sub Main()
        Dim p, v, n, T As Double
        Const R As Double = 0.082
        v = Convert.ToDouble(InputBox("Da un valor al volumen: "))
        n = Convert.ToDouble(InputBox("Da un número de moles: "))
        T = Convert.ToDouble(InputBox("Da un valor a la temperatura en grados kelvin: "))
        p = (n * R * T) / v
        Console.WriteLine("Con un volumen de " & v & " litros, y una temperatura de " & T & " kelvin, " & n & " de moles de un gas ideal tienen una presión de " & p & " atmósferas.")
        Console.ReadLine()
    End Sub
End Module
