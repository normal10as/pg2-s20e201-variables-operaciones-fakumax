Imports System
'1.3. Crea un proyecto llamado �EquivalenciasHoras� que lea una cantidad de horas e imprima su
'equivalente en minutos, segundos y d�as.
Module EquivalenciasHoras
    Sub Main(args As String())
        Dim horas As UShort = ingresoHora()
        Console.WriteLine("El total de Horas ingresadas es : {0}" & vbCrLf &
                          "El total de minutos son : {1}" & vbCrLf &
                          "El total de segundos son : {2}" & vbCrLf &
                          "El total de d�as son : {3}",
                          horas, Math.Floor(horas * 60), Math.Floor(horas * 60) * 60, Math.Floor(horas / 24))

    End Sub
    Function ingresoHora() As UShort
        Console.Write("Ingrese horas para ser devuelta en minutos,segundos y d�as : ")
        Return Console.ReadLine()
    End Function
End Module
