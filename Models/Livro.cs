﻿namespace CadastrarLivros.Models
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public string Autor  { get; set; }
        public int Ano  { get; set; }
        public int Quantidade  { get; set; }
        public string Categoria  { get; set; }
    }
}