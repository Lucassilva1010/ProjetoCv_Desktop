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

            //Sempre que executar o projeto, os dados que estão no banco de dados vão ser listados.
            ProdutoDao produtoDao = new ProdutoDao();
            dataGridView_TabelaProduto.DataSource = produtoDao.ListarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Ação para limpar a tela
            //Foi criado uma classe aonde criamos o Metodo para alimpar os controles.
            new Helpers().LimpaTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 - Passo: receber os dados de dentro do Objeto cliente. 

            Produto objproduto = new Produto();

            objproduto.Descricao = tbDescricao.Text;
            objproduto.Preco = decimal.Parse(tbPreco.Text);
            objproduto.QtdEstoque = int.Parse(tbQtdEstoque.Text);
            objproduto.For_Id = int.Parse(comboBoxFornecedorFk.SelectedValue.ToString());
         


            //2 - Passo: Criar um Objeto da classe Cliente DAO, e passar os dados para o metodo cadastrar.
            ProdutoDao fDao = new ProdutoDao();
            fDao.CadastrarProduto(objproduto);//Aqui se passa todos os dados recebidos da tela para o banco de dados

             //Ação para limpar a tela
            //Foi criado uma classe aonde criamos o Metodo para alimpar os controles.
            new Helpers().LimpaTela(this);

            //Recarega a lista de clientes
            dataGridView_TabelaProduto.DataSource = fDao.ListarProdutos();
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            ProdutoDao proDao = new ProdutoDao();
            Produto objProduto = new Produto();

            objProduto.ID = int.Parse(tbCodigo.Text);//Pega o valor da tela e envia para o objeto do tipo Cliente, que é o nosso modelo
            proDao.ExcluirProduto(objProduto);//Chama o metodo de excluir da classe de ação, e passa como parametro o objeto Modelo da classe Cliente

            //Recarega a lista de clientes
            dataGridView_TabelaProduto.DataSource = proDao.ListarProdutos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //1 - Passo: receber os dados de dentro do Objeto cliente. 

            Produto objProduto = new Produto();

            objProduto.ID = int.Parse(tbCodigo.Text);
            objProduto.Descricao = tbDescricao.Text;
            objProduto.Preco = decimal.Parse(tbPreco.Text);
            objProduto.QtdEstoque = int.Parse(tbQtdEstoque.Text);
            objProduto.For_Id = int.Parse(comboBoxFornecedorFk.SelectedValue.ToString());



            //2 - Passo: Criar um Objeto da classe Cliente DAO, e passar os dados para o metodo Alterar.
            ProdutoDao produtoDao = new ProdutoDao();
            produtoDao.AlterarProduto(objProduto);//Aqui se passa todos os dados recebidos da tela para o banco de dados

            new Helpers().LimpaTela(this);//Recarregar a tela (Limpa os campos)

            //Recarega a lista de clientes
            dataGridView_TabelaProduto.DataSource = produtoDao.ListarProdutos();
        }

        private void textBoxNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            //Esse evendo faz a listagem de nomes por digitação, usando o Evendo KeyPressa das propriedades

            string nomeABuscar = "%" + textBoxNomeBuscar.Text + "%";

            ProdutoDao ProdutoDao = new ProdutoDao();

            //dataGridView_ConsultaCliente.DataSource = clienteDao.BuscarClientesPorNome(id);
            dataGridView_TabelaProduto.DataSource = ProdutoDao.ListarProdutosPorLetras(nomeABuscar);
        }

        private void tbnPesquisar_Consulta_Click(object sender, EventArgs e)
        {
            //Botão para buscar os dados para mostrar na tabela 

            //Pesquisando por nome
            string nome = textBoxNomeBuscar.Text.ToLowerInvariant();
            // int id = int.Parse(textBoxNomeBuscar.Text);//Pesquisar por que a pesquisa por nome não deu certo

            ProdutoDao produtoDao = new ProdutoDao();

            //dataGridView_ConsultaCliente.DataSource = clienteDao.BuscarClientesPorNome(id);
            dataGridView_TabelaProduto.DataSource = produtoDao.BuscarProdutosPorNome(nome);

            //Condição para se ele não encontrar nenhum valor, ou tiver em branco a pesquisa, retornar todos os valores da tabela 

            if (dataGridView_TabelaProduto.Rows.Count == 0 || textBoxNomeBuscar.Text == string.Empty)
            {
                //Recarega a lista de clientes
                MessageBox.Show("Produto Não encontrado ");
                dataGridView_TabelaProduto.DataSource = produtoDao.ListarProdutos();
            }
        }
        
        private void dataGridView_TabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Esse evendo foi criado a partir do campo de propriedades, clicando em eventos e depois em CelClick

            // 1 - Pegar os dados da linha selecionada, para aparecer nos campos de cadastro, pegando da coluna/indice 0
            tbCodigo.Text = dataGridView_TabelaProduto.CurrentRow.Cells[0].Value.ToString();
            tbDescricao.Text = dataGridView_TabelaProduto.CurrentRow.Cells[1].Value.ToString();
            tbPreco.Text = dataGridView_TabelaProduto.CurrentRow.Cells[2].Value.ToString();
            tbQtdEstoque.Text = dataGridView_TabelaProduto.CurrentRow.Cells[3].Value.ToString();
            
            comboBoxFornecedorFk.Text = dataGridView_TabelaProduto.CurrentRow.Cells[4].Value.ToString();

            //Ação para quando clicar/selecionar 2x, um cliente listado, mudar para a tela de Cadastro de Clientes
            tabProdutos.SelectedTab = tabPageCadProduto;
        }
    }
}
