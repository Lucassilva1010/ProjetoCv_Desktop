
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmClientes
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
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbCel = new System.Windows.Forms.Label();
            this.maskedTBG = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBCel = new System.Windows.Forms.MaskedTextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.maskedTBCep = new System.Windows.Forms.MaskedTextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUf = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnPesquisar_Consulta = new System.Windows.Forms.Button();
            this.dataGridView_ConsultaCliente = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage1);
            this.tabClientes.Controls.Add(this.tabPage2);
            this.tabClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.Location = new System.Drawing.Point(7, 114);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(943, 348);
            this.tabClientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxUf);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbCidade);
            this.tabPage1.Controls.Add(this.lbCidade);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbComplemento);
            this.tabPage1.Controls.Add(this.lbComplemento);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.lbNumero);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lbEndereco);
            this.tabPage1.Controls.Add(this.maskedTBCep);
            this.tabPage1.Controls.Add(this.lbCep);
            this.tabPage1.Controls.Add(this.maskedTBCel);
            this.tabPage1.Controls.Add(this.maskedTBTel);
            this.tabPage1.Controls.Add(this.maskedTBCpf);
            this.tabPage1.Controls.Add(this.maskedTBG);
            this.tabPage1.Controls.Add(this.lbCel);
            this.tabPage1.Controls.Add(this.lbTel);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.lbEmail);
            this.tabPage1.Controls.Add(this.lbCpf);
            this.tabPage1.Controls.Add(this.lbRg);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.lbNome);
            this.tabPage1.Controls.Add(this.tbCodigo);
            this.tabPage1.Controls.Add(this.labCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_ConsultaCliente);
            this.tabPage2.Controls.Add(this.tbnPesquisar_Consulta);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.labCodigo.Click += new System.EventHandler(this.labCodigo_Click);
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
            // maskedTBG
            // 
            this.maskedTBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBG.Location = new System.Drawing.Point(506, 70);
            this.maskedTBG.Mask = "##.###.###-##";
            this.maskedTBG.Name = "maskedTBG";
            this.maskedTBG.Size = new System.Drawing.Size(114, 26);
            this.maskedTBG.TabIndex = 14;
            // 
            // maskedTBCpf
            // 
            this.maskedTBCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBCpf.Location = new System.Drawing.Point(706, 71);
            this.maskedTBCpf.Mask = "###.###.###-##";
            this.maskedTBCpf.Name = "maskedTBCpf";
            this.maskedTBCpf.Size = new System.Drawing.Size(114, 26);
            this.maskedTBCpf.TabIndex = 15;
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
            // maskedTBCel
            // 
            this.maskedTBCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBCel.Location = new System.Drawing.Point(748, 123);
            this.maskedTBCel.Mask = "(99) 0 0000-0000";
            this.maskedTBCel.Name = "maskedTBCel";
            this.maskedTBCel.Size = new System.Drawing.Size(132, 26);
            this.maskedTBCel.TabIndex = 17;
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
            // maskedTBCep
            // 
            this.maskedTBCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTBCep.Location = new System.Drawing.Point(83, 167);
            this.maskedTBCep.Mask = "00.000-999";
            this.maskedTBCep.Name = "maskedTBCep";
            this.maskedTBCep.Size = new System.Drawing.Size(119, 26);
            this.maskedTBCep.TabIndex = 19;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEndereco.Location = new System.Drawing.Point(216, 171);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(82, 20);
            this.lbEndereco.TabIndex = 20;
            this.lbEndereco.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(299, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(589, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 26);
            this.textBox2.TabIndex = 23;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNumero.Location = new System.Drawing.Point(558, 171);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(30, 20);
            this.lbNumero.TabIndex = 22;
            this.lbNumero.Text = "Nº:";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbComplemento.Location = new System.Drawing.Point(661, 172);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(112, 20);
            this.lbComplemento.TabIndex = 24;
            this.lbComplemento.Text = "Complemento:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.tbComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComplemento.Location = new System.Drawing.Point(777, 171);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(149, 26);
            this.tbComplemento.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(83, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 26);
            this.textBox3.TabIndex = 27;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // comboBoxUf
            // 
            this.comboBoxUf.FormattingEnabled = true;
            this.comboBoxUf.Items.AddRange(new object[] {
            "",
            "    AC",
            "    AL",
            "    AP",
            "    AM",
            "    BA",
            "    CE",
            "    DF",
            "    ES",
            "    GO",
            "    MA",
            "    MT",
            "    MS",
            "    MG",
            "    PA",
            "    PB",
            "    PR",
            "    PE",
            "    PI",
            "    RJ",
            "    RN",
            "    RS",
            "    RO",
            "    RR",
            "    SC",
            "    SP",
            "    SE",
            "    TO"});
            this.comboBoxUf.Location = new System.Drawing.Point(592, 214);
            this.comboBoxUf.Name = "comboBoxUf";
            this.comboBoxUf.Size = new System.Drawing.Size(108, 28);
            this.comboBoxUf.TabIndex = 31;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(109, 468);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 61);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(283, 468);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 61);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(451, 468);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(148, 61);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(619, 468);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 61);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(69, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(367, 26);
            this.textBox4.TabIndex = 5;
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
            // 
            // dataGridView_ConsultaCliente
            // 
            this.dataGridView_ConsultaCliente.AllowUserToAddRows = false;
            this.dataGridView_ConsultaCliente.AllowUserToDeleteRows = false;
            this.dataGridView_ConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ConsultaCliente.Location = new System.Drawing.Point(4, 52);
            this.dataGridView_ConsultaCliente.Name = "dataGridView_ConsultaCliente";
            this.dataGridView_ConsultaCliente.ReadOnly = true;
            this.dataGridView_ConsultaCliente.Size = new System.Drawing.Size(918, 257);
            this.dataGridView_ConsultaCliente.TabIndex = 7;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 554);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabClientes);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClientes";
            this.Text = "Cadastro de Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConsultaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox maskedTBCpf;
        private System.Windows.Forms.MaskedTextBox maskedTBG;
        private System.Windows.Forms.Label lbCel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MaskedTextBox maskedTBCel;
        private System.Windows.Forms.MaskedTextBox maskedTBTel;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.MaskedTextBox maskedTBCep;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.ComboBox comboBoxUf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridView_ConsultaCliente;
        private System.Windows.Forms.Button tbnPesquisar_Consulta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
    }
}