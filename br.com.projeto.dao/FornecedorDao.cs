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
    public class FornecedorDao
    {
        //Criando a conexão com o Banco de dados

        //Atributo com o poder de Conxaão e uso do MySql
        private MySqlConnection conexao;

        //Passando por construtor a classe que possui as configurações de conexão para o atirbuto criado.
        public FornecedorDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Fornecedor
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Insert Into tb_fornecedores(nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,
                                 bairro,cidade,estado)
                                    values( @nome, @cnpj,@email,@telefone,@celular, @cep, @endereco,@numero, @complemento,
                                 @bairro, @cidade, @estado)";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente

                executaComando.Parameters.AddWithValue("@nome", obj.Nome);
                executaComando.Parameters.AddWithValue("@cnpj", obj.Cnpj);
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

                MessageBox.Show("Fornecedor cadastrado com Sucesso!");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastrar o Fornecedor. Erro: " + erro);

            }

        }
        #endregion

        #region Listar Fornecedores
        public DataTable ListarFornecedores()
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaFornecedor = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_fornecedores;";

                //2 Organizando e executando o sql, e brir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaFornecedor);//Aqui preenche a tabela com as informações/dados
                conexao.Close();


                return tabelaFornecedor;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Fornecedores. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Buscar Fornecedores
        public DataTable BuscarFornecedoresPorNome(string nome)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaFornecedores = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_fornecedores Where nome=@nome";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@nome", nome);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaFornecedores);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaFornecedores;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Fornecedores. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Listar Fornecedores por letras e nome
        public DataTable ListarFornecedoresPorNomeEletras(string nome)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaFornecedores = new DataTable();
                //Na pesquisa agora use-0se o Like para que ele começe a fazer uma pesquisa simultanea, enquanto digita, ele já vá aparecendo.
                string sql = "SELECT * FROM bdvendas.tb_fornecedores Where nome like @nome";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@nome", nome);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaFornecedores);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaFornecedores;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Fornecedores. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Alterar Fornecedor
        public void AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Update tb_fornecedores set nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,
                                complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                                    Where id=@id";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente
                executaComando.Parameters.AddWithValue("@id", obj.ID);
                executaComando.Parameters.AddWithValue("@nome", obj.Nome);
                executaComando.Parameters.AddWithValue("@cnpj", obj.Cnpj);
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

                MessageBox.Show("Fornecedor Alterado com Sucesso!");
                conexao.Close();



            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Alterar o Fornecedor. Erro: " + erro);

            }

        }
        #endregion

        #region Excluir Fornecedor 
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Delete from tb_fornecedores Where id=@id";//Esse parametro é para deletar o Id Referenciado na tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Pegando o valor que vem da tela para ser excluido
                executaComando.Parameters.AddWithValue("@id", obj.ID);

                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Fornecedor Excluido com Sucesso!");
                conexao.Close();//Encerra a conexão após a exclusão

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Excluir o Fornecedor." +
                    " Erro: " + erro);

            }

        }
        #endregion


    }
}
