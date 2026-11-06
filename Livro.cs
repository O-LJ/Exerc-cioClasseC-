using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public void InfoLivro()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Número de Páginas: {NumeroPaginas}");
        }

        public Livro()
        {
            Titulo = "";
            Autor = "";
            NumeroPaginas = 0;
        }

        public Livro(string titulo)
        {
            Titulo = titulo;
        }
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }
    }
}