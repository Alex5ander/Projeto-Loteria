using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loteria
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
  
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            if (rbMegaSena.Checked)
            {
               Cartela mega = new Cartela(60, rbMegaSena.BackColor);
               mega.imprimir(pnCartela, 10, 6);
               mega.sortear(60, 6);
            }

           if (rbLotomania.Checked)
           {
               Cartela lotomania = new Cartela(100, rbLotomania.BackColor);
               lotomania.imprimir(pnCartela, 10, 10);
               lotomania.sortear(100, 50);
           }

           if (rbLotofacil.Checked)
           {
               Cartela lotofacil = new Cartela(25, rbLotofacil.BackColor);
               lotofacil.imprimir(pnCartela, 5, 5);
               lotofacil.sortear(25, 15);
           }

           if (rbQuina.Checked)
           {
               Cartela quina = new Cartela(80, rbQuina.BackColor);
               quina.imprimir(pnCartela, 10, 8);
               quina.sortear(80, 5);
           }
        }

    }
}
