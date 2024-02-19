
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmDetalhes
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
            this.labelVendas = new System.Windows.Forms.Label();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNomeClinte = new System.Windows.Forms.TextBox();
            this.labNomeCliente = new System.Windows.Forms.Label();
            this.tbTotalVenda = new System.Windows.Forms.TextBox();
            this.labelTotalVenda = new System.Windows.Forms.Label();
            this.tbDataVenda = new System.Windows.Forms.TextBox();
            this.labelDataVenda = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.dataGridListaDeItens = new System.Windows.Forms.DataGridView();
            this.panelProdutos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaDeItens)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.ForeColor = System.Drawing.Color.White;
            this.labelVendas.Location = new System.Drawing.Point(225, 23);
            this.labelVendas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(431, 60);
            this.labelVendas.TabIndex = 1;
            this.labelVendas.Text = "Detalhes da Vendas";
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelProdutos.Controls.Add(this.labelVendas);
            this.panelProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(842, 104);
            this.panelProdutos.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbObs);
            this.groupBox1.Controls.Add(this.labelObs);
            this.groupBox1.Controls.Add(this.tbDataVenda);
            this.groupBox1.Controls.Add(this.labelDataVenda);
            this.groupBox1.Controls.Add(this.tbTotalVenda);
            this.groupBox1.Controls.Add(this.labelTotalVenda);
            this.groupBox1.Controls.Add(this.tbNomeClinte);
            this.groupBox1.Controls.Add(this.labNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(4, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 287);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Venda";
            // 
            // tbNomeClinte
            // 
            this.tbNomeClinte.BackColor = System.Drawing.SystemColors.Window;
            this.tbNomeClinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomeClinte.Location = new System.Drawing.Point(87, 50);
            this.tbNomeClinte.Name = "tbNomeClinte";
            this.tbNomeClinte.ReadOnly = true;
            this.tbNomeClinte.Size = new System.Drawing.Size(313, 26);
            this.tbNomeClinte.TabIndex = 3;
            // 
            // labNomeCliente
            // 
            this.labNomeCliente.AutoSize = true;
            this.labNomeCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labNomeCliente.Location = new System.Drawing.Point(22, 52);
            this.labNomeCliente.Name = "labNomeCliente";
            this.labNomeCliente.Size = new System.Drawing.Size(62, 20);
            this.labNomeCliente.TabIndex = 2;
            this.labNomeCliente.Text = "Cliente:";
            // 
            // tbTotalVenda
            // 
            this.tbTotalVenda.BackColor = System.Drawing.SystemColors.Window;
            this.tbTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalVenda.Location = new System.Drawing.Point(596, 50);
            this.tbTotalVenda.Name = "tbTotalVenda";
            this.tbTotalVenda.ReadOnly = true;
            this.tbTotalVenda.Size = new System.Drawing.Size(185, 26);
            this.tbTotalVenda.TabIndex = 5;
            // 
            // labelTotalVenda
            // 
            this.labelTotalVenda.AutoSize = true;
            this.labelTotalVenda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTotalVenda.Location = new System.Drawing.Point(469, 52);
            this.labelTotalVenda.Name = "labelTotalVenda";
            this.labelTotalVenda.Size = new System.Drawing.Size(121, 20);
            this.labelTotalVenda.TabIndex = 4;
            this.labelTotalVenda.Text = "Total da Venda:";
            // 
            // tbDataVenda
            // 
            this.tbDataVenda.BackColor = System.Drawing.SystemColors.Window;
            this.tbDataVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDataVenda.Location = new System.Drawing.Point(87, 98);
            this.tbDataVenda.Name = "tbDataVenda";
            this.tbDataVenda.ReadOnly = true;
            this.tbDataVenda.Size = new System.Drawing.Size(149, 26);
            this.tbDataVenda.TabIndex = 7;
            // 
            // labelDataVenda
            // 
            this.labelDataVenda.AutoSize = true;
            this.labelDataVenda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDataVenda.Location = new System.Drawing.Point(22, 100);
            this.labelDataVenda.Name = "labelDataVenda";
            this.labelDataVenda.Size = new System.Drawing.Size(48, 20);
            this.labelDataVenda.TabIndex = 6;
            this.labelDataVenda.Text = "Data:";
            // 
            // tbObs
            // 
            this.tbObs.BackColor = System.Drawing.SystemColors.Window;
            this.tbObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbObs.Location = new System.Drawing.Point(87, 150);
            this.tbObs.Multiline = true;
            this.tbObs.Name = "tbObs";
            this.tbObs.ReadOnly = true;
            this.tbObs.Size = new System.Drawing.Size(709, 119);
            this.tbObs.TabIndex = 9;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelObs.Location = new System.Drawing.Point(22, 152);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(43, 20);
            this.labelObs.TabIndex = 8;
            this.labelObs.Text = "OBS";
            // 
            // dataGridListaDeItens
            // 
            this.dataGridListaDeItens.AllowUserToAddRows = false;
            this.dataGridListaDeItens.AllowUserToDeleteRows = false;
            this.dataGridListaDeItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaDeItens.Location = new System.Drawing.Point(4, 399);
            this.dataGridListaDeItens.Name = "dataGridListaDeItens";
            this.dataGridListaDeItens.ReadOnly = true;
            this.dataGridListaDeItens.Size = new System.Drawing.Size(828, 248);
            this.dataGridListaDeItens.TabIndex = 9;
            // 
            // FrmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 659);
            this.Controls.Add(this.dataGridListaDeItens);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDetalhes";
            this.Text = "Detalhes da Venda";
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaDeItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDataVenda;
        private System.Windows.Forms.Label labelTotalVenda;
        private System.Windows.Forms.Label labNomeCliente;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.DataGridView dataGridListaDeItens;
        public System.Windows.Forms.TextBox tbDataVenda;
        public System.Windows.Forms.TextBox tbTotalVenda;
        public System.Windows.Forms.TextBox tbNomeClinte;
        public System.Windows.Forms.TextBox tbObs;
    }
}