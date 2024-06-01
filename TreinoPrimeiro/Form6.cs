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
    public partial class frmFatoracao : Form
    {
        public frmFatoracao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num, r, i;
            num = Convert.ToDouble(txtDigitenum.Text);
            i = num - 1;
            while (i > 0)
            {
                r = num * i;
                txtResult.Text = string.Concat(txtResult.Text, "\r\n", num, "x", i, "=", r.ToString());
                i--;
                num = r;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDigitenum.Clear();
            txtResult.Clear();

            txtResult.Focus();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double num, r, i;
            num = Convert.ToDouble(txtDigitenum.Text);
            for(i = num -1; i > 0; i--)
            {
                r = num * i;
                txtResult.Text = string.Concat(txtResult.Text, "\r\n", num, "x", i, "=",r.ToString());
                num = r;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            double num, r, i;
            num = Convert.ToDouble(txtDigitenum.Text);
            i = num - 1;
            do{
                r = num * i; 
                txtResult.Text = string.Concat(txtResult.Text, "\r\n", num, "x", i, "=",r.ToString());
                i--;
                num = r;
                
            } while (i > 0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMidia midia = new frmMidia();
            midia.Show();
        }
    }
}
