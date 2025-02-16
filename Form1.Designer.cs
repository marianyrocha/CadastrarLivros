namespace CadastrarLivros
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.lbLivros = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lbCategoria);
            this.groupBox1.Controls.Add(this.lbQuantidade);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.lbAno);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btCadastrar);
            this.groupBox1.Controls.Add(this.lbAutor);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.lbTitulo);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Location = new System.Drawing.Point(30, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(171, 147);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(53, 16);
            this.lbCategoria.TabIndex = 10;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(95, 147);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(61, 16);
            this.lbQuantidade.TabIndex = 9;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(98, 167);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(69, 26);
            this.txtQuantidade.TabIndex = 8;
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(20, 147);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(26, 16);
            this.lbAno.TabIndex = 7;
            this.lbAno.Text = "Ano";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(21, 166);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(69, 26);
            this.txtAno.TabIndex = 6;
            this.txtAno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAno_KeyUp);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(160, 213);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 38);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseMnemonic = false;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Green;
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(18, 213);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(136, 38);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(17, 86);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(32, 16);
            this.lbAutor.TabIndex = 5;
            this.lbAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(18, 105);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(272, 26);
            this.txtAutor.TabIndex = 4;
            this.txtAutor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAutor_KeyUp);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(15, 24);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(32, 16);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Título";
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Autoajuda",
            "Desenvolvimento Pessoal",
            "Ficção Científica",
            "Romance",
            "Fantasia",
            "Drama",
            "Suspense",
            "Terror"});
            this.cbCategoria.Location = new System.Drawing.Point(174, 168);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(116, 24);
            this.cbCategoria.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(18, 43);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(272, 26);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitulo_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dgvTabela);
            this.groupBox2.Location = new System.Drawing.Point(357, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Gray;
            this.btBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.White;
            this.btBuscar.Location = new System.Drawing.Point(312, 39);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(90, 30);
            this.btBuscar.TabIndex = 13;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 26);
            this.textBox1.TabIndex = 11;
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(12, 82);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(390, 169);
            this.dgvTabela.TabIndex = 0;
            // 
            // lbLivros
            // 
            this.lbLivros.AutoSize = true;
            this.lbLivros.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivros.Location = new System.Drawing.Point(24, 57);
            this.lbLivros.Name = "lbLivros";
            this.lbLivros.Size = new System.Drawing.Size(315, 44);
            this.lbLivros.TabIndex = 2;
            this.lbLivros.Text = "Cadastrar Livros";
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(672, 66);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(99, 37);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseMnemonic = false;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Teal;
            this.btEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(576, 66);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(90, 37);
            this.btEditar.TabIndex = 11;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.lbLivros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLivros;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label3;
    }
}

