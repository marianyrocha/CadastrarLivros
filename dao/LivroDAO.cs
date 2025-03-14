﻿using CadastrarLivros.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarLivros.dao
{
    internal class livroDAO
    {   
        public void Insert(Livro livro)
        {
            try
            {
                if(livro.Titulo == "")
                {
                    throw new Exception("Verifique se o campo título está preenchido!");
                }
                
                if(livro.Autor == "")
                {
                    throw new Exception("Verifique se o campo autor está preenchido!!");
                }

               

                if (livro.Ano <= 0)
                {
                    throw new Exception("Ano inválido!");
                }

                if (livro.Quantidade < 0)
                {
                    throw new Exception("Quantidade inválida!");
                }


                string sql = "INSERT INTO Livros(Titulo, Autor, Categoria, Ano, Quantidade)" +
                    "VALUES(@Titulo,@Autor,@Categoria,@Ano,@Quantidade)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@Titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@Autor", livro.Autor);
                comando.Parameters.AddWithValue("@Categoria", livro.Categoria);
                comando.Parameters.AddWithValue("@Ano", livro.Ano);
                comando.Parameters.AddWithValue("@Quantidade", livro.Quantidade);
                comando.ExecuteNonQuery();
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
                string sql = "DELETE FROM Livros WHERE IdLivro = @IdLivro";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@IdLivro", livro.IdLivro);
                comando.ExecuteNonQuery();
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
                if (livro.Titulo == "")
                {
                    throw new Exception("Verifique se o campo título está preenchido!");
                }

                if (livro.Autor == "")
                {
                    throw new Exception("Verifique se o campo autor está preenchido!!");
                }

                if (livro.Categoria == "")
                {
                    throw new Exception("Verifique se o campo categoria está selecionado!!");
                }

                if (livro.Ano <= 0)
                {
                    throw new Exception("Ano inválido!");
                }

                if (livro.Quantidade < 0)
                {
                    throw new Exception("Quantidade inválida!");
                }

                string sql = "UPDATE Livros SET Titulo = @Titulo, Autor = @Autor, Categoria = @Categoria, Ano = @Ano, Quantidade = @Quantidade WHERE IdLivro = @IdLivro";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@Titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@Autor", livro.Autor);
                comando.Parameters.AddWithValue("@Categoria", livro.Categoria);
                comando.Parameters.AddWithValue("@Ano", livro.Ano);
                comando.Parameters.AddWithValue("@Quantidade", livro.Quantidade);
                comando.Parameters.AddWithValue("@IdLivro", livro.IdLivro);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
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
                var sql = "SELECT * FROM Livros ORDER BY IdLivro";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Livro livro = new Livro();
                        livro.IdLivro = dr.GetInt32("IdLivro");
                        livro.Titulo = dr.GetString("Titulo");
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
