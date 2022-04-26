using Desafio3_Retangulo;
using System;
using System.Globalization;

namespace Exercicio_1
{
    public class Program

    {
        //Declaração das variáveis da  minha classe construtora
        private static double Lado1, Lado2;
        static void Main(string[] args)
        {
            //Solicita ao usuário
            Console.WriteLine("Digite o primeiro valor para o retângulo");
            Lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor para o retângulo");
            Lado2 = double.Parse(Console.ReadLine());

            //Instanciação-Chama o método construtor da classe
            Retangulo novoRetangulo = new Retangulo(Lado1, Lado2);
            
            //Chamando os métodos
            novoRetangulo.CalcularArea();
            novoRetangulo.CalcularPerimetro();

            


            Console.ReadLine();

        }
        
        

    }    
}


