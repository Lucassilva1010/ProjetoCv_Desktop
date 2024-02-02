using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCv.br.com.projeto.model
{
    public class Helpers
    {
        public void LimpaTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2t in ctr1.Controls)
                        {

                            //Aqui analsia cada caixa de texto e seus tipos para limpar
                            if (ctr2t is TextBox)
                            {
                                (ctr2t as TextBox).Text = string.Empty;

                            }

                            if (ctr2t is MaskedTextBox)
                            {

                                (ctr2t as MaskedTextBox).Text = string.Empty;
                            }


                            if (ctr2t is ComboBox)
                            {
                                (ctr2t as ComboBox).Text = string.Empty;

                            }
                        }
                    }
                }
            }
        }
    }
}

