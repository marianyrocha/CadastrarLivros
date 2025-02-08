using MySql.Data.MySqlClient;
using System;

public static class Conexao
{
    static MySqlConnection conexao; 

    public static MySqlConnection Conectar()
    {
        try
        {
            string stgconexao = "server=localhost;uid=root;pwd=123456;database=CadastrarLivros";
            conexao = new MySqlConnection(stgconexao);
            conexao.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao realizar a conexão com a base de dados!");
        }
        return conexao;
    }

    public static void FecharConexao()
    {
        conexao.Close();
    }
}
