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
    public partial class Form2: Form
    {
        int i, soma = 0, x, contador = 30;
        int[] vetorNotas = new int[30];
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnprocessar_Click(object sender, EventArgs e)
        {
          
         }
       
        private void btn1_Click(object sender, EventArgs e)
        {
            txtmedia.Text = (soma / 30).ToString();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            if (contador != 0)
            {
                contador = contador - 1;
                for (i = 0; i < 30; i++)
                {
                    x = Convert.ToInt32(txtnota.Text);
                    vetorNotas[i] = x;
                    soma = soma + vetorNotas[i];
                    txtnota.Clear();
                    txtnota.Focus();
                    break;
                }           
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtmedia.Clear();
            txtnota.Clear();
            soma = 0;
            txtnota.Focus();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 gerador = new Form3();
            this.Hide();
            gerador.Show();
        }
    }
}
