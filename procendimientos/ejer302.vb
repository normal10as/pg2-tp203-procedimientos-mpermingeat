Imports Microsoft.VisualBasic
Imports System


Module ejer302
    Sub Main()
        Dim fecha As Date
        Dim sumardias As Double
        Dim dia As Int16
        Dim mes As Int16
        Dim anio As Int16

        Console.WriteLine("Ingrese dia (dd)")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese mes (mm)")
        mes = Console.ReadLine()
        Console.WriteLine("Ingrese año (yyy)")
        anio = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar")
        sumardias = Console.ReadLine()
        fecha = New Date(anio, mes, dia)

        Console.WriteLine("Fecha final: {0}", SumarFecha(fecha, sumardias))
    End Sub
    Public Function SumarFecha(a As Date, b As Double) As Date
        a = a.AddDays(b)
        Return a
    End Function
End Module
