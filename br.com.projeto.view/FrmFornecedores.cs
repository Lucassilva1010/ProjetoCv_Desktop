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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {

            //Buscar CEP em API
            try
            {
                //Buscando o valor digitado na tela 
                string cep = maskedTBCep.Text;
                //pansando o valor da variavel para a URL da API
                string xmlCep = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();//Cahce de dados em memoria

                dados.ReadXml(xmlCep);//Ler todos os dados que tem dentro do xml da API

                tbEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();//Pegando o valor da APi e subtituindo o valor do campo - Rua(na API está Logradouro)
                tbComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();//Pegando o valor da APi e subtituindo o valor do campo - Complemento
                tbBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();//Pegando o valor da APi e subtituindo o valor do campo - Bairro
                tbCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();//Pegando o valor da APi e subtituindo o valor do campo - Bairro
                comboBoxUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();//Pegando o valor da APi e subtituindo o valor do campo - Bairro

            }
            catch (Exception)
            {

                MessageBox.Show("CEP Não encontrado!" +
                    "Por Favor Adicione o CEP Manualmente!");

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Ação para limpar a tela
            //Foi criado uma classe aonde criamos o Metodo para alimpar os controles.
            new Helpers().LimpaTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Cadastrar ps Forncedores
            //1 - Passo: receber os dados de dentro do Objeto cliente. 

            Fornecedor objFonecedor = new Fornecedor();

            objFonecedor.Nome = tbNome.Text;
            objFonecedor.Cnpj = maskedTBCnpj.Text;
            objFonecedor.Email = tbEmail.Text;
            objFonecedor.Telefone = maskedTBTel.Text;
            objFonecedor.Celular = maskedTBCel.Text;
            objFonecedor.Cep = maskedTBCep.Text;
            objFonecedor.Endereco = tbEndereco.Text;
            objFonecedor.Numero = int.Parse(tbNumero.Text);
            objFonecedor.Complemento = tbComplemento.Text;
            objFonecedor.Bairro = tbBairro.Text;
            objFonecedor.Cidade = tbCidade.Text;
            objFonecedor.Estado = comboBoxUf.Text;


            //2 - Passo: Criar um Objeto da classe Cliente DAO, e passar os dados para o metodo cadastrar.
            FornecedorDao fDao = new FornecedorDao();
            fDao.CadastrarFornecedor(objFonecedor);//Aqui se passa todos os dados recebidos da tela para o banco de dados


            //Recarega a lista de clientes
            dataGridView_TabelaFornecedores.DataSource = fDao.ListarFornecedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            FornecedorDao fornecedorDao = new FornecedorDao();
            Fornecedor objcFonecedor = new Fornecedor();

            objcFonecedor.ID = int.Parse(tbCodigo.Text);//Pega o valor da tela e envia para o objeto do tipo Cliente, que é o nosso modelo
            fornecedorDao.ExcluirFornecedor(objcFonecedor);//Chama o metodo de excluir da classe de ação, e passa como parametro o objeto Modelo da classe Cliente

            //Recarega a lista de clientes
            dataGridView_TabelaFornecedores.DataSource = fornecedorDao.ListarFornecedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //1 - Passo: receber os dados de dentro do Objeto cliente. 

            Fornecedor objFornecedor = new Fornecedor();

            objFornecedor.ID = int.Parse(tbCodigo.Text);
            objFornecedor.Nome = tbNome.Text;
            objFornecedor.Cnpj = maskedTBCnpj.Text;
            objFornecedor.Email = tbEmail.Text;
            objFornecedor.Telefone = maskedTBTel.Text;
            objFornecedor.Celular = maskedTBCel.Text;
            objFornecedor.Cep = maskedTBCep.Text;
            objFornecedor.Endereco = tbEndereco.Text;
            objFornecedor.Numero = int.Parse(tbNumero.Text);
            objFornecedor.Complemento = tbComplemento.Text;
            objFornecedor.Bairro = tbBairro.Text;
            objFornecedor.Cidade = tbCidade.Text;
            objFornecedor.Estado = comboBoxUf.Text;

            //2 - Passo: Criar um Objeto da classe Cliente DAO, e passar os dados para o metodo cadastrar.
            FornecedorDao fDao = new FornecedorDao();
            fDao.AlterarFornecedor(objFornecedor);//Aqui se passa todos os dados recebidos da tela para o banco de dados


            //Recarega a lista de clientes
           dataGridView_TabelaFornecedores.DataSource = fDao.ListarFornecedores();
        }

        private void tbnPesquisar_Consulta_Click(object sender, EventArgs e)
        {

            //Botão para buscar os dados para mostrar na tabela 

            //Pesquisando por nome
            string nome = textBoxNomeBuscar.Text.ToLowerInvariant();
            // int id = int.Parse(textBoxNomeBuscar.Text);//Pesquisar por que a pesquisa por nome não deu certo

            FornecedorDao forncedorDao = new FornecedorDao();

            //dataGridView_ConsultaCliente.DataSource = clienteDao.BuscarClientesPorNome(id);
            dataGridView_TabelaFornecedores.DataSource = forncedorDao.BuscarFornecedoresPorNome(nome);

            //Condição para se ele não encontrar nenhum valor, ou tiver em branco a pesquisa, retornar todos os valores da tabela 

            if (dataGridView_TabelaFornecedores.Rows.Count == 0 || textBoxNomeBuscar.Text == string.Empty)
            {
                //Recarega a lista de clientes
                MessageBox.Show("Funcionário Não encontrado ");
                dataGridView_TabelaFornecedores.DataSource = forncedorDao.ListarFornecedores();
            }
        }

        private void textBoxNomeBuscar_TextChanged(object sender, EventArgs e)
        {

            //Esse evendo faz a listagem de nomes por digitação, usando o Evendo KeyPressa das propriedades

            string nomeABuscar = "%" + textBoxNomeBuscar.Text + "%";

            FornecedorDao FuncionarioDao = new FornecedorDao();

            //dataGridView_ConsultaCliente.DataSource = clienteDao.BuscarClientesPorNome(id);
            dataGridView_TabelaFornecedores.DataSource = FuncionarioDao.ListarFornecedoresPorNomeEletras(nomeABuscar);
        }

        private void dataGridView_TabelaFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Esse evendo foi criado a partir do campo de propriedades, clicando em eventos e depois em CelClick

            // 1 - Pegar os dados da linha selecionada, para aparecer nos campos de cadastro, pegando da coluna/indice 0
            tbCodigo.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            maskedTBCnpj.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            tbEmail.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            maskedTBTel.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            maskedTBCel.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            maskedTBCep.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            tbEndereco.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            tbNumero.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            tbComplemento.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            tbBairro.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            tbCidade.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            comboBoxUf.Text = dataGridView_TabelaFornecedores.CurrentRow.Cells[12].Value.ToString();

            //Ação para quando clicar/selecionar 2x, um cliente listado, mudar para a tela de Cadastro de Clientes
            tabFornecedor.SelectedTab = tabPageCadFornecedor;
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {

            FornecedorDao FomularioDao = new FornecedorDao();
            //Sempre que executar o projeto, os dados que estão no banco de dados vão ser listados.
            dataGridView_TabelaFornecedores.DataSource = FomularioDao.ListarFornecedores();
        }
    }
}
