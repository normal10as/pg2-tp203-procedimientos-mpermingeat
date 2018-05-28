Imports Microsoft.VisualBasic
Imports System
'El volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v = πr²h.
'Elaborar una función que lea el radio de la base y la altura de un cilindro, que calcule y
'devuelva el volumen. Ingresar los valores por teclado y mostrar el resultado en consola. Utilizar
'un procedimiento para validar los valores ingresados sean positivos, si no cumple esta condición
'pedir el reingreso del dato
Module ejer305
    Sub Main()
        Dim a As Decimal
        Dim b As Decimal

        Do
            Console.WriteLine("Ingrese la altura")
            a = Console.ReadLine
            Console.WriteLine("Ingrese el radio de la base")
            b = Console.ReadLine

        Loop While Verificacion(a, b) > 0
        Console.WriteLine("El valor de la Hipotenusa es {0}", Volumen(a, b))
    End Sub

    Private Function Verificacion(ByVal a As Decimal, ByVal b As Decimal)
        If a < 0 Or b < 0 Then
            Console.WriteLine("Uno de los valores no es positivo, introdusca un nuevo valor")
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Function Volumen(ByRef a As Decimal, ByRef b As Decimal)
        Dim c As Decimal
        Const pi = 3.14159265
        c = a * b * pi
        Return c
    End Function

End Module
