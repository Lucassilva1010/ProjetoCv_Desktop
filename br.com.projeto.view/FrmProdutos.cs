using ProjetoCv.br.com.projeto.dao;
using ProjetoCv.br.com.projeto.model;
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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            //Evento criado clicando 2x na area Sinza da tela, ou também pode ser acionada clicando na TAB e depois indo nos Eventos
            //Isso vai fazer com que a lista de fornecedores apareça la na listagem do combobox no cadastro dos produtos
            FornecedorDao fornecedorDao = new FornecedorDao();
            comboBoxFornecedorFk.DataSource = fornecedorDao.ListarFornecedores();

            //isso vai fazer com que eu mostre o nome do fornecedor e também chame o ID do produto para ser referenciado como uma ChaveExtrangeira
            comboBoxFornecedorFk.DisplayMember = "nome";//Isso traz o nome do fornocedor, mas poderia qualquer outra informação.
            comboBoxFornecedorFk.ValueMember = "id";//Isso trazer o numero do Id Referente aquele fornecedor
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Ação para limpar a tela
            //Foi criado uma classe aonde criamos o Metodo para alimpar os controles.
            new Helpers().LimpaTela(this);
        }
    }
}
