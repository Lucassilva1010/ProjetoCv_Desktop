using MySql.Data.MySqlClient;
using ProjetoCv.br.com.projeto.conexao;
using ProjetoCv.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCv.br.com.projeto.dao
{
    public class VendaDao
    {

        //Atributo com o poder de Conxaão e uso do MySql
        private MySqlConnection conexao;
        public VendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar venda

        public void CadastrarVenda(Venda obj)
        {
            try
            {

                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Insert Into tb_vendas(cliente_id,data_venda,total_venda,observacoes)
                                    values(@cliente_id,@data_venda,@total_venda,@observacoes)";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Configurar os atributos para receber o que vem da classe(Objeto) Produtos
                executaComando.Parameters.AddWithValue("@cliente_id", obj.ClienteID);
                executaComando.Parameters.AddWithValue("@data_venda", obj.DataVenda);
                executaComando.Parameters.AddWithValue("@total_venda", obj.TotalVenda);
                executaComando.Parameters.AddWithValue("@observacoes", obj.Observacao);

                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro realizar venda! Erro: " + erro);
            }
        }
        #endregion

        #region Retorna a ultima venda por ID
        public int RetornaUltimaVendaPorID()
        {
            try
            {
                int idVendas = 0;

                //1  Criando conexão para Sql
                //Busca o ultimo id que possui vendas registradas ao mesmo
                string sql = "SELECT MAX(id) id from bdvendas.tb_vendas";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                conexao.Open();//Abre a conexão

                //é usado nesse metodo uma nova forma de ler os dados, pois aqui precisamos dos ados de apenas 1 Cliente,
                // e que seja retornado todos os seus campos, ou campos selecionados
                MySqlDataReader dados = executaComando.ExecuteReader();

                if (dados.Read())
                {
                    //aqui montei o retorno dos dados que desejo que seja mostrado na tela
                    idVendas = dados.GetInt32("id");
                }
                    conexao.Close();

                return idVendas;//Aqui vai todo o objeto montado com os dados que selecionei
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu uo erro:" +
                    $"Erro: {erro}");
                conexao.Close();
                return 0;
            }
        }
        #endregion
    }

}

