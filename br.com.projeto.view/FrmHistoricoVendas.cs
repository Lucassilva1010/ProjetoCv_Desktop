using ProjetoCv.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCv.br.com.projeto.view
{
    public partial class FrmHistoricoVendas : Form
    {
        public FrmHistoricoVendas()
        {
            InitializeComponent();
        }

        private void btnBuscar_historico_Click(object sender, EventArgs e)
        {
            //Evento para retornar os valores do Metodo de Historico de vendas da classe Vendas

            DateTime dataInicio, dataFim;
            dataInicio = Convert.ToDateTime(dateTimePicInicio.Value.ToString("yyyy-MM-dd"));
            dataFim = Convert.ToDateTime(dateTimePicFinal.Value.ToString("yyyy-MM-dd"));

            VendaDao vendaDao = new VendaDao();

            dataGridViewHistorico.DataSource = vendaDao.ListaVendasPorPeriodo(dataInicio, dataFim);

        }

        private void FrmHistoricoVendas_Load(object sender, EventArgs e)
        {
            VendaDao vendaDao = new VendaDao();
            dataGridViewHistorico.DataSource = vendaDao.ListarVendas();
            dataGridViewHistorico.DefaultCellStyle.ForeColor = Color.Black;//Deixa as letras em cores pretas
        }
    }
}
