using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Configuration;



namespace ProjetoCv.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        //Metodo para conectar ao banco de dados
        public MySqlConnection GetConnection()
        {
            //Criando uma variavel do tipo configuration, para que ela possa acessar o arquivo APP
            //Aqui acesso o nome da conexão configurada na classe APP.Config
            string conexao = ConfigurationManager.ConnectionStrings["dbvendas"].ConnectionString;
            
            //Retorna uma nova Conexão para minha string de conexão
            return  new MySqlConnection(conexao);
        }
    }
}

