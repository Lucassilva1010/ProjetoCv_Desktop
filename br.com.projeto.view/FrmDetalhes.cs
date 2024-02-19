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
    public partial class FrmDetalhes : Form
    {
        int venda_id;
        public FrmDetalhes( int idVenda)
        {
            venda_id = idVenda;
            InitializeComponent();
        }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            //Carrega a tela de Detalhes 
            ItenVendaDao itenVendaDao = new ItenVendaDao();
            //O id esta vindo da outra tela por meio do construtor
            dataGridListaDeItens.DataSource = itenVendaDao.ListaItensPorVenda(venda_id);
        }
    }
}
