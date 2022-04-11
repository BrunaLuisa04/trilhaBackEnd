using System;
using System.Globalization;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consumo médio de gasolina 
            Console.WriteLine("Executando varáveis do tipo DOUBLE");
            double distancia, combustivel;
            double ConsumoMedio;

            Console.WriteLine("Digite a distância a ser percorrida em Km :");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos litros de gasolina irá utilizar:");
            combustivel = double.Parse(Console.ReadLine());

            ConsumoMedio = distancia / combustivel;
            Console.WriteLine("O consumo médio de gasolina será de: " + ConsumoMedio.ToString("f2", CultureInfo.InvariantCulture) + " litros por quilômetro rodado");
            Console.WriteLine("Boa viagem!");
            Console.WriteLine();

            //Calculo de desconto em produto
            Console.WriteLine("Executando variáveis do tipo FLOAT");
            int PrecoProduto;
            float desconto;
            int precofinal;

            Console.WriteLine("Digite o preço do produto:");
            PrecoProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o desconto:");
            desconto = float.Parse(Console.ReadLine());

            precofinal = (int)(PrecoProduto - desconto);
            Console.WriteLine("O preço final com desconto é de:R$ " + precofinal.ToString("f2",CultureInfo.InvariantCulture) + "reais");
            Console.WriteLine("Você economizou: R$ " + desconto.ToString("F2",CultureInfo.InvariantCulture) + " reais");

            Console.ReadLine();


                                                            



        }
    }
}
