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
                string sql = @"Insert Into tb_clientes( nome, rg, cpf,email,telefone,celular, cep, endereco,numero, complemento,
                                 bairro, cidade, estado)
                                    values( @nome, @rg, @cpf,@email,@telefone,@celular, @cep, @endereco,@numero, @complemento,
                                 @bairro, @cidade, @estado)";//Esse parametro é para receber os valores que vem da tela

                //Passo 2 - Organizar o SQL
                MySqlCommand executaComando = new MySqlCommand(sql,conexao);
                //Configurar os atributos para receber o quye vem da classe(Objeto) Cliente

                executaComando.Parameters.AddWithValue("@nome", obj.Nome);
                executaComando.Parameters.AddWithValue("@rg", obj.Rg);
                executaComando.Parameters.AddWithValue("@cpf", obj.Cpf);
                executaComando.Parameters.AddWithValue("@email", obj.Email) ;
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


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastrar o Cliente. Erro: " + erro);
                
            }

        }
        #endregion
        //Alterar Cliente 
        //Excluir Cliente 
        //Listar Cliente
        //Buscar Cliente por ID ou qualquer outro modo que deseje
    }
}
