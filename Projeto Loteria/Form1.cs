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

           if (rbLotofacil.Checked)
           {
               Cartela mega = new Cartela(25, rbMegaSena.BackColor);
               mega.imprimir(pnCartela, 5, 5);
               //mega.sortear(60, 6);
           }
        }

    }
}
