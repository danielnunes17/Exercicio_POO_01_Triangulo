/*Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
válidas).
Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
possui a maior área.
A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
seguinte (fórmula de Heron):
Entre com as medidas do triângulo X:
3.00
4.00
5.00
Entre com as medidas do triângulo Y:
7.50
4.50
4.02
Área de X = 6.0000
Área de Y = 7.5638
Maior área: Y*/

using Exercicio_POO_01_Triangulo;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Triangulo x = new Triangulo();
        Triangulo y = new Triangulo();

        Console.WriteLine("Digite as 3 medida do triangulo X");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite as 3 medida do triangulo Y");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.CalcularTriangulo();
        double areaY = y.CalcularTriangulo();

        Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
            Console.WriteLine("Maior área é X: " + areaX);

        else Console.WriteLine("Maior área é Y: " + areaY);
    }
}