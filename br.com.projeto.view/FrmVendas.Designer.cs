
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmVendas
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
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.labelVendas = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.maskTBCpfClienteVendas = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.tbNomeClienteVendas = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbCodigoProduto_vendas = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.tbDescricaoProduto_Vendas = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbPrecoProduto_vendas = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.tbQtdEstoqueProduto_Vendas = new System.Windows.Forms.TextBox();
            this.lbQtdEstoqueVendas = new System.Windows.Forms.Label();
            this.btnAdicionarItem_Vendas = new System.Windows.Forms.Button();
            this.btnRemoverItem_vendas = new System.Windows.Forms.Button();
            this.dataGridViewTabelaProdutos_vendas = new System.Windows.Forms.DataGridView();
            this.groupBoxTotalCarrinho = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar_vendas = new System.Windows.Forms.Button();
            this.buttonPagamento_vendas = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelProdutos.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaProdutos_vendas)).BeginInit();
            this.groupBoxTotalCarrinho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelProdutos.Controls.Add(this.labelVendas);
            this.panelProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(1210, 121);
            this.panelProdutos.TabIndex = 4;
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.ForeColor = System.Drawing.Color.White;
            this.labelVendas.Location = new System.Drawing.Point(452, 35);
            this.labelVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(177, 60);
            this.labelVendas.TabIndex = 1;
            this.labelVendas.Text = "Vendas";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.textBox2);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.tbNomeClienteVendas);
            this.groupBoxCliente.Controls.Add(this.lbNome);
            this.groupBoxCliente.Controls.Add(this.maskTBCpfClienteVendas);
            this.groupBoxCliente.Controls.Add(this.lbCpf);
            this.groupBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCliente.Location = new System.Drawing.Point(12, 128);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(483, 183);
            this.groupBoxCliente.TabIndex = 5;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.btnRemoverItem_vendas);
            this.groupBoxProduto.Controls.Add(this.btnAdicionarItem_Vendas);
            this.groupBoxProduto.Controls.Add(this.tbQtdEstoqueProduto_Vendas);
            this.groupBoxProduto.Controls.Add(this.lbQtdEstoqueVendas);
            this.groupBoxProduto.Controls.Add(this.tbPrecoProduto_vendas);
            this.groupBoxProduto.Controls.Add(this.lbPreco);
            this.groupBoxProduto.Controls.Add(this.tbDescricaoProduto_Vendas);
            this.groupBoxProduto.Controls.Add(this.lbDescricao);
            this.groupBoxProduto.Controls.Add(this.tbCodigoProduto_vendas);
            this.groupBoxProduto.Controls.Add(this.labCodigo);
            this.groupBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduto.Location = new System.Drawing.Point(12, 317);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(483, 280);
            this.groupBoxProduto.TabIndex = 6;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Produto";
            // 
            // maskTBCpfClienteVendas
            // 
            this.maskTBCpfClienteVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskTBCpfClienteVendas.Location = new System.Drawing.Point(80, 98);
            this.maskTBCpfClienteVendas.Mask = "###,###,###-##";
            this.maskTBCpfClienteVendas.Name = "maskTBCpfClienteVendas";
            this.maskTBCpfClienteVendas.Size = new System.Drawing.Size(142, 26);
            this.maskTBCpfClienteVendas.TabIndex = 17;
            this.maskTBCpfClienteVendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTBCpfClienteVendas_KeyPress);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCpf.Location = new System.Drawing.Point(30, 101);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(48, 20);
            this.lbCpf.TabIndex = 16;
            this.lbCpf.Text = "CPF:";
            // 
            // tbNomeClienteVendas
            // 
            this.tbNomeClienteVendas.BackColor = System.Drawing.SystemColors.Window;
            this.tbNomeClienteVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomeClienteVendas.Location = new System.Drawing.Point(80, 130);
            this.tbNomeClienteVendas.Name = "tbNomeClienteVendas";
            this.tbNomeClienteVendas.Size = new System.Drawing.Size(308, 26);
            this.tbNomeClienteVendas.TabIndex = 19;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNome.Location = new System.Drawing.Point(17, 133);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(60, 20);
            this.lbNome.TabIndex = 18;
            this.lbNome.Text = "Nome:";
            // 
            // tbCodigoProduto_vendas
            // 
            this.tbCodigoProduto_vendas.BackColor = System.Drawing.SystemColors.Window;
            this.tbCodigoProduto_vendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigoProduto_vendas.Location = new System.Drawing.Point(82, 38);
            this.tbCodigoProduto_vendas.Name = "tbCodigoProduto_vendas";
            this.tbCodigoProduto_vendas.Size = new System.Drawing.Size(108, 26);
            this.tbCodigoProduto_vendas.TabIndex = 3;
            this.tbCodigoProduto_vendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProduto_vendas_KeyPress);
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labCodigo.Location = new System.Drawing.Point(14, 40);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(70, 20);
            this.labCodigo.TabIndex = 2;
            this.labCodigo.Text = "Código:";
            // 
            // tbDescricaoProduto_Vendas
            // 
            this.tbDescricaoProduto_Vendas.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescricaoProduto_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricaoProduto_Vendas.Location = new System.Drawing.Point(110, 81);
            this.tbDescricaoProduto_Vendas.Name = "tbDescricaoProduto_Vendas";
            this.tbDescricaoProduto_Vendas.Size = new System.Drawing.Size(333, 26);
            this.tbDescricaoProduto_Vendas.TabIndex = 5;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDescricao.Location = new System.Drawing.Point(19, 81);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(94, 20);
            this.lbDescricao.TabIndex = 4;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbPrecoProduto_vendas
            // 
            this.tbPrecoProduto_vendas.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrecoProduto_vendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoProduto_vendas.Location = new System.Drawing.Point(124, 130);
            this.tbPrecoProduto_vendas.Name = "tbPrecoProduto_vendas";
            this.tbPrecoProduto_vendas.Size = new System.Drawing.Size(120, 26);
            this.tbPrecoProduto_vendas.TabIndex = 11;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPreco.Location = new System.Drawing.Point(25, 132);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(100, 20);
            this.lbPreco.TabIndex = 10;
            this.lbPreco.Text = "Preço (R$):";
            // 
            // tbQtdEstoqueProduto_Vendas
            // 
            this.tbQtdEstoqueProduto_Vendas.BackColor = System.Drawing.SystemColors.Window;
            this.tbQtdEstoqueProduto_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQtdEstoqueProduto_Vendas.Location = new System.Drawing.Point(381, 131);
            this.tbQtdEstoqueProduto_Vendas.Name = "tbQtdEstoqueProduto_Vendas";
            this.tbQtdEstoqueProduto_Vendas.Size = new System.Drawing.Size(83, 26);
            this.tbQtdEstoqueProduto_Vendas.TabIndex = 23;
            // 
            // lbQtdEstoqueVendas
            // 
            this.lbQtdEstoqueVendas.AutoSize = true;
            this.lbQtdEstoqueVendas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbQtdEstoqueVendas.Location = new System.Drawing.Point(263, 133);
            this.lbQtdEstoqueVendas.Name = "lbQtdEstoqueVendas";
            this.lbQtdEstoqueVendas.Size = new System.Drawing.Size(120, 20);
            this.lbQtdEstoqueVendas.TabIndex = 22;
            this.lbQtdEstoqueVendas.Text = "Qtd. Estoque:";
            // 
            // btnAdicionarItem_Vendas
            // 
            this.btnAdicionarItem_Vendas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdicionarItem_Vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem_Vendas.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarItem_Vendas.Location = new System.Drawing.Point(23, 182);
            this.btnAdicionarItem_Vendas.Name = "btnAdicionarItem_Vendas";
            this.btnAdicionarItem_Vendas.Size = new System.Drawing.Size(173, 61);
            this.btnAdicionarItem_Vendas.TabIndex = 24;
            this.btnAdicionarItem_Vendas.Text = "Adicionar Item";
            this.btnAdicionarItem_Vendas.UseVisualStyleBackColor = false;
            // 
            // btnRemoverItem_vendas
            // 
            this.btnRemoverItem_vendas.BackColor = System.Drawing.Color.Red;
            this.btnRemoverItem_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem_vendas.ForeColor = System.Drawing.Color.White;
            this.btnRemoverItem_vendas.Location = new System.Drawing.Point(258, 182);
            this.btnRemoverItem_vendas.Name = "btnRemoverItem_vendas";
            this.btnRemoverItem_vendas.Size = new System.Drawing.Size(153, 61);
            this.btnRemoverItem_vendas.TabIndex = 25;
            this.btnRemoverItem_vendas.Text = "Remover Item";
            this.btnRemoverItem_vendas.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTabelaProdutos_vendas
            // 
            this.dataGridViewTabelaProdutos_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelaProdutos_vendas.Location = new System.Drawing.Point(517, 138);
            this.dataGridViewTabelaProdutos_vendas.Name = "dataGridViewTabelaProdutos_vendas";
            this.dataGridViewTabelaProdutos_vendas.Size = new System.Drawing.Size(669, 365);
            this.dataGridViewTabelaProdutos_vendas.TabIndex = 7;
            // 
            // groupBoxTotalCarrinho
            // 
            this.groupBoxTotalCarrinho.Controls.Add(this.textBox1);
            this.groupBoxTotalCarrinho.Controls.Add(this.label1);
            this.groupBoxTotalCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTotalCarrinho.Location = new System.Drawing.Point(517, 509);
            this.groupBoxTotalCarrinho.Name = "groupBoxTotalCarrinho";
            this.groupBoxTotalCarrinho.Size = new System.Drawing.Size(669, 86);
            this.groupBoxTotalCarrinho.TabIndex = 20;
            this.groupBoxTotalCarrinho.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(235, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Valor total (R$):";
            // 
            // btnCancelar_vendas
            // 
            this.btnCancelar_vendas.BackColor = System.Drawing.Color.Red;
            this.btnCancelar_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar_vendas.ForeColor = System.Drawing.Color.White;
            this.btnCancelar_vendas.Location = new System.Drawing.Point(892, 612);
            this.btnCancelar_vendas.Name = "btnCancelar_vendas";
            this.btnCancelar_vendas.Size = new System.Drawing.Size(153, 46);
            this.btnCancelar_vendas.TabIndex = 27;
            this.btnCancelar_vendas.Text = "Remover Item";
            this.btnCancelar_vendas.UseVisualStyleBackColor = false;
            // 
            // buttonPagamento_vendas
            // 
            this.buttonPagamento_vendas.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPagamento_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagamento_vendas.ForeColor = System.Drawing.Color.White;
            this.buttonPagamento_vendas.Location = new System.Drawing.Point(657, 612);
            this.buttonPagamento_vendas.Name = "buttonPagamento_vendas";
            this.buttonPagamento_vendas.Size = new System.Drawing.Size(173, 46);
            this.buttonPagamento_vendas.TabIndex = 26;
            this.buttonPagamento_vendas.Text = "Adicionar Item";
            this.buttonPagamento_vendas.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(61, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 26);
            this.textBox2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(58, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data da Compra:";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 692);
            this.Controls.Add(this.btnCancelar_vendas);
            this.Controls.Add(this.buttonPagamento_vendas);
            this.Controls.Add(this.groupBoxTotalCarrinho);
            this.Controls.Add(this.dataGridViewTabelaProdutos_vendas);
            this.Controls.Add(this.groupBoxProduto);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.panelProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaProdutos_vendas)).EndInit();
            this.groupBoxTotalCarrinho.ResumeLayout(false);
            this.groupBoxTotalCarrinho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.MaskedTextBox maskTBCpfClienteVendas;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox tbNomeClienteVendas;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbCodigoProduto_vendas;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.TextBox tbDescricaoProduto_Vendas;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbPrecoProduto_vendas;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox tbQtdEstoqueProduto_Vendas;
        private System.Windows.Forms.Label lbQtdEstoqueVendas;
        private System.Windows.Forms.Button btnRemoverItem_vendas;
        private System.Windows.Forms.Button btnAdicionarItem_Vendas;
        private System.Windows.Forms.DataGridView dataGridViewTabelaProdutos_vendas;
        private System.Windows.Forms.GroupBox groupBoxTotalCarrinho;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar_vendas;
        private System.Windows.Forms.Button buttonPagamento_vendas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}