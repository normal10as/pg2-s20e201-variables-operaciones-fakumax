Imports System
'1.10. Crea un proyecto llamado �Cotizaci�nD�lar� el cual se ingresa la cantidad de d�lares
'que se va a comprar y el tipo de cambio en pesos (cost� de un d�lar en pesos) Calcular e
'imprimir la cantidad que se debe pagar en pesos por la cantidad de d�lares indicada.
Module CotizacionDolar
    Sub Main(args As String())
        Dim compraDolar As Int32 = comprarDolares()
        Dim cambioPeso As Int32 = tipoCambio()
        Console.WriteLine("Por {0} d�lares debe pagar {1} pesos", compraDolar, cambioPeso * compraDolar)

    End Sub

    Function comprarDolares() As Int32
        Console.Write("Ingrese la cantidad de d�lares a comprar : ")
        Return Console.ReadLine
    End Function

    Function tipoCambio() As Int32
        Console.Write("Ingrese costo de 1 d�lar en pesos : ")
        Return Console.ReadLine
    End Function
End Module
