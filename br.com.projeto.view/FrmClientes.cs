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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void labCodigo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 - Passo: receber os dados de dentro do Objeto cliente. 

            Cliente objC = new Cliente();

            objC.Nome = tbNome.Text;
            objC.Rg = maskedTbRG.Text;
            objC.Cpf = maskedTBCpf.Text;
            objC.Email = tbEmail.Text;
            objC.Telefone = maskedTBTel.Text;
            objC.Celular = maskedTBCel.Text;
            objC.Cep = maskedTBCep.Text;
            objC.Endereco = tbEndereco.Text;
            objC.Numero = int.Parse(tbNumero.Text);
            objC.Complemento = tbComplemento.Text;
            objC.Bairro = tbBairro.Text;
            objC.Cidade = tbCidade.Text;
            objC.Estado = comboBoxUf.Text;

            //2 - Passo: Criar um Objeto da classe Cliente DAO, e passar os dados para o metodo cadastrar.
            ClienteDao cDao = new ClienteDao();
            cDao.CadastrarCliente(objC);//Aqui se passa todos os dados recebidos da tela para o banco de dados
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            //Sempre que executar o projeto, os dados que estão no banco de dados vão ser listados.
            dataGridView_ConsultaCliente.DataSource = clienteDao.ListarClientes();
        }

        private void dataGridView_ConsultaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esse evendo foi criado a partir do campo de propriedades, clicando em eventos e depois em CelClick

            // 1 - Pegar os dados da linha selecionada, para aparecer nos campos de cadastro, pegando da coluna/indice 0
            tbCodigo.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[1].Value.ToString();
            maskedTbRG.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[2].Value.ToString();
            maskedTBCpf.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[4].Value.ToString();
            maskedTBTel.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[5].Value.ToString();
            maskedTBCel.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[6].Value.ToString();
            maskedTBCep.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[7].Value.ToString();
            tbEndereco.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[8].Value.ToString();
            tbNumero.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[9].Value.ToString();
           tbComplemento.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[10].Value.ToString();
           tbBairro.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[11].Value.ToString();
           tbCidade.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[12].Value.ToString();
            comboBoxUf.Text = dataGridView_ConsultaCliente.CurrentRow.Cells[13].Value.ToString();

        }
    }
}
