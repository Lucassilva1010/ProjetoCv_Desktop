using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCv.br.com.projeto.model
{
   public class Funcionario : Cliente//herdando as propriedades de cliente, pois eleas tem praticamente as mesmas propriedades
    {
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string NivelAcesso { get; set; }
    }
}
