﻿using ProjetoCv.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCv
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //Application.Run(new FrmClientes());
            //Application.Run(new FrmFuncionario());
            //Application.Run(new FrmFornecedores());
            //Application.Run(new FrmVendas());
            //Application.Run(new FrmHistoricoVendas());
            //Application.Run(new FrmDetalhes());
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmMenu());
            Application.Run(new FrmLogin());
        }
    }
}
