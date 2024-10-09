using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aprendizado
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantos livros deseja adicionar? ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Livros> livros = new List<Livros>();

            for (int i = 1; i <= qtd; i++)
            {

                Console.WriteLine("Livro #" + i + ": ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                livros.Add(new Livros(id, nome, autor, preco));
            }
            Console.WriteLine("Livros cadastrados :");
            Console.WriteLine();
            foreach (Livros obj in livros)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.Write("Digite o Id de um livro: ");
            int searchId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Livros livro = livros.Find(x => x.Id == searchId);
            if (livro != null)
            {
                Console.WriteLine("Deseja remover? S/N ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'S' || resp == 's')
                {
                    livros.Remove(livro);
                }
            }
            else
            {
                Console.WriteLine("Id inválido");
            }
            Console.WriteLine();
            foreach (Livros obj in livros)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
