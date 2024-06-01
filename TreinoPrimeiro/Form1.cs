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
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            double r, num1, num2;

            num1 = Convert.ToDouble(txt1.Text);
            num2 = Convert.ToDouble(txt2.Text);

            r = (num1 + num2) / 2;

            txtResult.Text = r.ToString();
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();

            txtResult.Clear();
            txtResult.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMidia Midia = new frmMidia();   
            Midia.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
