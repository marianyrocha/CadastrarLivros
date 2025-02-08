using CadastrarLivros.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarLivros.dao
{
    internal class LivroDAO
    {
        static MySqlConnection Livro;
        
        public void Insert(Livro livro)
        {
            try
            {
                string sql = "INSERT INTO Livros(Titulo, Autor, Categoria, Ano, Quantidade)" +
                    "VALUES(@Titulo,@Autor,@Categoria,@Ano,@Quantidade)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@Titulo", livro.Título);
                comando.Parameters.AddWithValue("@Autor", livro.Autor);
                comando.Parameters.AddWithValue("@Categoria", livro.Categoria);
                comando.Parameters.AddWithValue("@Ano", livro.Ano);
                comando.Parameters.AddWithValue("@Quantidade", livro.Quantidade);
                comando.ExecuteNonQuery();
                Console.WriteLine("Livro cadastrado com sucesso!");
                Conexao.FecharConexao();
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao tentar cadastrar: {ex.Message}");
            }

        }

        public void Delete(Livro livro)
        {
            try
            {
                string sql = "DELETE FROM Livros WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@Id", livro.Id);
                comando.ExecuteNonQuery();
                Console.WriteLine("Livro excluido com sucesso!");
                Conexao.FecharConexao();
            }
            catch(Exception ex ) 
            {
                throw new Exception($"Erro ao tentar excluir: {ex.Message}");
            }
        }

        public void Update(Livro livro)
        {
            try
            {
                string sql = "UPDATE Livros SET Titulo = @Titulo, Autor = @Autor, Categoria = @Categoria, Ano = @Ano, Quantidade = @Quantidade WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@Id", livro.Id);
                comando.Parameters.AddWithValue("@Titulo", livro.Título);
                comando.Parameters.AddWithValue("@Autor", livro.Autor);
                comando.Parameters.AddWithValue("@Categoria", livro.Categoria);
                comando.Parameters.AddWithValue("@Ano", livro.Ano);
                comando.Parameters.AddWithValue("@Quantidade", livro.Quantidade);
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao tentar atualizar: {ex.Message}");
            }
        }

        public List<Livro> List()
        {
            List<Livro> livros = new List<Livro>();
            try
            {
                var sql = "SELECT * FROM LIVROS ORDER BY Id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Livro livro = new Livro();
                        livro.Id = dr.GetInt32("Id");
                        livro.Título = dr.GetString("Titulo");
                        livro.Autor = dr.GetString("Autor");
                        livro.Categoria = dr.GetString("Categoria");
                        livro.Ano = dr.GetInt32("Ano");
                        livro.Quantidade = dr.GetInt32("Quantidade");
                        livros.Add(livro);
                    }
                }
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar listar: {ex.Message}");
            }
            return livros;
        }

    }
}
