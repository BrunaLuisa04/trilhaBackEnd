using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3_Livro
{
    public class Livro
    {
        

        public string Nome {get; set;}
        public string Autor {get; set;}
        public string Genero { get; set;}
        public int  QtdPaginas { get; set;}
        public int PaginasLidas { get; set; }
        public int Porcentagem { get; set; }

        //CONSTRUTOR
        public Livro()
        {
            return;
        }

        public Livro(string titulo, int paginas)
        {
            Nome = titulo;
            QtdPaginas = paginas;
           

        }

        public void VerificarProgresso()
        {
            Porcentagem = PaginasLidas *100 /QtdPaginas;
            Console.WriteLine(Porcentagem);
          
        }
    }






}

