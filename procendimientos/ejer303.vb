Imports Microsoft.VisualBasic
Imports System

'Mostrar las 5 primeras potencias de un valor numérico ingresado por teclado del mismo.
'Implementar una función que retornará una potencia cada vez que se invoque, la primera vez el
'exponente será 2, la segunda vez 3 y así sucesivamente.



Module ejer303
    Sub Main()
        Dim numero As Int16
        Dim exponente As Int16
        Dim resultado As Int16
        Console.WriteLine("Ingrese un numero: ")
        numero = Console.ReadLine
        For index = 1 To 5
            exponente = index + 1
            resultado = Potencia(numero, exponente)
            Console.WriteLine(resultado)
        Next
    End Sub
    Private Function Potencia(ByVal a As Int16, ByVal b As Int16) As Int16
        Dim c As Int16
        c = a ^ b
        Return c
    End Function

End Module
