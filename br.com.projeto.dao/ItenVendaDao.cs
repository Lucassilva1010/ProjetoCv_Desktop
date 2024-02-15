using MySql.Data.MySqlClient;
using ProjetoCv.br.com.projeto.conexao;
using ProjetoCv.br.com.projeto.model;
using System;

using System.Windows.Forms;

namespace ProjetoCv.br.com.projeto.dao
{
    public class ItenVendaDao
    {

        //Atributo com o poder de Conxaão e uso do MySql
        private MySqlConnection conexao;
        public ItenVendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar um Item de venda
        public void CadastrarItenvenda(ItensVenda obj)
        {
            try
            {
               
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Insert Into tb_itensvendas(venda_id,produto_id,qtd,subtotal)
                                    values(@venda_id,@produto_id,@qtd,@subtotal)";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Configurar os atributos para receber o que vem da classe(Objeto) Produtos
                executaComando.Parameters.AddWithValue("@venda_id", obj.Venda_Id);
                executaComando.Parameters.AddWithValue("@produto_id", obj.Produto_Id);
                executaComando.Parameters.AddWithValue("@qtd", obj.Quantidade);
                executaComando.Parameters.AddWithValue("@subtotal", obj.SubTotal);

                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao cadastrar um novo Item!" +
                    $"Erro: {erro}");
                conexao.Close();
               
            }
        }
        #endregion
    }
}
