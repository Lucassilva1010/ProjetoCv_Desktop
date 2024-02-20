using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCv.br.com.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;

            //Formantando os Campos do Footer do painel

            toolStripData.Text = data.ToString("dd/MM/yy");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            toolStripSHora.Text = hora.ToString("HH:mm:ss");
        }

        private void toolStripData_Click(object sender, EventArgs e)
        {
          

        }

    }
}
