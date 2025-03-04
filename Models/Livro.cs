namespace CadastrarLivros.Models
{
    internal class Livro
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor  { get; set; }
        public string Categoria { get; set; }
        public int Ano  { get; set; }
        public int Quantidade  { get; set; }
    }
}