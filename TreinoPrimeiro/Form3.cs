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
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double SalarioFixo, ValorVendas, QuantidadeCarro, Comissao, Porc, SalarioTotal;


            SalarioFixo = Convert.ToDouble(textBox1.Text);
            ValorVendas = Convert.ToDouble(textBox2.Text);
            QuantidadeCarro = Convert.ToDouble(textBox3.Text);
            Comissao = Convert.ToDouble(textBox4.Text);

            Porc = (ValorVendas * 5) / 100;

            SalarioTotal = Porc + Comissao + SalarioFixo;

            textBox5.Text = Porc.ToString();
            textBox6.Text = SalarioTotal.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            textBox5.Clear();
            textBox6.Clear();

            textBox5.Focus();
            textBox6.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMidia midia = new frmMidia();
            midia.Show();
        }
    }
}
