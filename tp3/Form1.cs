namespace tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFactoriel_Click(object sender, EventArgs e)
        {
            Factoriel cl = new Factoriel();
            cl.Show();
            this.Hide();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnTab_Click(object sender, EventArgs e)
        {
            Tableau cl = new Tableau();
            cl.Show();
            this.Hide();
        }

        private void BtnJouer_Click(object sender, EventArgs e)
        {
            Jeux cl = new Jeux();
            cl.Show();
            this.Hide();
        }
    }
}