using MySql.Data.MySqlClient;
using ProjetoCv.br.com.projeto.conexao;
using ProjetoCv.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
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

        #region Historio de Vendas
        public DataTable ListaVendasPorPeriodo( DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();//Aqui cria a tabela para amostragem dos dados 
                //comando para selecionar os campos ou todos os elementos da tabela vendas
                string sql = @"SELECT v.id as 'Codígo', 
                                      v.data_venda as 'Data da Venda',
                                      c.nome as 'Cliente ', 
                                      v.total_venda as 'Total', 
                                      v.observacoes 'OBS' 
                                FROM bdvendas.tb_vendas as v join bdvendas.tb_clientes as c on (v.cliente_id = c.id) 
                                  where v.data_venda between @dataInicio and @dataFinal";


                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Configurar os atributos para receber o que vem da classe(Objeto) Produtos
                executaComando.Parameters.AddWithValue("@dataInicio", dataInicial);
                executaComando.Parameters.AddWithValue("@dataFinal", dataFinal);

                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();

                //3 Criar o MysQlAdapter para preencher os dados no DataTable
                MySqlDataAdapter dados = new MySqlDataAdapter(executaComando);

                dados.Fill(tabelaHistorico);//Preenchendo os dados na nossa tabela no formulario

                return tabelaHistorico;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Executar o comando SQL: "+ erro);
                return null;
            }
        }
        #endregion

        #region Lista todas as vendas

        public DataTable ListarVendas()
        {
            try
            {

                DataTable tabelaHistorico = new DataTable();//Aqui cria a tabela para amostragem dos dados 
                //comando para selecionar os campos ou todos os elementos da tabela vendas
                string sql = @"SELECT v.id as 'Codígo', 
                                      v.data_venda as 'Data da Venda',
                                      c.nome as 'Cliente ', 
                                      v.total_venda as 'Total', 
                                      v.observacoes 'OBS' 
                                FROM bdvendas.tb_vendas as v join bdvendas.tb_clientes as c on (v.cliente_id = c.id)";


                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();

                //3 Criar o MysQlAdapter para preencher os dados no DataTable
                MySqlDataAdapter dados = new MySqlDataAdapter(executaComando);

                dados.Fill(tabelaHistorico);//Preenchendo os dados na nossa tabela no formulario

                conexao.Close();
                return tabelaHistorico;

            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion
    }

}

