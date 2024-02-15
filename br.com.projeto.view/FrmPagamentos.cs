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
    public partial class FrmPagamentos : Form
    {

        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataAtual;
        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;
            InitializeComponent();
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            tbPagamento_pix.Text = "0,00";
            tbPrecoPagamento_dinheiro.Text = "0,00";
            tbPagamento_cartao.Text = "0,00";
            tbPagamento_troco.Text = "0,00";
        }

        private void btnCancelar_vendas_Click(object sender, EventArgs e)
        {
            //Botão de finalizar venda
            try
            {
                decimal v_dinheiro, v_cartao, v_pix, totalPago, total, troco;
                v_dinheiro = decimal.Parse(tbPrecoPagamento_dinheiro.Text);
                v_cartao = decimal.Parse(tbPagamento_cartao.Text);
                v_pix = decimal.Parse(tbPagamento_pix.Text);
                total = decimal.Parse(tbPgamento_total.Text);

                //Calcula o valor total pago
                totalPago = v_dinheiro + v_cartao + v_pix;
                if (totalPago < total)
                {
                    MessageBox.Show("O total pago é meno que o valor Total de Venda!");
                }
                else
                {
                    //Calcula o valor do troco
                    troco = totalPago - total;

                    //Cria os objeto de da tela de vendas
                    Venda vendas = new Venda();
                    vendas.ClienteID = cliente.ID;
                    vendas.DataVenda = dataAtual;
                    vendas.TotalVenda = total;
                    vendas.Observacao = textBoxObs.Text;

                    tbPagamento_troco.Text = troco.ToString();
                    //Chamada do metodo de cadastrar as vendas no banco de dados, com todos as suas informações
                    VendaDao vendaDao = new VendaDao();
                    vendaDao.CadastrarVenda(vendas);

                    //Cadastrando os Itens da venda

                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ItensVenda item = new ItensVenda();
                        item.Venda_Id = vendaDao.RetornaUltimaVendaPorID();//Já retorna a ultima venda
                        item.Produto_Id = int.Parse(linha["Código"].ToString());//Isso pega o valor que foi definido no formulario de vendas
                        item.Quantidade = int.Parse(linha["QTD"].ToString());//Isso pega o valor que foi definido no formulario de vendas
                        item.SubTotal = decimal.Parse(linha["Subtotal"].ToString());//Isso pega o valor que foi definido no formulario de vendas

                        //Envia para tabela de Itens 
                        ItenVendaDao itenVendaDao = new ItenVendaDao();
                        itenVendaDao.CadastrarItenvenda(item);
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");
                    
                    this.Dispose();//Isso faz fechar a tela em questão assim que os processos forem finalizados.
                    
                    //Verificar isso depois, pq isso abra mais de 1 tela
                    new FrmVendas().ShowDialog();//Com isso vai fazer com que a tela de vendas volte sem nenhuma informações preenchida após a finalizção da mesma

                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
