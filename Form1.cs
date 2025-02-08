using CadastrarLivros.dao;
using CadastrarLivros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CadastrarLivros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbCategoria.SelectedIndex = -1;
            txtTitulo.Select();
        }
       
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Livro livro = new Livro();

                livro.Titulo = txtTitulo.Text;
                livro.Autor = txtAutor.Text;
                livro.Categoria =cbCategoria.SelectedItem.ToString();
                livro.Ano = int.Parse(txtAno.Text);
                livro.Quantidade = int.Parse(txtQuantidade.Text);

                LivroDAO livroDAO = new LivroDAO();
                livroDAO.Insert(livro);

                dgvTabela.AutoGenerateColumns = true;
                dgvTabela.DataSource = livroDAO.List();

                MessageBox.Show($"Livro cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTitulo.Clear();
                txtAutor.Clear();
                txtAno.Clear();
                txtQuantidade.Clear();
                cbCategoria.Text = "";
                txtTitulo.Select();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao tentar cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAno.Clear();
            txtQuantidade.Clear();
            cbCategoria.Text = "";
            txtTitulo.Select();
        }

        private void txtTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtTitulo.Text == "")
                {
                    MessageBox.Show("Informe o título do livro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitulo.Select();
                }
                else
                {
                    txtAutor.Select();
                }
            }
        }

        private void txtAutor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtAno.Select();
            }
        }

        private void txtAno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidade.Select();
            }
        }
    }
}
