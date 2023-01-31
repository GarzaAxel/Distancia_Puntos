Public Class Datos

    Public x1, x2, y1, y2, distancia As Double
    Public Property _x1 As Double
        Get
            Return x1
        End Get
        Set(value As Double)
            x1 = value
        End Set
    End Property

    Public Property _y1 As Double
        Get
            Return y1
        End Get
        Set(value As Double)
            y1 = value
        End Set
    End Property

    Public Property _x2 As Double
        Get
            Return x2
        End Get
        Set(value As Double)
            x2 = value
        End Set
    End Property

    Public Property _y2 As Double
        Get
            Return y2
        End Get
        Set(value As Double)
            y2 = value
        End Set
    End Property
    Public Function Calculo(x1, y1, x2, y2) As Double
        Dim resultado As Double
        resultado = ((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)))
        resultado = (Math.Sqrt(resultado))
        Return resultado
    End Function
End Class
