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

        Cliente objCliente = new Cliente();
        ClienteDao objClienteDao = new ClienteDao();

        Produto objProduto = new Produto();
        ProdutoDao objProDao = new ProdutoDao();

        public FrmVendas()
        {
            InitializeComponent();
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
                tbQtdEstoqueProduto_Vendas.Text = objProduto.QtdEstoque.ToString();//Isso ira mostrar o nome do cliente na tela 
            }
        }
    }
}
