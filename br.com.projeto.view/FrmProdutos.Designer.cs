
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProdutos = new System.Windows.Forms.Label();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabPageCadProduto = new System.Windows.Forms.TabPage();
            this.comboBoxFornecedorFk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQtdEstoque = new System.Windows.Forms.TextBox();
            this.lbQtdEstoque = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.tabPageFornecedor = new System.Windows.Forms.TabPage();
            this.dataGridView_TabelaProduto = new System.Windows.Forms.DataGridView();
            this.tbnPesquisar_Consulta = new System.Windows.Forms.Button();
            this.textBoxNomeBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panelProdutos.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            this.tabPageCadProduto.SuspendLayout();
            this.tabPageFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabelaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProdutos
            // 
            this.labelProdutos.AutoSize = true;
            this.labelProdutos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutos.ForeColor = System.Drawing.Color.White;
            this.labelProdutos.Location = new System.Drawing.Point(82, 54);
            this.labelProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProdutos.Name = "labelProdutos";
            this.labelProdutos.Size = new System.Drawing.Size(215, 24);
            this.labelProdutos.TabIndex = 1;
            this.labelProdutos.Text = "Cadastro de Produtos";
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelProdutos.Controls.Add(this.labelProdutos);
            this.panelProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(1189, 154);
            this.panelProdutos.TabIndex = 3;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabPageCadProduto);
            this.tabProdutos.Controls.Add(this.tabPageFornecedor);
            this.tabProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProdutos.Location = new System.Drawing.Point(12, 175);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(1155, 254);
            this.tabProdutos.TabIndex = 4;
            // 
            // tabPageCadProduto
            // 
            this.tabPageCadProduto.Controls.Add(this.comboBoxFornecedorFk);
            this.tabPageCadProduto.Controls.Add(this.label4);
            this.tabPageCadProduto.Controls.Add(this.tbQtdEstoque);
            this.tabPageCadProduto.Controls.Add(this.lbQtdEstoque);
            this.tabPageCadProduto.Controls.Add(this.tbPreco);
            this.tabPageCadProduto.Controls.Add(this.lbPreco);
            this.tabPageCadProduto.Controls.Add(this.tbDescricao);
            this.tabPageCadProduto.Controls.Add(this.lbDescricao);
            this.tabPageCadProduto.Controls.Add(this.tbCodigo);
            this.tabPageCadProduto.Controls.Add(this.labCodigo);
            this.tabPageCadProduto.Location = new System.Drawing.Point(4, 29);
            this.tabPageCadProduto.Name = "tabPageCadProduto";
            this.tabPageCadProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadProduto.Size = new System.Drawing.Size(1147, 221);
            this.tabPageCadProduto.TabIndex = 0;
            this.tabPageCadProduto.Text = "Dados do Produto";
            this.tabPageCadProduto.UseVisualStyleBackColor = true;
            // 
            // comboBoxFornecedorFk
            // 
            this.comboBoxFornecedorFk.FormattingEnabled = true;
            this.comboBoxFornecedorFk.Location = new System.Drawing.Point(643, 117);
            this.comboBoxFornecedorFk.Name = "comboBoxFornecedorFk";
            this.comboBoxFornecedorFk.Size = new System.Drawing.Size(237, 28);
            this.comboBoxFornecedorFk.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(543, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fornecedor:";
            // 
            // tbQtdEstoque
            // 
            this.tbQtdEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.tbQtdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQtdEstoque.Location = new System.Drawing.Point(188, 117);
            this.tbQtdEstoque.Name = "tbQtdEstoque";
            this.tbQtdEstoque.Size = new System.Drawing.Size(250, 26);
            this.tbQtdEstoque.TabIndex = 21;
            // 
            // lbQtdEstoque
            // 
            this.lbQtdEstoque.AutoSize = true;
            this.lbQtdEstoque.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbQtdEstoque.Location = new System.Drawing.Point(20, 120);
            this.lbQtdEstoque.Name = "lbQtdEstoque";
            this.lbQtdEstoque.Size = new System.Drawing.Size(164, 20);
            this.lbQtdEstoque.TabIndex = 20;
            this.lbQtdEstoque.Text = "Quantidade Estoque: ";
            // 
            // tbPreco
            // 
            this.tbPreco.BackColor = System.Drawing.SystemColors.Window;
            this.tbPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPreco.Location = new System.Drawing.Point(600, 71);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(120, 26);
            this.tbPreco.TabIndex = 9;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPreco.Location = new System.Drawing.Point(537, 73);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(54, 20);
            this.lbPreco.TabIndex = 8;
            this.lbPreco.Text = "Preço:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricao.Location = new System.Drawing.Point(110, 71);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(367, 26);
            this.tbDescricao.TabIndex = 3;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDescricao.Location = new System.Drawing.Point(20, 71);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(84, 20);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigo.Location = new System.Drawing.Point(85, 24);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(108, 26);
            this.tbCodigo.TabIndex = 1;
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labCodigo.Location = new System.Drawing.Point(20, 26);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(63, 20);
            this.labCodigo.TabIndex = 0;
            this.labCodigo.Text = "Código:";
            // 
            // tabPageFornecedor
            // 
            this.tabPageFornecedor.Controls.Add(this.dataGridView_TabelaProduto);
            this.tabPageFornecedor.Controls.Add(this.tbnPesquisar_Consulta);
            this.tabPageFornecedor.Controls.Add(this.textBoxNomeBuscar);
            this.tabPageFornecedor.Controls.Add(this.label3);
            this.tabPageFornecedor.Location = new System.Drawing.Point(4, 29);
            this.tabPageFornecedor.Name = "tabPageFornecedor";
            this.tabPageFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFornecedor.Size = new System.Drawing.Size(1147, 221);
            this.tabPageFornecedor.TabIndex = 1;
            this.tabPageFornecedor.Text = "Consulta";
            this.tabPageFornecedor.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TabelaProduto
            // 
            this.dataGridView_TabelaProduto.AllowUserToAddRows = false;
            this.dataGridView_TabelaProduto.AllowUserToDeleteRows = false;
            this.dataGridView_TabelaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TabelaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TabelaProduto.Location = new System.Drawing.Point(4, 52);
            this.dataGridView_TabelaProduto.Name = "dataGridView_TabelaProduto";
            this.dataGridView_TabelaProduto.ReadOnly = true;
            this.dataGridView_TabelaProduto.Size = new System.Drawing.Size(1137, 154);
            this.dataGridView_TabelaProduto.TabIndex = 7;
            this.dataGridView_TabelaProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TabelaProduto_CellClick);
            // 
            // tbnPesquisar_Consulta
            // 
            this.tbnPesquisar_Consulta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbnPesquisar_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnPesquisar_Consulta.ForeColor = System.Drawing.Color.White;
            this.tbnPesquisar_Consulta.Location = new System.Drawing.Point(462, 11);
            this.tbnPesquisar_Consulta.Name = "tbnPesquisar_Consulta";
            this.tbnPesquisar_Consulta.Size = new System.Drawing.Size(109, 35);
            this.tbnPesquisar_Consulta.TabIndex = 6;
            this.tbnPesquisar_Consulta.Text = "Pesquisar";
            this.tbnPesquisar_Consulta.UseVisualStyleBackColor = false;
            this.tbnPesquisar_Consulta.Click += new System.EventHandler(this.tbnPesquisar_Consulta_Click);
            // 
            // textBoxNomeBuscar
            // 
            this.textBoxNomeBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNomeBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeBuscar.Location = new System.Drawing.Point(69, 17);
            this.textBoxNomeBuscar.Name = "textBoxNomeBuscar";
            this.textBoxNomeBuscar.Size = new System.Drawing.Size(367, 26);
            this.textBoxNomeBuscar.TabIndex = 5;
            this.textBoxNomeBuscar.TextChanged += new System.EventHandler(this.textBoxNomeBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(745, 467);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 61);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(577, 467);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(148, 61);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(409, 467);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 61);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(235, 467);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 61);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 563);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.panelProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProdutos";
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabPageCadProduto.ResumeLayout(false);
            this.tabPageCadProduto.PerformLayout();
            this.tabPageFornecedor.ResumeLayout(false);
            this.tabPageFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabelaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProdutos;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabPageCadProduto;
        private System.Windows.Forms.ComboBox comboBoxFornecedorFk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQtdEstoque;
        private System.Windows.Forms.Label lbQtdEstoque;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.TabPage tabPageFornecedor;
        private System.Windows.Forms.DataGridView dataGridView_TabelaProduto;
        private System.Windows.Forms.Button tbnPesquisar_Consulta;
        private System.Windows.Forms.TextBox textBoxNomeBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
    }
}