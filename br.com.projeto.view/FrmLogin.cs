using ProjetoCv.br.com.projeto.dao;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Botão Login

            string email = tbLoginEmail.Text;
            string senha = tbSenha.Text;

            FuncionariioDao funcDao = new FuncionariioDao();

            if (funcDao.Login(email, senha))
            {
                FrmMenu telaMenu = new FrmMenu();
                telaMenu.Show();//abre a nova tela de menu
                this.Hide();//Isso faz com que o formulario de login seja ocultado aopós ser relaizado o mesmo
            } 
        }
    }
}
