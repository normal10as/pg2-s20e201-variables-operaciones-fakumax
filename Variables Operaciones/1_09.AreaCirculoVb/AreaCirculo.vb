Imports System
'1.9. Crea un proyecto llamado ��reaCirculo� donde se ingresa el radio del c�rculo imprime el
'�rea. Area = pi*(r^2)
Module AreaCirculo
    Sub Main(args As String())
        Dim radio As Single = radioCirculo()
        Console.WriteLine("El �rea es : {0}", Math.PI * (radio ^ 2))
    End Sub


    Function radioCirculo() As Single
        Console.Write("Ingrese radio del c�rculo : ")
        Return Console.ReadLine()
    End Function
End Module
