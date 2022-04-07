using System;

namespace DesafiosTrilhaC
{
    class Program
    {
        static void Main(string[] args)
        {
			int n1, n2, n3, n4, n5, maior, menor, resultado;
			Console.Write("Digite 5 números:");

			string[] vet = Console.ReadLine().Split(' ');

			n1 = int.Parse(vet[0]);
			n2 = int.Parse(vet[1]);
			n3 = int.Parse(vet[2]);
			n4 = int.Parse(vet[3]);
			n5 = int.Parse(vet[4]);

			if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
			{
				maior = n1;
				Console.WriteLine("O maior número é: " + maior);

			}
			else
			{
				if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
				{
					maior = n2;
					Console.WriteLine("O maior número é: " + maior);
				}
				else
				{
					if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
					{
						maior = n3;
						Console.WriteLine("O maior é: " + maior);
					}
					else
					{
						if (n4 > n1 && n4 > n2 && n4 > n3 && n3 > n5)
						{
							maior = n4;
							Console.WriteLine("O maior é " + maior);
						}
						else
						{
							maior = n5;
							Console.WriteLine("O maior é " + maior);
						}
						Console.ReadLine();

					}


				}
			}
			if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
			{
				menor = n1;
				Console.WriteLine("O menor é " + menor);
			}
			else
			{
				if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5)
				{
					menor = n2;
					Console.WriteLine("O menor é " + menor);
				}
				else
				{
					if (n3 < n1 && n3 < n2 && n3 < n4 && n3 < n5)
					{
						menor = n3;
						Console.WriteLine("O menor é " + menor);
					}
					else
					{
						if (n4 < n1 && n4 < n2 && n4 < n3 && n4 < n5)
						{
							menor = n4;
							Console.WriteLine("O menor é  " + menor);
						}
						else
						{
							menor = n5;
							Console.WriteLine("O menor é  " + " " + menor);
						}

					}

				}
			}
			resultado = maior - menor;
			Console.WriteLine("A diferença entre o maior e menor número é " + resultado);
			Console.ReadLine();
		}
	}
    
}
