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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;

            //Formantando os Campos do Footer do painel

            toolStripData.Text = data.ToString("dd/MM/yy");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            toolStripSHora.Text = hora.ToString("HH:mm:ss");
        }

        private void toolStripData_Click(object sender, EventArgs e)
        {


        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre pagina de cadastro
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a pagina de cadastro, porém abre na aba de consultas
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.tabClientes.SelectedTab = frmClientes.tabPage2;
            frmClientes.ShowDialog();
        }

        private void cadastroDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a Pagina de cadastro de funcionario
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.ShowDialog();
        }

        private void consultarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a apagina de funcionario com a aba de Sonculta de funcionario como Primaria
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.tabFuncionario.SelectedTab = frmFuncionario.tabPage2;
            frmFuncionario.ShowDialog();
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abra a pagina de cadastro de Fornecedores
            FrmFornecedores frmFornecedores = new FrmFornecedores();
            frmFornecedores.ShowDialog();
        }

        private void consultrarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Abre a pagina de cadastro de Fornecedores, mas com a tela de consulta fornecedores como principal
            FrmFornecedores frmFornecedores = new FrmFornecedores();
            frmFornecedores.tabFornecedor.SelectedTab = frmFornecedores.tabPageFornecedor;
            frmFornecedores.ShowDialog();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a pagina de Produtos
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.ShowDialog();

        }

        private void listarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a pagina de Produtos
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.tabProdutos.SelectedTab = frmProdutos.tabPageFornecedor;//Essa segunda TAB, ficou com o nome errado(Depois é preciso trocar e ajustar o nome)
            frmProdutos.ShowDialog();

        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a tela de vendas
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.ShowDialog();
        }

        private void históricoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abra a tela de Historico de vendas
            FrmHistoricoVendas frmHistorico = new FrmHistoricoVendas();
            frmHistorico.ShowDialog();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Encerra o sistema
            //Isso faz com que apareça uma notificação apra o usuario antes de encerrar, e mostra 2 opções, como SIM E NÂO
            DialogResult dialog = MessageBox.Show("Deseja encerrar o sistema?","Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Validação do Botão 
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void trocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }
    }
}
