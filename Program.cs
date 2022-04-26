using Desafio3_Livro;
using System.Globalization;

namespace Exercicio_2
{
    public class Program

    {   //Variáveis pra armazenar as respostas do usuário
        private static string livro;
        private static string autor;
        private static string genero;
        private static string titulo;
        private static int paginas;


        static void Main(string[] args)
        {

            //Solicita ao usuário
            Console.WriteLine("Olá! Digite a seguir informações sobre o livro que está lendo:");

            Console.Write("Nome do livro: ");
            livro = Console.ReadLine();

            Console.Write("Nome do autor: ");
            autor = Console.ReadLine();

            Console.Write("Gênero: ");
            genero = Console.ReadLine();

            Console.WriteLine("Quantas páginas o livro possui: ");
            paginas = Convert.ToInt32(Console.ReadLine());

            //Instanciação-Chama o método construtor da classe
            Livro novoLivro = new Livro(titulo, paginas);

            novoLivro.Nome = livro;
            novoLivro.Autor = autor;
            novoLivro.Genero = genero;

            //Verifica progresso
            Console.Write("Páginas lidas: ");
            novoLivro.PaginasLidas = Convert.ToInt32(Console.ReadLine());
            novoLivro.VerificarProgresso();
            Console.Write("Páginas lidas: ");
            novoLivro.PaginasLidas = Convert.ToInt32(Console.ReadLine());
            novoLivro.VerificarProgresso();
            Console.Write("Páginas lidas: ");
            novoLivro.PaginasLidas = Convert.ToInt32(Console.ReadLine());
            novoLivro.VerificarProgresso();

            Console.ReadLine();

        }

       
    }
}

