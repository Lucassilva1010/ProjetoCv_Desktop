using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCv.br.com.projeto.model
{
   public class Venda
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal TotalVenda { get; set; }
        public string Observacao { get; set; }
    }
}
