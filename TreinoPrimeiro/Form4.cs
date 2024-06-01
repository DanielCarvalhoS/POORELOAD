using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinoPrimeiro
{
    public partial class frmNadadores : Form
    {
        public frmNadadores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ganho, distancia;

            distancia = Convert.ToDouble(txtDistancia.Text);

            if (distancia < 800)
            {
                ganho = 5000.00;
            }

            else if (distancia >= 800 && distancia <= 1500)
            {
                ganho = 10000.00;
            }

            else
            {
                ganho = 15000.00;
            }

            txtGanho.Text = ganho.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDistancia.Clear();
            txtGanho.Clear();

            txtGanho.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMidia midia = new frmMidia();
            midia.Show();
        }
    }
}
