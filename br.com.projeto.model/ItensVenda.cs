using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCv.br.com.projeto.model
{
   public class ItensVenda
    {
        public int ID { get; set; }
        public int Venda_Id { get; set; }
        public int Produto_Id { get; set; }
        public int Quantidade { get; set; }
        public decimal SubTotal { get; set; }

    }
}
