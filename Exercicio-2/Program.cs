using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a, b, c, x1, x2, delta, raizD, resultado;
            Console.WriteLine("Digite valores para a,b e c:");

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = (b * b) - (4 * a * c);
            if(delta < 0)
            {
                // Números testados para delta <0 -> 1 2 3
                Console.WriteLine("Delta não possui raiz real");
            }
            else
            {   //Números testados para delta = 0 -> 1 -10 25
                //Números testados´para delta >0 -> 1 12 -13
               
                raizD = Math.Sqrt(delta);
                x1 = ((-b) + raizD) / (2 * a);
                x2 = ((-b) - raizD) / (2 * a);
                Console.WriteLine("Valor de delta=" + delta);
                Console.WriteLine("Valor de x1 = " + x1);
                Console.WriteLine("Valor de x2 = " + x2);
                resultado = (x1 + x2);
                Console.WriteLine("A diferença entre x1 e x2 é:" + resultado);
            } 
            

            Console.ReadLine();
           


        }
    }
}
