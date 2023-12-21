using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3
{
    public partial class Factoriel : Form
    {
        public Factoriel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 acc = new Form1();
            acc.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(TxtN.Text, out n) && n > 0)
            {
                long factorial = CalculateFactorial(n);
                LblRes.Text = factorial.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un entier valide supérieur à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;// i= i+1
            }
            return result;
        }

        private void TxtN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
