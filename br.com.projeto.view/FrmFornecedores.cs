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
    }
}
