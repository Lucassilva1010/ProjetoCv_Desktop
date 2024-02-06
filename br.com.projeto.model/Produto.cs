using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCv.br.com.projeto.model
{
   public class Produto
    {
        public int ID { get; set; }
        public string  Descricao { get; set; }
        public decimal  Preco { get; set; }
        public int QtdEstoque { get; set; }
        public int For_Id { get; set; }
    }
}
