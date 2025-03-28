using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[15];
            Random numero = new Random();
            for (int i = 0; i < 15; i++)
            {
                int numeroSorteado = numero.Next(0, 100);
                vetor[i] = numeroSorteado;
            }
            for (int i = 0; i < 15; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    txtresult.Text += vetor[i] + " ";


                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 gerador = new Form3();
            this.Hide();
            gerador.Show();
        }
    }
}
