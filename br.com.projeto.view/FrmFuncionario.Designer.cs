
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFuncionario = new System.Windows.Forms.TabControl();
            this.tabPageCadFuncionario = new System.Windows.Forms.TabPage();
            this.cboBoxCargo = new System.Windows.Forms.ComboBox();
            this.cboBoxTipoAcesso = new System.Windows.Forms.ComboBox();
            this.lbAcesso = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.comboBoxUf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.maskedTBCep = new System.Windows.Forms.MaskedTextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.maskedTBCel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTbRG = new System.Windows.Forms.MaskedTextBox();
            this.lbCel = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_TabelaFuncionario = new System.Windows.Forms.DataGridView();
            this.tbnPesquisar_Consulta = new System.Windows.Forms.Button();
            this.textBoxNomeBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            this.tabPageCadFuncionario.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabelaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Funcionario";
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.Controls.Add(this.tabPageCadFuncionario);
            this.tabFuncionario.Controls.Add(this.tabPage2);
            this.tabFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFuncionario.Location = new System.Drawing.Point(12, 106);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.SelectedIndex = 0;
            this.tabFuncionario.Size = new System.Drawing.Size(1170, 413);
            this.tabFuncionario.TabIndex = 2;
            // 
            // tabPageCadFuncionario
            // 
            this.tabPageCadFuncionario.Controls.Add(this.cboBoxCargo);
            this.tabPageCadFuncionario.Controls.Add(this.cboBoxTipoAcesso);
            this.tabPageCadFuncionario.Controls.Add(this.lbAcesso);
            this.tabPageCadFuncionario.Controls.Add(this.tbSenha);
            this.tabPageCadFuncionario.Controls.Add(this.lbSenha);
            this.tabPageCadFuncionario.Controls.Add(this.lbCargo);
            this.tabPageCadFuncionario.Controls.Add(this.btnPesquisarCep);
            this.tabPageCadFuncionario.Controls.Add(this.comboBoxUf);
            this.tabPageCadFuncionario.Controls.Add(this.label4);
            this.tabPageCadFuncionario.Controls.Add(this.tbCidade);
            this.tabPageCadFuncionario.Controls.Add(this.lbCidade);
            this.tabPageCadFuncionario.Controls.Add(this.tbBairro);
            this.tabPageCadFuncionario.Controls.Add(this.label2);
            this.tabPageCadFuncionario.Controls.Add(this.tbComplemento);
            this.tabPageCadFuncionario.Controls.Add(this.lbComplemento);
            this.tabPageCadFuncionario.Controls.Add(this.tbNumero);
            this.tabPageCadFuncionario.Controls.Add(this.lbNumero);
            this.tabPageCadFuncionario.Controls.Add(this.tbEndereco);
            this.tabPageCadFuncionario.Controls.Add(this.lbEndereco);
            this.tabPageCadFuncionario.Controls.Add(this.maskedTBCep);
            this.tabPageCadFuncionario.Controls.Add(this.lbCep);
            this.tabPageCadFuncionario.Controls.Add(this.maskedTBCel);
            this.tabPageCadFuncionario.Controls.Add(this.maskedTBTel);
            this.tabPageCadFuncionario.Controls.Add(this.maskedTBCpf);
            this.tabPageCadFuncionario.Controls.Add(this.maskedTbRG);
            this.tabPageCadFuncionario.Controls.Add(this.lbCel);
            this.tabPageCadFuncionario.Controls.Add(this.lbTel);
            this.tabPageCadFuncionario.Controls.Add(this.tbEmail);
            this.tabPageCadFuncionario.Controls.Add(this.lbEmail);
            this.tabPageCadFuncionario.Controls.Add(this.lbCpf);
            this.tabPageCadFuncionario.Controls.Add(this.lbRg);
            this.tabPageCadFuncionario.Controls.Add(this.tbNome);
            this.tabPageCadFuncionario.Controls.Add(this.lbNome);
            this.tabPageCadFuncionario.Controls.Add(this.tbCodigo);
            this.tabPageCadFuncionario.Controls.Add(this.labCodigo);
            this.tabPageCadFuncionario.Location = new System.Drawing.Point(4, 29);
            this.tabPageCadFuncionario.Name = "tabPageCadFuncionario";
            this.tabPageCadFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadFuncionario.Size = new System.Drawing.Size(1162, 380);
            this.tabPageCadFuncionario.TabIndex = 0;
            this.tabPageCadFuncionario.Text = "Dados Pessoais";
            this.tabPageCadFuncionario.UseVisualStyleBackColor = true;
            // 
            // cboBoxCargo
            // 
            this.cboBoxCargo.FormattingEnabled = true;
            this.cboBoxCargo.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor"});
            this.cboBoxCargo.Location = new System.Drawing.Point(739, 288);
            this.cboBoxCargo.Name = "cboBoxCargo";
            this.cboBoxCargo.Size = new System.Drawing.Size(200, 28);
            this.cboBoxCargo.TabIndex = 38;
            // 
            // cboBoxTipoAcesso
            // 
            this.cboBoxTipoAcesso.FormattingEnabled = true;
            this.cboBoxTipoAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cboBoxTipoAcesso.Location = new System.Drawing.Point(433, 285);
            this.cboBoxTipoAcesso.Name = "cboBoxTipoAcesso";
            this.cboBoxTipoAcesso.Size = new System.Drawing.Size(200, 28);
            this.cboBoxTipoAcesso.TabIndex = 37;
            // 
            // lbAcesso
            // 
            this.lbAcesso.AutoSize = true;
            this.lbAcesso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbAcesso.Location = new System.Drawing.Point(305, 288);
            this.lbAcesso.Name = "lbAcesso";
            this.lbAcesso.Size = new System.Drawing.Size(124, 20);
            this.lbAcesso.TabIndex = 36;
            this.lbAcesso.Text = "Tipo de acesso: ";
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenha.Location = new System.Drawing.Point(83, 282);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(152, 26);
            this.tbSenha.TabIndex = 35;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSenha.Location = new System.Drawing.Point(17, 284);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(60, 20);
            this.lbSenha.TabIndex = 34;
            this.lbSenha.Text = "Senha:";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCargo.Location = new System.Drawing.Point(678, 288);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(56, 20);
            this.lbCargo.TabIndex = 32;
            this.lbCargo.Text = "Cargo:";
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisarCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCep.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCep.Location = new System.Drawing.Point(210, 164);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(92, 33);
            this.btnPesquisarCep.TabIndex = 6;
            this.btnPesquisarCep.Text = "Pesquisar";
            this.btnPesquisarCep.UseVisualStyleBackColor = false;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // comboBoxUf
            // 
            this.comboBoxUf.FormattingEnabled = true;
            this.comboBoxUf.Location = new System.Drawing.Point(592, 214);
            this.comboBoxUf.Name = "comboBoxUf";
            this.comboBoxUf.Size = new System.Drawing.Size(108, 28);
            this.comboBoxUf.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(523, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Estado:";
            // 
            // tbCidade
            // 
            this.tbCidade.BackColor = System.Drawing.SystemColors.Window;
            this.tbCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCidade.Location = new System.Drawing.Point(334, 215);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(152, 26);
            this.tbCidade.TabIndex = 29;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCidade.Location = new System.Drawing.Point(268, 217);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(63, 20);
            this.lbCidade.TabIndex = 28;
            this.lbCidade.Text = "Cidade:";
            // 
            // tbBairro
            // 
            this.tbBairro.BackColor = System.Drawing.SystemColors.Window;
            this.tbBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBairro.Location = new System.Drawing.Point(83, 215);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(152, 26);
            this.tbBairro.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(17, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bairro:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.tbComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComplemento.Location = new System.Drawing.Point(914, 171);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(149, 26);
            this.tbComplemento.TabIndex = 25;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbComplemento.Location = new System.Drawing.Point(798, 172);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(112, 20);
            this.lbComplemento.TabIndex = 24;
            this.lbComplemento.Text = "Complemento:";
            // 
            // tbNumero
            // 
            this.tbNumero.BackColor = System.Drawing.SystemColors.Window;
            this.tbNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumero.Location = new System.Drawing.Point(726, 169);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(56, 26);
            this.tbNumero.TabIndex = 23;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNumero.Location = new System.Drawing.Point(695, 171);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(30, 20);
            this.lbNumero.TabIndex = 22;
            this.lbNumero.Text = "Nº:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndereco.Location = new System.Drawing.Point(436, 169);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(250, 26);
            this.tbEndereco.TabIndex = 21;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEndereco.Location = new System.Drawing.Point(353, 171);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(82, 20);
            this.lbEndereco.TabIndex = 20;
            this.lbEndereco.Text = "Endereço:";
            // 
            // maskedTBCep
            // 
            this.maskedTBCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBCep.Location = new System.Drawing.Point(83, 167);
            this.maskedTBCep.Mask = "00000-999";
            this.maskedTBCep.Name = "maskedTBCep";
            this.maskedTBCep.Size = new System.Drawing.Size(119, 26);
            this.maskedTBCep.TabIndex = 19;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCep.Location = new System.Drawing.Point(20, 167);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(45, 20);
            this.lbCep.TabIndex = 18;
            this.lbCep.Text = "CEP:";
            // 
            // maskedTBCel
            // 
            this.maskedTBCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBCel.Location = new System.Drawing.Point(748, 123);
            this.maskedTBCel.Mask = "(99) 0 0000-0000";
            this.maskedTBCel.Name = "maskedTBCel";
            this.maskedTBCel.Size = new System.Drawing.Size(132, 26);
            this.maskedTBCel.TabIndex = 17;
            // 
            // maskedTBTel
            // 
            this.maskedTBTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBTel.Location = new System.Drawing.Point(546, 123);
            this.maskedTBTel.Mask = "(99) 0000-0000";
            this.maskedTBTel.Name = "maskedTBTel";
            this.maskedTBTel.Size = new System.Drawing.Size(119, 26);
            this.maskedTBTel.TabIndex = 16;
            // 
            // maskedTBCpf
            // 
            this.maskedTBCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBCpf.Location = new System.Drawing.Point(706, 71);
            this.maskedTBCpf.Mask = "###,###,###-##";
            this.maskedTBCpf.Name = "maskedTBCpf";
            this.maskedTBCpf.Size = new System.Drawing.Size(114, 26);
            this.maskedTBCpf.TabIndex = 15;
            // 
            // maskedTbRG
            // 
            this.maskedTbRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTbRG.Location = new System.Drawing.Point(506, 70);
            this.maskedTbRG.Mask = "##,###,###-##";
            this.maskedTbRG.Name = "maskedTbRG";
            this.maskedTbRG.Size = new System.Drawing.Size(114, 26);
            this.maskedTbRG.TabIndex = 14;
            // 
            // lbCel
            // 
            this.lbCel.AutoSize = true;
            this.lbCel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCel.Location = new System.Drawing.Point(680, 125);
            this.lbCel.Name = "lbCel";
            this.lbCel.Size = new System.Drawing.Size(62, 20);
            this.lbCel.TabIndex = 12;
            this.lbCel.Text = "Celular:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTel.Location = new System.Drawing.Point(465, 123);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(75, 20);
            this.lbTel.TabIndex = 10;
            this.lbTel.Text = "Telefone:";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Location = new System.Drawing.Point(83, 119);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(367, 26);
            this.tbEmail.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEmail.Location = new System.Drawing.Point(20, 121);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCpf.Location = new System.Drawing.Point(656, 75);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(44, 20);
            this.lbCpf.TabIndex = 6;
            this.lbCpf.Text = "CPF:";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbRg.Location = new System.Drawing.Point(464, 73);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(38, 20);
            this.lbRg.TabIndex = 4;
            this.lbRg.Text = "RG:";
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.SystemColors.Window;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Location = new System.Drawing.Point(83, 71);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(367, 26);
            this.tbNome.TabIndex = 3;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNome.Location = new System.Drawing.Point(20, 71);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_TabelaFuncionario);
            this.tabPage2.Controls.Add(this.tbnPesquisar_Consulta);
            this.tabPage2.Controls.Add(this.textBoxNomeBuscar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TabelaFuncionario
            // 
            this.dataGridView_TabelaFuncionario.AllowUserToAddRows = false;
            this.dataGridView_TabelaFuncionario.AllowUserToDeleteRows = false;
            this.dataGridView_TabelaFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TabelaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TabelaFuncionario.Location = new System.Drawing.Point(4, 52);
            this.dataGridView_TabelaFuncionario.Name = "dataGridView_TabelaFuncionario";
            this.dataGridView_TabelaFuncionario.ReadOnly = true;
            this.dataGridView_TabelaFuncionario.Size = new System.Drawing.Size(1152, 257);
            this.dataGridView_TabelaFuncionario.TabIndex = 7;
            this.dataGridView_TabelaFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TabelaFuncionario_CellClick);
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
            this.btnEditar.Location = new System.Drawing.Point(721, 581);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 61);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(553, 581);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(148, 61);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(385, 581);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 61);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(211, 581);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 61);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabFuncionario);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFuncionario";
            this.Text = "Cadastro de Funcionarios";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFuncionario.ResumeLayout(false);
            this.tabPageCadFuncionario.ResumeLayout(false);
            this.tabPageCadFuncionario.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabelaFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageCadFuncionario;
        private System.Windows.Forms.Button btnPesquisarCep;
        private System.Windows.Forms.ComboBox comboBoxUf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.MaskedTextBox maskedTBCep;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.MaskedTextBox maskedTBCel;
        private System.Windows.Forms.MaskedTextBox maskedTBTel;
        private System.Windows.Forms.MaskedTextBox maskedTBCpf;
        private System.Windows.Forms.MaskedTextBox maskedTbRG;
        private System.Windows.Forms.Label lbCel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.DataGridView dataGridView_TabelaFuncionario;
        private System.Windows.Forms.Button tbnPesquisar_Consulta;
        private System.Windows.Forms.TextBox textBoxNomeBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBoxTipoAcesso;
        private System.Windows.Forms.Label lbAcesso;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.ComboBox cboBoxCargo;
        public System.Windows.Forms.TabControl tabFuncionario;
        public System.Windows.Forms.TabPage tabPage2;
    }
}