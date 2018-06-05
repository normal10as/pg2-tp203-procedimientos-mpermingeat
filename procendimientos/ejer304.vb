Imports Microsoft.VisualBasic
Imports System
'Dados los lados A y B de un triángulo rectángulo, según el teorema de Pitágoras, el cuadrado de
'la hipotenusa(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la
'siguiente fórmula : c² = a² + b². Elaborar una función que reciba el tamaño de los lados A y B,
'calcule y devuelva C (hipotenusa). Ingresar los valores por teclado y mostrar el resultado en
'consola.Utilizar una función para validar los valores ingresados sean enteros positivos, si no
'cumple esta condición pedir el reingreso del dato
Module ejer304
    Sub Main()
        Dim a As Decimal
        Dim b As Decimal
        Do
            Console.WriteLine("Ingrese lado A")
            a = Console.ReadLine
            Console.WriteLine("Ingrese lado B")
            b = Console.ReadLine
        Loop While Verificacion(a, b) > 0
        Console.WriteLine("El valor de la Hipotenusa es {0}", Pitagora(a, b))
    End Sub

    Private Function Verificacion(ByVal a As Decimal, ByVal b As Decimal)
        If a Mod 1 > 0 Or b Mod 1 > 0 Then
            Console.WriteLine("Uno de los valores no es entero, introdusca un nuevo valor")
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Function Pitagora(ByRef a As Int16, ByRef b As Int16)
        Dim c As Decimal
        c = Math.Sqrt(a ^ 2 + b ^ 2)
        Return c
    End Function
End Module