using System;
using System.Collections.Generic;
using System.Globalization;


namespace Aprendizado
{
    class Livros
    {
        // int = numero inteiros
        // double = numeros reais
        // string = Frase/Palavra/Texto
        // float = 4.5f
        // char = apenas uma letra
        // get = buscar,ler,adicionar
        // set = alterar/modificar
        // private set = so pode modificar dentro da classe
        // private get = so pode ser lido ou adicionar dentro da classe
        // if/else = se/se nao (condição)
        // for = para todo (repetição)
        // ++ = incremento/adição
        // -- = decremento/diminuição
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public double Preco { get; private set; }

        public Livros(int id, string nome, string autor, double preco)
        {
            Id = id;
            Nome = nome;
            Autor = autor;
            Preco = preco;
        }
        public override string ToString()
        {
            return "ID: " + Id
            + ": " + Nome
            + ", " + Autor
            + ", Valor: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
