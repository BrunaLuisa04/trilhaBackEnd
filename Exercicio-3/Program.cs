using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = 3251;
            int resposta;
           

           
            Console.WriteLine("Digite o código:");
            resposta = int.Parse(Console.ReadLine());

            
            if (resposta== codigo)
            {
                Console.WriteLine("Código correto!");
            }
            else
            {
                

                while (resposta != codigo)
                {
                    Console.WriteLine("Código incorreto!");
                    if (codigo > resposta)
                    {
                        Console.WriteLine("O código correto é  maior do que o informado");
                    }
                    else
                    {
                        Console.WriteLine(" O Código correto é menor do que o informado");
                    }
                    Console.WriteLine("Digite o código:");
                    resposta = int.Parse(Console.ReadLine());
                   
                                      
                }
                



            }

            Console.ReadLine();




        }
    }
}
