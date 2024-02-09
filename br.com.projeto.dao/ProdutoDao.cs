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
    public class ProdutoDao
    {

        //Atributo com o poder de Conxaão e uso do MySql
        private MySqlConnection conexao;

        //Passando por construtor a classe que possui as configurações de conexão para o atirbuto criado.
        public ProdutoDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Produtos
        public void CadastrarProduto(Produto obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Insert Into tb_produtos(descricao,preco,qtd_estoque,for_id)
                                    values(@descricao,@preco,@qtd_estoque,@for_id)";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Configurar os atributos para receber o que vem da classe(Objeto) Produtos
                executaComando.Parameters.AddWithValue("@descricao", obj.Descricao);
                executaComando.Parameters.AddWithValue("@preco", obj.Preco);
                executaComando.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                executaComando.Parameters.AddWithValue("@for_id", obj.For_Id);

                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Produto cadastrado com Sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o Produto. Erro: " + erro);
            }

        }
        #endregion

        #region Listar Produtos

        public DataTable ListarProdutos()
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT 
                         tb_produtos.id as 'Código',
                         tb_produtos.descricao as 'Descrição',
                         tb_produtos.preco as 'Preço', 
                         tb_produtos.qtd_estoque as 'QTD Estoque', 
                         tb_fornecedores.nome as 'Fornecedor'
                         FROM bdvendas.tb_produtos
                        join bdvendas.tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id);";

                //2 Organizando e executando o sql, e brir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaProduto);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaProduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar os Produtos. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Buscar Produtos por Nome
        public DataTable BuscarProdutosPorNome(string descricao)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaProduto = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_produtos Where descricao=@descricao";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@descricao", descricao);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaProduto);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaProduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar os Produtos. " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Listar Produto por letras 
        public DataTable ListarProdutosPorLetras(string nome)
        {
            try
            {
                //1  Criando o DataTable e o comendo Sql
                DataTable tabelaProduto = new DataTable();

                //Na pesquisa agora foi usado o LIKE para que ele começe a fazer uma pesquisa simultanea, enquanto digita, ele já vá aparecendo.
                string sql = "SELECT * FROM bdvendas.tb_produtos Where descricao like @descricao";

                //2 Organizando e executando o sql, abrir e executar a Conexão com o banco de dados
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                executaComando.Parameters.AddWithValue("@descricao", nome);


                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                //Passo 3 - Criando o MySqlDataAdapter para preencher os dados da Datatable, e passado por parametro o Comando com so arquuivos do Banco
                MySqlDataAdapter da = new MySqlDataAdapter(executaComando);
                da.FillAsync(tabelaProduto);//Aqui preenche a tabela com as informações/dados

                conexao.Close();

                return tabelaProduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao listar o(s) Produto(s). " +
                    $"Erro: {erro}");
                return null;// Para retornar vazio
            }
        }
        #endregion

        #region Alterar Produto
        public void AlterarProduto(Produto obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Update bdvendas.tb_produtos
                                set descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque, for_id=@for_id
                                    Where id=@id";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente

                executaComando.Parameters.AddWithValue("@descricao", obj.Descricao);
                executaComando.Parameters.AddWithValue("@preco", obj.Preco);
                executaComando.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                executaComando.Parameters.AddWithValue("@for_id", obj.For_Id);

                executaComando.Parameters.AddWithValue("@id", obj.ID);

                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Produto Alterado com Sucesso!");
                conexao.Close();



            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Alterar o Produto. Erro: " + erro);

            }

        }
        #endregion

        #region Excluir Produto 
        public void ExcluirProduto(Produto obj)
        {
            try
            {
                //Passo 1 - Comando Sql para inserir os dados no Banco
                string sql = @"Delete from tb_produtos Where id=@id";//Esse parametro é para deletar o Id Referenciado na tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql, conexao);

                //Pegando o valor que vem da tela para ser excluido
                executaComando.Parameters.AddWithValue("@id", obj.ID);



                //Passo 3 - Abrir e executar a Conexão com o banco de dados
                conexao.Open();//Abre a conexão
                executaComando.ExecuteNonQuery();//Inicializa a conexão

                MessageBox.Show("Produto Excluido com Sucesso!");
                conexao.Close();//Encerra a conexão após a exclusão


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Excluir o Produto." +
                    " Erro: " + erro);

            }

        }
        #endregion
    }
}
