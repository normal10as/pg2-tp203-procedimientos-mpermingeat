Imports Microsoft.VisualBasic
Imports System

Module ejer301

    Sub Main()
        Call Fecha()
        Console.WriteLine("La hora es: " & Hora())

    End Sub
    Sub Fecha()
        Dim x As Date = Now
        Console.WriteLine("La fecha de hoy es: " & x.Date)
    End Sub
    Function Hora()
        Dim x As Date = Now
        Dim y As String
        y = x.Hour & ":" & x.Minute

        Return y
    End Function
End Module
