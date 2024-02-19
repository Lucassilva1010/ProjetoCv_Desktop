using MySql.Data.MySqlClient;
using ProjetoCv.br.com.projeto.conexao;
using ProjetoCv.br.com.projeto.model;
using System;
using System.Data;
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

        #region Metodo de listar itens por venda

        public DataTable ListaItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();//Aqui cria a tabela para amostragem dos dados 
                //comando para selecionar os campos ou todos os elementos da tabela vendas
                string sql = @"select i.id as 'Código', 
                            p.descricao as 'Descrição', 
                            i.qtd as 'Quantidade', 
                            p.preco as 'Preço', 
                            i.subtotal as 'SubTotal'
                            from tb_itensvendas as i join
                            tb_produtos as p on (i.produto_id = p.id) where venda_id = @venda_id;";


                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Configurar os atributos para receber o que vem da classe(Objeto) Produtos
                executaComando.Parameters.AddWithValue("@venda_id", venda_id);
               
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();

                //3 Criar o MysQlAdapter para preencher os dados no DataTable
                MySqlDataAdapter dados = new MySqlDataAdapter(executaComando);

                dados.Fill(tabelaItens);//Preenchendo os dados na nossa tabela no formulario

                return tabelaItens;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Executar o comando SQL: " + erro);
                return null;
            }
        }
        #endregion
    }
}
