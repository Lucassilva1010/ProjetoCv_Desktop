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
    //Aqui é onde terá todos os metodos para ser manipulado no banco de dados.
    //Separado por Regiões 
    public class ClienteDao
    {
        //Atributo com o poder de Conxaão e uso do MySql
        private MySqlConnection conexao;

        //Passando por construtor a classe que possui as configurações de conexão para o atirbuto criado.
        public ClienteDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }



        #region Cadastrar cliente
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Insert Into tb_clientes(nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,
                                 bairro,cidade,estado)
                                    values( @nome, @rg, @cpf,@email,@telefone,@celular, @cep, @endereco,@numero, @complemento,
                                 @bairro, @cidade, @estado)";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente

                executaComando.Parameters.AddWithValue("@nome", obj.Nome);
                executaComando.Parameters.AddWithValue("@rg", obj.Rg);
                executaComando.Parameters.AddWithValue("@cpf", obj.Cpf);
                executaComando.Parameters.AddWithValue("@email", obj.Email);
                executaComando.Parameters.AddWithValue("@telefone", obj.Telefone);
                executaComando.Parameters.AddWithValue("@celular", obj.Celular);
                executaComando.Parameters.AddWithValue("@cep", obj.Cep);
                executaComando.Parameters.AddWithValue("@endereco", obj.Endereco);
                executaComando.Parameters.AddWithValue("@numero", obj.Numero);
                executaComando.Parameters.AddWithValue("@complemento", obj.Complemento);
                executaComando.Parameters.AddWithValue("@bairro", obj.Bairro);
                executaComando.Parameters.AddWithValue("@cidade", obj.Cidade);
                executaComando.Parameters.AddWithValue("@estado", obj.Estado);

                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Cliente cadastrado com Sucesso!");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastrar o Cliente. Erro: " + erro);

            }

        }
        #endregion
        #region Listar Cliente

        public DataTable ListarClientes()
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes;";

                //2 Organizando e executando o sql, e brir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaCliente);//Aqui preenche a tabela com as informações/dados
                conexao.Close();


                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Cliente. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion
        #region Buscar Cliente
        public DataTable BuscarClientesPorNome(string nome)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes Where nome=@nome";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@nome", nome);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaCliente);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Cliente. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion
        #region Listar Cliente por letras e nome
        public DataTable ListarClientesPorNomeEletras(string nome)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaCliente = new DataTable();
                //Na pesquisa agora use-0se o Like para que ele começe a fazer uma pesquisa simultanea, enquanto digita, ele já vá aparecendo.
                string sql = "SELECT * FROM bdvendas.tb_clientes Where nome like @nome";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@nome", nome);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaCliente);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Cliente. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion
        #region Alterar Cliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,
                                complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                                    Where id=@id";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente

                executaComando.Parameters.AddWithValue("@id", obj.ID);
                executaComando.Parameters.AddWithValue("@nome", obj.Nome);
                executaComando.Parameters.AddWithValue("@rg", obj.Rg);
                executaComando.Parameters.AddWithValue("@cpf", obj.Cpf);
                executaComando.Parameters.AddWithValue("@email", obj.Email);
                executaComando.Parameters.AddWithValue("@telefone", obj.Telefone);
                executaComando.Parameters.AddWithValue("@celular", obj.Celular);
                executaComando.Parameters.AddWithValue("@cep", obj.Cep);
                executaComando.Parameters.AddWithValue("@endereco", obj.Endereco);
                executaComando.Parameters.AddWithValue("@numero", obj.Numero);
                executaComando.Parameters.AddWithValue("@complemento", obj.Complemento);
                executaComando.Parameters.AddWithValue("@bairro", obj.Bairro);
                executaComando.Parameters.AddWithValue("@cidade", obj.Cidade);
                executaComando.Parameters.AddWithValue("@estado", obj.Estado);

                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Cliente Alterado com Sucesso!");
                conexao.Close();



            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Alterar o Cliente. Erro: " + erro);

            }

        }
        #endregion
        #region Excluir Cliente 
        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Delete from tb_clientes Where id=@id";//Esse parametro é para deletar o Id Referenciado na tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Pegando o valor que vem da tela para ser excluido
                executaComando.Parameters.AddWithValue("@id", obj.ID);



                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Cliente Excluido com Sucesso!");
                conexao.Close();//Encerra a conexão após a exclusão


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Excluir o Cliente." +
                    " Erro: " + erro);

            }

        }
        #endregion

        #region    Retorna Cliente por CPF 
        public Cliente RetornaClientePorCPF(string cpf)//O retorno aqui será um objeto do tipo cliente
        {
            try
            {
                Cliente objCliente = new Cliente();

                //1  Criando o DataTable que é o comendo Sql
                DataTable tabelaCliente = new DataTable();

                string sql = "SELECT * FROM bdvendas.tb_clientes Where cpf=@cpf";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();//Abre a conexão

                //é usado nesse metodo uma nova forma de ler os dados, pois aqui precisamos dos ados de apenas 1 Cliente,
                // e que seja retornado todos os seus campos, ou campos selecionados
                MySqlDataReader dados = executaComando.ExecuteReader();

                //Verificação para analisar se tem dados buscados pelo do DataReader
                if (dados.Read())
                {
                    objCliente.ID = dados.GetInt32("id");
                    objCliente.Nome = dados.GetString("nome");
                    conexao.Close();
                    return objCliente;
                }
                else
                {
                    MessageBox.Show($"Clientenão encontrado! ");
                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao Mostrar o Cliente. " +
                    $"Erro: {erro}");
                conexao.Close();
                return null;// Para retornar vazio
            }
        }
        #endregion
    }
}
