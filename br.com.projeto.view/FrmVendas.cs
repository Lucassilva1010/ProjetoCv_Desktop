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

                tbNomeClienteVendas.Text = objCliente.Nome;//Isso ira mostrar o nome do cliente na tela 
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

                tbDescricaoProduto_Vendas.Text = objProduto.Descricao;//Isso ira mostrar o nome do cliente na tela 
                tbPrecoProduto_vendas.Text = objProduto.Preco.ToString();//Isso ira mostrar o nome do cliente na tela 
            }
        }

        private void btnAdicionarItem_Vendas_Click(object sender, EventArgs e)
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

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //Aqui será preparado os dados para ser apresentado no dataGriDView
            //POderia ser criado no construtor dessa classe, pois ele é responssavel por inicializar os dados dessa classe, "como foi feito"
        }
    }
}
