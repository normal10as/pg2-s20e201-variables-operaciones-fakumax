Imports System
'1.1. Crear un proyecto llamado �Costos� qu� calcula imprima el costo de producci�n de un
'art�culo, teniendo como datos la descripci�n y el n�mero de unidades producidas. El costo se
'calcula multiplicando el n�mero de unidades producidas por un factor de costo de materiales
'de 3. 5 y sum�ndole el producto un costo fijo de 10.700. Informar todos los datos ingresados
'junto a los resultados calculados.
Module Costos
    Sub Main(args As String())
        Dim articulo As String
        Dim unidades As UInt32
        Console.Write("Ingrese descripci�n del art�culo : ")
        articulo = Console.ReadLine
        Console.Write("Ingrese el n�mero de unidades producidas : ")
        unidades = Console.ReadLine
        Console.WriteLine("El art�culo es : {0} " & vbCrLf &
                          "Las unidades producidas son : {1} " & vbCrLf &
                          "Costo Fijo : 10.700" & vbCrLf &
                          "El resultado de costos es : {2} ", articulo, unidades, costo(unidades))
    End Sub
    Function costo(unidades) As Single
        Return unidades * 3.5 + 10700
    End Function

End Module
