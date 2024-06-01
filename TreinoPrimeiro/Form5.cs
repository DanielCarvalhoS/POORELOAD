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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Salario, Idade, SalarioLiq;
            string Sexo, Nome;

            Salario = Convert.ToDouble(txtSalario.Text);
            Idade = Convert.ToDouble(txtIdade.Text);
            Sexo = txtSexo.Text;
            Nome = txtNome.Text;

            txtNome2.Text = Nome.ToString();

            if (Sexo == "Masculino" && Idade >= 30)
            {
                SalarioLiq = Salario + 100;

                txtSalarioLiq.Text = SalarioLiq.ToString();
            }
            else if (Sexo == "Masculino" && Idade < 30)
            {
                SalarioLiq = Salario + 80;

                txtSalarioLiq.Text = SalarioLiq.ToString();
            }
            else if (Sexo == "Feminino" && Idade >= 30)
            {
                SalarioLiq = Salario + 200;

                txtSalarioLiq.Text = SalarioLiq.ToString();
            }
            else if (Sexo == "Feminino" && Idade < 30)
            {
                SalarioLiq = Salario + 50;

                txtSalarioLiq.Text = SalarioLiq.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtNome.Clear();
            txtSalario.Clear();
            txtSalarioLiq.Clear();
            txtNome2.Clear();
            txtSexo.Clear();

            txtSalarioLiq.Focus();
            txtNome2.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMidia midia = new frmMidia();
            midia.Show();
        }
    }
}
