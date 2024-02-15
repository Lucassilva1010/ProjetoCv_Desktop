
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmPagamentos
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
            this.tbPrecoPagamento_dinheiro = new System.Windows.Forms.TextBox();
            this.lbPreco_pagamento = new System.Windows.Forms.Label();
            this.tbPagamento_pix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPagamento_cartao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPagamento_troco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPgamento_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar_vendas = new System.Windows.Forms.Button();
            this.labelObs = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.panelProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelProdutos.Controls.Add(this.labelVendas);
            this.panelProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(465, 106);
            this.panelProdutos.TabIndex = 5;
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.ForeColor = System.Drawing.Color.White;
            this.labelVendas.Location = new System.Drawing.Point(77, 20);
            this.labelVendas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(258, 60);
            this.labelVendas.TabIndex = 1;
            this.labelVendas.Text = "Pagamento";
            // 
            // tbPrecoPagamento_dinheiro
            // 
            this.tbPrecoPagamento_dinheiro.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrecoPagamento_dinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoPagamento_dinheiro.Location = new System.Drawing.Point(223, 138);
            this.tbPrecoPagamento_dinheiro.Name = "tbPrecoPagamento_dinheiro";
            this.tbPrecoPagamento_dinheiro.Size = new System.Drawing.Size(120, 26);
            this.tbPrecoPagamento_dinheiro.TabIndex = 13;
            // 
            // lbPreco_pagamento
            // 
            this.lbPreco_pagamento.AutoSize = true;
            this.lbPreco_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco_pagamento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPreco_pagamento.Location = new System.Drawing.Point(34, 132);
            this.lbPreco_pagamento.Name = "lbPreco_pagamento";
            this.lbPreco_pagamento.Size = new System.Drawing.Size(183, 31);
            this.lbPreco_pagamento.TabIndex = 12;
            this.lbPreco_pagamento.Text = "Dinheiro (R$):";
            // 
            // tbPagamento_pix
            // 
            this.tbPagamento_pix.BackColor = System.Drawing.SystemColors.Window;
            this.tbPagamento_pix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPagamento_pix.Location = new System.Drawing.Point(223, 190);
            this.tbPagamento_pix.Name = "tbPagamento_pix";
            this.tbPagamento_pix.Size = new System.Drawing.Size(120, 26);
            this.tbPagamento_pix.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(151, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "PIX:";
            // 
            // tbPagamento_cartao
            // 
            this.tbPagamento_cartao.BackColor = System.Drawing.SystemColors.Window;
            this.tbPagamento_cartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPagamento_cartao.Location = new System.Drawing.Point(223, 236);
            this.tbPagamento_cartao.Name = "tbPagamento_cartao";
            this.tbPagamento_cartao.Size = new System.Drawing.Size(120, 26);
            this.tbPagamento_cartao.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(113, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cartão:";
            // 
            // tbPagamento_troco
            // 
            this.tbPagamento_troco.BackColor = System.Drawing.SystemColors.Window;
            this.tbPagamento_troco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPagamento_troco.Location = new System.Drawing.Point(223, 324);
            this.tbPagamento_troco.Name = "tbPagamento_troco";
            this.tbPagamento_troco.ReadOnly = true;
            this.tbPagamento_troco.Size = new System.Drawing.Size(120, 26);
            this.tbPagamento_troco.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(125, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Troco:";
            // 
            // tbPgamento_total
            // 
            this.tbPgamento_total.BackColor = System.Drawing.SystemColors.Window;
            this.tbPgamento_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPgamento_total.Location = new System.Drawing.Point(223, 371);
            this.tbPgamento_total.Name = "tbPgamento_total";
            this.tbPgamento_total.ReadOnly = true;
            this.tbPgamento_total.Size = new System.Drawing.Size(120, 26);
            this.tbPgamento_total.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(134, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total:";
            // 
            // btnCancelar_vendas
            // 
            this.btnCancelar_vendas.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelar_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar_vendas.ForeColor = System.Drawing.Color.White;
            this.btnCancelar_vendas.Location = new System.Drawing.Point(100, 597);
            this.btnCancelar_vendas.Name = "btnCancelar_vendas";
            this.btnCancelar_vendas.Size = new System.Drawing.Size(255, 46);
            this.btnCancelar_vendas.TabIndex = 28;
            this.btnCancelar_vendas.Text = "Finalizar Venda";
            this.btnCancelar_vendas.UseVisualStyleBackColor = false;
            this.btnCancelar_vendas.Click += new System.EventHandler(this.btnCancelar_vendas_Click);
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelObs.Location = new System.Drawing.Point(30, 425);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(183, 31);
            this.labelObs.TabIndex = 29;
            this.labelObs.Text = "Observações:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(83, 468);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(284, 93);
            this.textBoxObs.TabIndex = 30;
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 670);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.btnCancelar_vendas);
            this.Controls.Add(this.tbPgamento_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPagamento_troco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPagamento_cartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPagamento_pix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrecoPagamento_dinheiro);
            this.Controls.Add(this.lbPreco_pagamento);
            this.Controls.Add(this.panelProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPagamentos";
            this.Text = "Tela Pagamentos";
            this.Load += new System.EventHandler(this.FrmPagamentos_Load);
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.TextBox tbPrecoPagamento_dinheiro;
        private System.Windows.Forms.Label lbPreco_pagamento;
        private System.Windows.Forms.TextBox tbPagamento_pix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPagamento_cartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPagamento_troco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar_vendas;
        public System.Windows.Forms.TextBox tbPgamento_total;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.TextBox textBoxObs;
    }
}