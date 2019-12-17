using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalcul.AppendText(btn9 .Text);
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (txtCalcul.Text[txtCalcul.TextLength - 1] == '=' || txtCalcul.Text[txtCalcul.TextLength - 1] == '+' || txtCalcul.Text[txtCalcul.TextLength - 1] == '-' || txtCalcul.Text[txtCalcul.TextLength - 1] == '*' || txtCalcul.Text[txtCalcul.TextLength - 1] == '/')
            {
                txtCalcul.Text = txtCalcul.Text.Substring(0, txtCalcul.TextLength - 1);
            }
            txtCalcul.AppendText(btnAddition.Text);
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (txtCalcul.Text[txtCalcul.TextLength - 1] == '=' || txtCalcul.Text[txtCalcul.TextLength - 1] == '+' || txtCalcul.Text[txtCalcul.TextLength - 1] == '-' || txtCalcul.Text[txtCalcul.TextLength - 1] == '*' || txtCalcul.Text[txtCalcul.TextLength - 1] == '/')
            {
                txtCalcul.Text = txtCalcul.Text.Substring(0, txtCalcul.TextLength - 1);
            }
            txtCalcul.AppendText(btnSubstract.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtCalcul.Text[txtCalcul.TextLength - 1] == '=' || txtCalcul.Text[txtCalcul.TextLength - 1] == '+' || txtCalcul.Text[txtCalcul.TextLength - 1] == '-' || txtCalcul.Text[txtCalcul.TextLength - 1] == '*' || txtCalcul.Text[txtCalcul.TextLength - 1] == '/')
            {
                txtCalcul.Text = txtCalcul.Text.Substring(0, txtCalcul.TextLength - 1);
            }
            txtCalcul.AppendText(btnMultiply.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtCalcul.Text[txtCalcul.TextLength - 1] == '=' || txtCalcul.Text[txtCalcul.TextLength - 1] == '+' || txtCalcul.Text[txtCalcul.TextLength - 1] == '-' || txtCalcul.Text[txtCalcul.TextLength - 1] == '*' || txtCalcul.Text[txtCalcul.TextLength - 1] == '/')
            {
                txtCalcul.Text = txtCalcul.Text.Substring(0, txtCalcul.TextLength - 1);
            }
            txtCalcul.AppendText(btnDivide.Text);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (txtCalcul.Text[txtCalcul.TextLength - 1] == '=' || txtCalcul.Text[txtCalcul.TextLength - 1] == '+' || txtCalcul.Text[txtCalcul.TextLength - 1] == '-' || txtCalcul.Text[txtCalcul.TextLength - 1] == '*' || txtCalcul.Text[txtCalcul.TextLength - 1] == '/')
            {
                txtCalcul.Text = txtCalcul.Text.Substring(0, txtCalcul.TextLength - 1);
            }

            DataTable dataTable = new DataTable();
            if (txtCalcul.Text.Contains("/0"))
            {
                throw new DivideByZeroException("Erreur 0002 : Division par zéro impossible");
            }
            txtResult.Text = dataTable.Compute(txtCalcul.Text, null).ToString();
            txtCalcul.AppendText(btnEquals.Text);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtCalcul.TextLength != 0)
            {
                txtCalcul.Text = txtCalcul.Text.Substring(0, txtCalcul.TextLength - 1);
            }
            else
            {
                MessageBox.Show("Erreur 0001 : Champs de saisie déjà vide !!");
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCalcul.Text = "";
            txtResult.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

    }
}
