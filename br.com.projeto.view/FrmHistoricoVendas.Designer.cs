
namespace ProjetoCv.br.com.projeto.view
{
    partial class FrmHistoricoVendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.dateTimePicInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicFinal = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHistorico = new System.Windows.Forms.DataGridView();
            this.btnBuscar_historico = new System.Windows.Forms.Button();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProdutos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).BeginInit();
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
            this.panelProdutos.Size = new System.Drawing.Size(982, 99);
            this.panelProdutos.TabIndex = 6;
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.ForeColor = System.Drawing.Color.White;
            this.labelVendas.Location = new System.Drawing.Point(270, 18);
            this.labelVendas.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(435, 60);
            this.labelVendas.TabIndex = 1;
            this.labelVendas.Text = "Historico de vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar_historico);
            this.groupBox1.Controls.Add(this.dateTimePicFinal);
            this.groupBox1.Controls.Add(this.dateTimePicInicio);
            this.groupBox1.Controls.Add(this.lbDataFinal);
            this.groupBox1.Controls.Add(this.lbDataInicio);
            this.groupBox1.Location = new System.Drawing.Point(9, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDataInicio.Location = new System.Drawing.Point(21, 52);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(85, 20);
            this.lbDataInicio.TabIndex = 4;
            this.lbDataInicio.Text = "Data Inicio";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDataFinal.Location = new System.Drawing.Point(391, 52);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(82, 20);
            this.lbDataFinal.TabIndex = 5;
            this.lbDataFinal.Text = "Data Final";
            // 
            // dateTimePicInicio
            // 
            this.dateTimePicInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicInicio.Location = new System.Drawing.Point(112, 52);
            this.dateTimePicInicio.Name = "dateTimePicInicio";
            this.dateTimePicInicio.Size = new System.Drawing.Size(134, 26);
            this.dateTimePicInicio.TabIndex = 6;
            // 
            // dateTimePicFinal
            // 
            this.dateTimePicFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicFinal.Location = new System.Drawing.Point(479, 52);
            this.dateTimePicFinal.Name = "dateTimePicFinal";
            this.dateTimePicFinal.Size = new System.Drawing.Size(129, 26);
            this.dateTimePicFinal.TabIndex = 7;
            // 
            // dataGridViewHistorico
            // 
            this.dataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColData,
            this.ColCliente,
            this.ColTotal,
            this.ColObs});
            this.dataGridViewHistorico.Location = new System.Drawing.Point(6, 228);
            this.dataGridViewHistorico.Name = "dataGridViewHistorico";
            this.dataGridViewHistorico.Size = new System.Drawing.Size(964, 412);
            this.dataGridViewHistorico.TabIndex = 8;
            // 
            // btnBuscar_historico
            // 
            this.btnBuscar_historico.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscar_historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar_historico.ForeColor = System.Drawing.Color.White;
            this.btnBuscar_historico.Location = new System.Drawing.Point(706, 38);
            this.btnBuscar_historico.Name = "btnBuscar_historico";
            this.btnBuscar_historico.Size = new System.Drawing.Size(149, 46);
            this.btnBuscar_historico.TabIndex = 29;
            this.btnBuscar_historico.Text = "Buscar";
            this.btnBuscar_historico.UseVisualStyleBackColor = false;
            // 
            // ColCod
            // 
            this.ColCod.HeaderText = "Codígo";
            this.ColCod.Name = "ColCod";
            // 
            // ColData
            // 
            this.ColData.HeaderText = "Data da Venda";
            this.ColData.Name = "ColData";
            this.ColData.Width = 150;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.Width = 220;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.Width = 150;
            // 
            // ColObs
            // 
            this.ColObs.HeaderText = "OBS";
            this.ColObs.Name = "ColObs";
            this.ColObs.Width = 300;
            // 
            // FrmHistoricoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 652);
            this.Controls.Add(this.dataGridViewHistorico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHistoricoVendas";
            this.Text = "Historico de Vendas";
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicFinal;
        private System.Windows.Forms.DateTimePicker dateTimePicInicio;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.DataGridView dataGridViewHistorico;
        private System.Windows.Forms.Button btnBuscar_historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObs;
    }
}