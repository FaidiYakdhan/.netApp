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
    public partial class Jeux : Form
    {
        public Jeux()
        {
            InitializeComponent();
        }
        List<TextBox> LTxtC = new List<TextBox>();
        List<TextBox> LTxtP = new List<TextBox>();
        int nbJeux = 0; bool animation = false;
        System.Timers.Timer timer1 = new(interval: 1000);


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            int correct = 0;
            for (int i = 0; i < 4; i++)
            {
                if (LTxtP[i].Text == LTxtC[i].Text)
                {
                    LTxtP[i].BackColor = Color.Lime;
                    correct++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (LTxtP[i].Text == LTxtC[j].Text)
                        {
                            LTxtP[i].BackColor = Color.Yellow;
                            break;
                        }
                    }
                }
            }

            if (correct == 4)
            {
                timer1.Start();
                for (int i = 0; i < 4; i++)
                    LTxtC[i].ForeColor = Color.Black;
            }
            else
            {
                nbJeux++;
                LblNbJeux.Text = (nbJeux + 1).ToString();
                if (nbJeux == 3)
                {
                    groupBox3.Enabled = false;
                    for (int i = 0; i < 4; i++)
                        LTxtC[i].ForeColor = Color.Black;
                    MessageBox.Show("Vous avez perdu", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void Quitter_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez-vous quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Nouvelle_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;
            Random random = new Random();

            n1 = random.Next(0, 10);
            Txt1.Text = n1.ToString();

            do
            {
                n2 = random.Next(0, 10);
            } while (n2 == n1);
            Txt2.Text = n2.ToString();

            do
            {
                n3 = random.Next(0, 10);
            } while (n3 == n2 || n3 == n1);
            Txt3.Text = n3.ToString();

            do
            {
                n4 = random.Next(0, 10);
            } while (n4 == n3 || n4 == n2 || n4 == n1);
            Txt4.Text = n4.ToString();

            LTxtC.Add(Txt1);
            LTxtC.Add(Txt2);
            LTxtC.Add(Txt3);
            LTxtC.Add(Txt4);

            LTxtP.Add(TxtP1);
            LTxtP.Add(TxtP2);
            LTxtP.Add(TxtP3);
            LTxtP.Add(TxtP4);

        }

        private void Rejouer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].BackColor = Color.White;
                LTxtP[i].Text = "";
            }
            LTxtP[0].Focus();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (animation)
            {
                for (int i = 0; i < 4; i++)
                    LTxtC[i].BackColor = Color.Yellow;
                animation = false;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                    LTxtC[i].BackColor = Color.Red;
                animation = true;
            }
        }

        private void Cacher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                LTxtC[i].ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Afficher_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
                LTxtC[i].ForeColor = Color.Black;
        }

        private void Jeux_Load(object sender, EventArgs e)
        {

        }
    }
}
