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
            livroDAO dados = new livroDAO();
            dgvTabela.DataSource = dados.List();

        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Livro livro = new Livro();

                livro.Titulo = txtTitulo.Text;
                livro.Autor = txtAutor.Text;
                livro.Categoria =cbCategoria.SelectedItem.ToString();
                livro.Ano = Convert.ToInt32(txtAno.Text);
                livro.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                livroDAO livroDAO = new livroDAO(); 
                int idEditar = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells["Id"].Value);
                List<Livro> livros = livroDAO.List();

               foreach (var livroLista in livros)
               {
                    if (livroLista.Id == idEditar)
                    {
                        livro.Id = idEditar;
                        livroDAO.Update(livro);
                        MessageBox.Show($"Livro atualizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTabela .DataSource = livroDAO.List();
                      
                        txtTitulo.Clear();
                        txtAutor.Clear();
                        txtAno.Clear();
                        txtQuantidade.Clear();
                        cbCategoria.Text = "";
                        txtTitulo.Select();

                        btCadastrar.Text = "CADASTRAR";

                        return;
                    }
               }

                livroDAO.Insert(livro);
                MessageBox.Show($"Livro cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTabela.DataSource = livroDAO.List();

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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Tem certeza que quer excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if(excluir == DialogResult.Yes)
                {
                    livroDAO livroDAO = new livroDAO();
                    foreach (DataGridViewRow linha in dgvTabela.SelectedRows)
                    {
                        int idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);
                        livroDAO.Delete(new Livro { Id = idSelecionado });
                    }
                    dgvTabela.DataSource = livroDAO.List();
                }
                MessageBox.Show($"Livro excluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                btCadastrar.Text = "ATUALIZAR";

                int Id = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells[0].Value);

                Livro livro = new Livro();
                
                txtTitulo.Text = dgvTabela.SelectedRows[0].Cells["Titulo"].Value.ToString();
                txtAutor.Text = dgvTabela.SelectedRows[0].Cells["Autor"].Value.ToString();
                cbCategoria.SelectedItem = dgvTabela.SelectedRows[0].Cells["Categoria"].Value.ToString();
                txtAno.Text = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells["Ano"].Value).ToString();
                txtQuantidade.Text = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells["Quantidade"].Value).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar editar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
