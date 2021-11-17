using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Projeto_Loteria
{
    class Cartela
    {
        public List<Label> Numeros {get; set;} 

        public Cartela(int quantidade, Color color)
        {
            Numeros = new List<Label>(quantidade);
            for (int i = 0; i < quantidade; i++)
            {
                Numeros.Add(new Label());
                Numeros[i].ForeColor = Color.Black;
                Numeros[i].BackColor = color;
                Numeros[i].AutoSize = false;
                Numeros[i].TextAlign = ContentAlignment.MiddleCenter;
                Numeros[i].BorderStyle = BorderStyle.Fixed3D;

                string numero = (i + 1).ToString().PadLeft(2, '0');
                if(numero == "100")
                    numero = "00";
                Numeros[i].Text = numero;
                
            }
        }

        public void imprimir(Panel p, int lin, int col) 
        {
            int comprimento = p.Width / col;
            int altura = p.Height / lin;

            int pv = 0, ph = 0;
            p.Controls.Clear();
            for (int i = 0; i < Numeros.Count; i++)
            {
                Numeros[i].Width = comprimento;
                Numeros[i].Height = altura;
                if (i % col == 0 && i != 0)
                {
                    pv += altura;
                    ph = 0;
                }
                Numeros[i].Left = ph;
                Numeros[i].Top = pv;
                ph += comprimento;
                p.Controls.Add(Numeros[i]);
                Numeros[i].Show();
            }
        }

        public void sortear(int faixa, int qtd)
        {
            Random sorteio = new Random();
            List<int> lista = new List<int>();

            for (int i = 0; i < qtd; i++)
            {
                int num = sorteio.Next(0, faixa);

                if(lista.Contains(num)) {
                    i--;
                    continue;
                }

                lista.Add(num);
            }
            string caminho = Environment.CurrentDirectory;
            foreach (var item in lista)
            {
                Numeros[item].BackColor = Color.White;
                Numeros[item].Image = Image.FromFile(caminho + "\\Star_Gold_Dark.png");
            }
        }
    }
}
