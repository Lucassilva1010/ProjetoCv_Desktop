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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 - Passo: receber os dados de dentro do Objeto cliente. 

            Funcionario objF = new Funcionario();

            objF.Nome = tbNome.Text;
            objF.Rg = maskedTbRG.Text;
            objF.Cpf = maskedTBCpf.Text;
            objF.Email = tbEmail.Text;
            objF.Telefone = maskedTBTel.Text;
            objF.Celular = maskedTBCel.Text;
            objF.Cep = maskedTBCep.Text;
            objF.Endereco = tbEndereco.Text;
            objF.Numero = int.Parse(tbNumero.Text);
            objF.Complemento = tbComplemento.Text;
            objF.Bairro = tbBairro.Text;
            objF.Cidade = tbCidade.Text;
            objF.Estado = comboBoxUf.Text;
            objF.Cargo = cboBoxCargo.Text;
            objF.NivelAcesso = cboBoxTipoAcesso.Text;
            objF.Senha = tbSenha.Text;


            //2 - Passo: Criar um Objeto da classe Cliente DAO, e passar os dados para o metodo cadastrar.
            FuncionariioDao fDao = new FuncionariioDao();
            fDao.CadastrarFuncionario(objF);//Aqui se passa todos os dados recebidos da tela para o banco de dados


            //Recarega a lista de clientes
            dataGridView_TabelaFuncionario.DataSource = fDao.ListarFuncionarios();

        }

        private void tbnPesquisar_Consulta_Click(object sender, EventArgs e)
        {
            //Botão para buscar os dados para mostrar na tabela 

            //Pesquisando por nome
            string nome = textBoxNomeBuscar.Text.ToLowerInvariant();
            // int id = int.Parse(textBoxNomeBuscar.Text);//Pesquisar por que a pesquisa por nome não deu certo

            FuncionariioDao funcionarioDao = new FuncionariioDao();

            //dataGridView_ConsultaCliente.DataSource = clienteDao.BuscarClientesPorNome(id);
            dataGridView_TabelaFuncionario.DataSource = funcionarioDao.BuscarFuncionariosPorNome(nome);

            //Condição para se ele não encontrar nenhum valor, ou tiver em branco a pesquisa, retornar todos os valores da tabela 

            if (dataGridView_TabelaFuncionario.Rows.Count == 0 || textBoxNomeBuscar.Text == string.Empty)
            {
                //Recarega a lista de clientes
                MessageBox.Show("Funcionário Não encontrado ");
                dataGridView_TabelaFuncionario.DataSource = funcionarioDao.ListarFuncionarios();
            }

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            FuncionariioDao fDao = new FuncionariioDao();
            Funcionario objcFuncionario = new Funcionario();

            objcFuncionario.ID = int.Parse(tbCodigo.Text);//Pega o valor da tela e envia para o objeto do tipo Cliente, que é o nosso modelo
            fDao.ExcluirFuncionario(objcFuncionario);//Chama o metodo de excluir da classe de ação, e passa como parametro o objeto Modelo da classe Cliente

            //Recarega a lista de clientes
            dataGridView_TabelaFuncionario.DataSource = fDao.ListarFuncionarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //1 - Passo: receber os dados de dentro do Objeto cliente. 

            Funcionario objF = new Funcionario();

            objF.ID = int.Parse(tbCodigo.Text);
            objF.Nome = tbNome.Text;
            objF.Rg = maskedTbRG.Text;
            objF.Cpf = maskedTBCpf.Text;
            objF.Email = tbEmail.Text;
            objF.Telefone = maskedTBTel.Text;
            objF.Celular = maskedTBCel.Text;
            objF.Cep = maskedTBCep.Text;
            objF.Endereco = tbEndereco.Text;
            objF.Numero = int.Parse(tbNumero.Text);
            objF.Complemento = tbComplemento.Text;
            objF.Bairro = tbBairro.Text;
            objF.Cidade = tbCidade.Text;
            objF.Estado = comboBoxUf.Text;
            objF.Cargo = cboBoxCargo.Text;
            objF.NivelAcesso = cboBoxTipoAcesso.Text;
            objF.Senha = tbSenha.Text;

            //2 - Passo: Criar um Objeto da classe Cliente DAO, e passar os dados para o metodo cadastrar.
            FuncionariioDao fDao = new FuncionariioDao();
            fDao.AlterarFuncionario(objF);//Aqui se passa todos os dados recebidos da tela para o banco de dados


            //Recarega a lista de clientes
            dataGridView_TabelaFuncionario.DataSource = fDao.ListarFuncionarios();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Ação para limpar a tela
            //Foi criado uma classe aonde criamos o Metodo para alimpar os controles.
            new Helpers().LimpaTela(this);
        }

        private void textBoxNomeBuscar_TextChanged(object sender, EventArgs e)
        {

            //Esse evendo faz a listagem de nomes por digitação, usando o Evendo KeyPressa das propriedades

            string nomeABuscar = "%" + textBoxNomeBuscar.Text + "%";

            FuncionariioDao FuncionarioDao = new FuncionariioDao();

            //dataGridView_ConsultaCliente.DataSource = clienteDao.BuscarClientesPorNome(id);
            dataGridView_TabelaFuncionario.DataSource = FuncionarioDao.ListarFuncionarioPorNomeEletras (nomeABuscar);
        }

        private void dataGridView_TabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esse evendo foi criado a partir do campo de propriedades, clicando em eventos e depois em CelClick

            // 1 - Pegar os dados da linha selecionada, para aparecer nos campos de cadastro, pegando da coluna/indice 0
            tbCodigo.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            maskedTbRG.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            maskedTBCpf.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[4].Value.ToString();

            tbSenha.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cboBoxCargo.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cboBoxTipoAcesso.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[7].Value.ToString();

            maskedTBTel.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            maskedTBCel.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            maskedTBCep.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            tbEndereco.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            tbNumero.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            tbComplemento.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            tbBairro.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            tbCidade.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            comboBoxUf.Text = dataGridView_TabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            //Ação para quando clicar/selecionar 2x, um cliente listado, mudar para a tela de Cadastro de Clientes
            tabFuncionario.SelectedTab = tabPageCadFuncionario;
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            FuncionariioDao FomularioDao = new FuncionariioDao();
            //Sempre que executar o projeto, os dados que estão no banco de dados vão ser listados.
            dataGridView_TabelaFuncionario.DataSource = FomularioDao.ListarFuncionarios();
        }
    }
}
