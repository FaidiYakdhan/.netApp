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
    public partial class Tableau : Form
    {
        public Tableau()
        {
            InitializeComponent();
        }
        const int n = 5;
        float[] T = new float[n];
        int i = 0;
        List<TextBox> LTxtC = new List<TextBox>();
        List<TextBox> LTxtP = new List<TextBox>();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnQ_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez-vous quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnEnreg_Click(object sender, EventArgs e)
        {
            float val;
            if (float.TryParse(TxtN.Text, out val) && val >= 0)
            {
                //LblRes.Text = "Entrez la note de l'élève N°: " + (i + 2).ToString();
                LblT.Text = LblT.Text + TxtN.Text + "|";
                T[i] = val;
                i++;
                TxtN.Text = "";
                TxtN.Focus();
                if (i == n)
                {
                    BtnCalc.Enabled = true;
                    BtnEnreg.Enabled = false;
                    TxtN.Enabled = false;
                    BtnCalc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer une note valide (nombre positif).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (i == n)
            {
                float moyenne = T.Average();
                float ecartType = CalculateEcartType(T);
                int inf10 = T.Count(x => x < 10);
                int supEq10 = T.Count(x => x >= 10);

                LblMoy.Text = $"{moyenne}";
                LblEcart.Text = $"{ecartType}";
                LblInf.Text = $"{inf10}";
                LblSup.Text = $"{supEq10}";
            }
            else
            {
                MessageBox.Show("Veuillez d'abord enregistrer les 5 notes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private float CalculateEcartType(float[] values)
        {
            float moyenne = values.Average();
            float variance = values.Select(val => (float)Math.Pow(val - moyenne, 2)).Sum() / values.Length;
            return (float)Math.Sqrt(variance);
        }

        private void LblT_Click(object sender, EventArgs e)
        {

        }
    }
}

