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
    public partial class frmMidia : Form
    {
        public frmMidia()
        {
            InitializeComponent();
        }

        private void primeiroFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeste teste = new frmTeste();
            teste.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void saláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalario Salario = new frmSalario();
            Salario.Show();
        }

        private void nadadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNadadores Nadadores = new frmNadadores();
            Nadadores.Show();
        }

        private void primeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalario Salario = new frmSalario();
            Salario.Show();
        }

        private void nadadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmNadadores Nadadores = new frmNadadores();
            Nadadores.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void testePrimeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeste teste = new frmTeste();
            teste.Show();
        }

        private void funcionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmFuncionarios funcionarios = new frmFuncionarios();
            funcionarios.Show();
        }

        private void fatoraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFatoracao fatoracao = new frmFatoracao();
            fatoracao.Show();
        }
    }
}
