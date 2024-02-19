
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmLogin
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
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.labNomeCliente = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelProdutos.Controls.Add(this.labelVendas);
            this.panelProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(519, 88);
            this.panelProdutos.TabIndex = 7;
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.ForeColor = System.Drawing.Color.White;
            this.labelVendas.Location = new System.Drawing.Point(58, 9);
            this.labelVendas.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(362, 60);
            this.labelVendas.TabIndex = 1;
            this.labelVendas.Text = "Faça o Seu Login";
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginEmail.Location = new System.Drawing.Point(116, 128);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(313, 26);
            this.tbLoginEmail.TabIndex = 9;
            // 
            // labNomeCliente
            // 
            this.labNomeCliente.AutoSize = true;
            this.labNomeCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labNomeCliente.Location = new System.Drawing.Point(51, 130);
            this.labNomeCliente.Name = "labNomeCliente";
            this.labNomeCliente.Size = new System.Drawing.Size(57, 20);
            this.labNomeCliente.TabIndex = 8;
            this.labNomeCliente.Text = "E-mail:";
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenha.Location = new System.Drawing.Point(116, 180);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(313, 26);
            this.tbSenha.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(51, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Senha: ";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(176, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 46);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 328);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoginEmail);
            this.Controls.Add(this.labNomeCliente);
            this.Controls.Add(this.panelProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.Text = "Seja bem vindo!";
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Label labelVendas;
        public System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.Label labNomeCliente;
        public System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}