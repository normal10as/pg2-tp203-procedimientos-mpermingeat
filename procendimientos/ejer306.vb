Imports Microsoft.VisualBasic
Imports System
'Elaborar un algoritmo que lea un número N, que imprima la sumatoria de los cuadrados de los
'enteros entre 1 y N. Utilizar un método para el cálculo de la sumatoria vía parámetro por
'referencia.Utilizar un método para validar los valores ingresados sean enteros positivos, si no
'cumple esta condición pedir el reingreso del dato
Module ejer306
    Sub Main()
        Dim numero As Decimal
        Console.WriteLine("Ingrese un numero:")
        Do
            numero = Console.ReadLine
        Loop While Verificacion(numero) > 0
        Console.WriteLine("La sumatoria de los cuadrados es {0}", SumatoriaFun(numero))
    End Sub

    Private Function Verificacion(ByVal a As Decimal)
        If a Mod 1 = 0 And a > 0 Then
            Return 0
        Else
            Console.WriteLine("El valor no es un entero positivo, introdusca un nuevo valor")
            Return 1
        End If
    End Function

    Private Function SumatoriaFun(ByRef a As Integer)
        Dim b As Integer
        For x = 1 To a
            b = b + x ^ 2
        Next
        Return b
    End Function
End Module
