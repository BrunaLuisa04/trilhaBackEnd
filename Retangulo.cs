using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3_Retangulo
{
    public class Retangulo
    {
        //Atributos para minha classe
        public double Lado1;
        public double Lado2;
        public double Area;
        public double Perimetro;

        //CONSTRUTOR
        public Retangulo()
        {
            return;
        }
        //CONSTRUTOR
        public Retangulo(double LadoA, double LadoB)
        {
            Lado1 = LadoA;
            Lado2 = LadoB;
            return;

        }

        //MÉTODO CALCULO DE ÁREA
        public void CalcularArea()
        {
            Area = Lado1 * Lado2;
            Console.WriteLine(Area);
            
        }

        //MÉTODO CALCULO DE PERÍMETRO
        public void CalcularPerimetro()
        {
            Perimetro = 2 * (Lado1 + Lado2);
            Console.WriteLine(Perimetro);
            
        }
    }

    
}
