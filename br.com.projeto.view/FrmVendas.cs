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
    public partial class FrmVendas : Form
    {
        //Foi necessario a criação de 2 Objetos aqui, para que haja interações com as propriedades
        // Objeto Cliente
        Cliente objCliente = new Cliente();
        ClienteDao objClienteDao = new ClienteDao();
        // Objeto Produto
        Produto objProduto = new Produto();
        ProdutoDao objProDao = new ProdutoDao();

        //Variaveis
        int qtd;
        decimal preco;
        decimal subTotal, total;

        //Carrinho
        //Aqui será o objeto que vai preencher todos os campos no dataGrid
        DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            //Montando a saida das informações na tela do DataGridView
            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("QTD", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            //Passando as informações para tela
            dataGridViewTabelaProdutos_vendas.DataSource = carrinho;
        }

        private void maskedTBCpfClienteVendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento criado pela propriedade na aba de eventos - KeyPress.
            //Esse evento acontece quando o usuario pressiona alguma tecla, como normalmente o Enter que é reprensentada por a tecla 13.


            //Verificação para saber se o foi pressionado a telca ENTER
            if (e.KeyChar == 13)
            {
                objCliente = objClienteDao.RetornaClientePorCPF(maskTBCpfClienteVendas.Text);//pega o cpf da tela e manda para o metodo
                if (objCliente != null)
                {
                    tbNomeClienteVendas.Text = objCliente.Nome;//Isso ira mostrar o nome do cliente na tela 

                }
                else
                {
                    maskTBCpfClienteVendas.Clear();
                    maskTBCpfClienteVendas.Focus();
                }

            }

        }


        private void tbCodigoProduto_vendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento criado pela propriedade na aba de eventos - KeyPress.
            //Esse evento acontece quando o usuario pressiona alguma tecla, como normalmente o Enter que é reprensentada por a tecla 13.

            //Verificação para saber se o foi pressionado a telca ENTER
            if (e.KeyChar == 13)
            {
                objProduto = objProDao.RetornaProdutosPorCodigo(int.Parse(tbCodigoProduto_vendas.Text));//pega o cpf da tela e manda para o metodo

                if (objProduto != null)
                {

                    tbDescricaoProduto_Vendas.Text = objProduto.Descricao;//Isso ira mostrar o nome do cliente na tela 
                    tbPrecoProduto_vendas.Text = objProduto.Preco.ToString();//Isso ira mostrar o nome do cliente na tela 
                }
                else
                {
                    tbCodigoProduto_vendas.Clear();
                    tbCodigoProduto_vendas.Focus();

                }
            }
        }

        private void btnAdicionarItem_Vendas_Click(object sender, EventArgs e)
        {
            try
            {
                //Evento responssavel por fazer a contablidade do carrinho e mostrar no DataViewGrid com a relação dos Itens
                qtd = int.Parse(tbQtdProduto_Vendas.Text);
                preco = decimal.Parse(tbPrecoProduto_vendas.Text);

                subTotal = qtd * preco;
                total += subTotal;

                //Adicionando os itens ao carrinho(tabela) resultados na tabela
                carrinho.Rows.Add(int.Parse(tbCodigoProduto_vendas.Text), tbDescricaoProduto_Vendas.Text, qtd, preco, subTotal);
                textBoxValorTotal.Text = total.ToString();


                //Limpando os campos após adicionar os Itens
                tbCodigoProduto_vendas.Clear();
                tbDescricaoProduto_Vendas.Clear();
                tbQtdProduto_Vendas.Clear();
                tbPrecoProduto_vendas.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel adicionar o Item ao carrinho!" +
                    "Verifique se o codigo foi digitado!");
            }

        }

        private void btnRemoverItem_vendas_Click(object sender, EventArgs e)
        {
            //Ação para remover Itens do carrinho
            //1ª Pegar o valor do subtotal, que será decrementado pelo item que será deletado.
            //Essa ação pega o valor que está sendo digitado dentro da coluna 4 no DataGrid
            decimal subProduto = decimal.Parse(dataGridViewTabelaProdutos_vendas.CurrentRow.Cells[4].Value.ToString());

            //Aqui pega o numero do Indice do produto que será removido
            int indice = dataGridViewTabelaProdutos_vendas.CurrentRow.Index;

            //Aqui pega a Linha em que está o valor que queremos/selecionamos
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);//Remove a linha 
            carrinho.AcceptChanges();//Ação para que as alterações sejam realizadas, é uma especie de play

            total -= subProduto;//pega o valor da tabela de carrinhos e diminui 
            textBoxValorTotal.Text = total.ToString();//Isso vai atualizar o textBox que mostra o valor da compra

            MessageBox.Show("Item Removido do Carrinho com sucesso!");
        }

        private void buttonPagamento_vendas_Click(object sender, EventArgs e)
        {
            //Evendo do botão de pagamento na area de vendas
            //Criado uma instência da Tela de Pagamentos para manipular os dados da mesma
            DateTime dataAtual = DateTime.Parse(textBoxDataCompra.Text);
            FrmPagamentos frmPag = new FrmPagamentos(objCliente, carrinho, dataAtual);//Valores dos parametros instanciados no inicio da classe, vai ser enviado para o banco de dados

            //Passando os valores entre as telas 
            frmPag.tbPgamento_total.Text = textBoxValorTotal.Text;


            //isso cria uma chamada para  nova tela ao clicar no botão
            frmPag.ShowDialog();
        }

        private void groupBoxProduto_Enter(object sender, EventArgs e)
        {

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //Aqui será preparado os dados para ser apresentado no dataGriDView
            //POderia ser criado no construtor dessa classe, pois ele é responssavel por inicializar os dados dessa classe, "como foi feito"

            textBoxDataCompra.Text = DateTime.Now.ToShortDateString();
        }
    }
}
