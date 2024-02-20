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
    class FuncionariioDao
    {
        //Atributo com o poder de Conxaão e uso do MySql
        private MySqlConnection conexao;

        //Passando por construtor a classe que possui as configurações de conexão para o atirbuto criado.
        public FuncionariioDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }



        #region Cadastrar Funcionario
        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Insert Into tb_funcionarios(nome,rg,cpf,email,senha, cargo, nivel_acesso,telefone,celular,cep,endereco,numero,complemento,
                                 bairro,cidade,estado)
                                    values( @nome, @rg, @cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular, @cep, @endereco,@numero, @complemento,
                                 @bairro, @cidade, @estado)";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente

                executaComando.Parameters.AddWithValue("@nome", obj.Nome);
                executaComando.Parameters.AddWithValue("@rg", obj.Rg);
                executaComando.Parameters.AddWithValue("@cpf", obj.Cpf);
                executaComando.Parameters.AddWithValue("@email", obj.Email);
                executaComando.Parameters.AddWithValue("@senha", obj.Senha);
                executaComando.Parameters.AddWithValue("@cargo", obj.Cargo);
                executaComando.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);
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

                MessageBox.Show("Funcionario cadastrado com Sucesso!");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastrar o Funcionario. Erro: " + erro);

            }

        }
        #endregion

        #region Listar Funcionarios

        public DataTable ListarFuncionarios()
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_funcionarios;";

                //2 Organizando e executando o sql, e brir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaFuncionario);//Aqui preenche a tabela com as informações/dados
                conexao.Close();


                return tabelaFuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Funcionarios. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Buscar Funcionarios
        public DataTable BuscarFuncionariosPorNome(string nome)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_funcionarios Where nome=@nome";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@nome", nome);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaFuncionario);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaFuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar Funcionario. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Listar Funcionarios por letras e nome
        public DataTable ListarFuncionarioPorNomeEletras(string nome)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaCliente = new DataTable();
                //Na pesquisa agora use-0se o Like para que ele começe a fazer uma pesquisa simultanea, enquanto digita, ele já vá aparecendo.
                string sql = "SELECT * FROM bdvendas.tb_funcionarios Where nome like @nome";

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

        #region Alterar Funcionario
        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha, cargo=@cargo,nivel_acesso=@nivel_acesso,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,
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
                executaComando.Parameters.AddWithValue("@senha", obj.Senha);
                executaComando.Parameters.AddWithValue("@cargo", obj.Cargo);
                executaComando.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);
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

                MessageBox.Show("Funcionario Alterado com Sucesso!");
                conexao.Close();



            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Alterar o Funcionario. Erro: " + erro);

            }

        }
        #endregion

        #region Excluir Funcionario 
        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Delete from tb_funcionarios Where id=@id";//Esse parametro é para deletar o Id Referenciado na tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Pegando o valor que vem da tela para ser excluido
                executaComando.Parameters.AddWithValue("@id", obj.ID);



                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Funcionario Excluido com Sucesso!");
                conexao.Close();//Encerra a conexão após a exclusão


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Excluir o Funcionario." +
                    " Erro: " + erro);

            }

        }
        #endregion

        //Buscar Cliente por ID ou qualquer outro modo que deseje

        #region Metodo do Login
        public bool Login(string email, string senha)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"SELECT * FROM bdvendas.tb_funcionarios
                            where email = @email and senha = @senha";

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente

                executaComando.Parameters.AddWithValue("@email",email);
                executaComando.Parameters.AddWithValue("@senha", senha);
                
                conexao.Open();

                //Gerando e registrando do dados em uma Biblioteca
                MySqlDataReader dados = executaComando.ExecuteReader();
                //Verificação para saber se os dados foram preenchidos
                if (dados.Read())
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Usúario ou senha Invalidos!");
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao logar: "+erro);
                return false;
            }
        }
        #endregion
    }
}
