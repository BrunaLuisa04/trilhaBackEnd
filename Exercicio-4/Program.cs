using System;
using System.Collections.Generic;

namespace Exercicio_4
{
    class Program
    {
        static void Main()
        {
            List<string> Nomes = new List<string>();
            string resposta;
            string resposta1;
            string resposta2;
            string resposta3;
            string resposta4;
            string resposta5;
            string resposta6;
            string resposta7;
            string resposta8;
            string resposta9;
            
            Console.WriteLine("Digite o 1º nome");
            resposta = Console.ReadLine();
            Console.WriteLine("Digite o 2º nome");
            resposta1 = Console.ReadLine();
            Console.WriteLine("Digite o 3º nome");
            resposta2 = Console.ReadLine();
            Console.WriteLine("Digite o 4º nome");
            resposta3 = Console.ReadLine();
            Console.WriteLine("Digite o 5º nome");
            resposta4 = Console.ReadLine();
            Console.WriteLine("Digite o 6º nome");
            resposta5 = Console.ReadLine();
            Console.WriteLine("Digite o 7º nome");
            resposta6 = Console.ReadLine();
            Console.WriteLine("Digite o 8º nome");
            resposta7 = Console.ReadLine();
            Console.WriteLine("Digite o 9º nome");
            resposta8 = Console.ReadLine();
            Console.WriteLine("Digite o 10º nome");
            resposta9 = Console.ReadLine();

            Nomes.Add(resposta);
            Nomes.Add(resposta1);
            Nomes.Add(resposta2);
            Nomes.Add(resposta3);
            Nomes.Add(resposta4);
            Nomes.Add(resposta5);
            Nomes.Add(resposta6);
            Nomes.Add(resposta7);
            Nomes.Add(resposta8);
            Nomes.Add(resposta9);
            Nomes.Sort();
            Console.WriteLine();
            
            Console.WriteLine("Todos os nomes foram gravados com sucesso!");

            Console.WriteLine();
            foreach(string s in Nomes)
            {
                Console.WriteLine(s);
            }



            Console.ReadLine();





        }
    }
}
