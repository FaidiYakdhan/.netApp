namespace tp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnFactoriel = new Button();
            BtnTab = new Button();
            BtnJouer = new Button();
            BtnQuitter = new Button();
            SuspendLayout();
            // 
            // BtnFactoriel
            // 
            BtnFactoriel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFactoriel.Image = (Image)resources.GetObject("BtnFactoriel.Image");
            BtnFactoriel.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFactoriel.Location = new Point(212, 43);
            BtnFactoriel.Name = "BtnFactoriel";
            BtnFactoriel.Size = new Size(221, 25);
            BtnFactoriel.TabIndex = 0;
            BtnFactoriel.Text = "Calcul Facturiel";
            BtnFactoriel.UseVisualStyleBackColor = true;
            BtnFactoriel.Click += BtnFactoriel_Click;
            // 
            // BtnTab
            // 
            BtnTab.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTab.ForeColor = Color.Black;
            BtnTab.Image = (Image)resources.GetObject("BtnTab.Image");
            BtnTab.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTab.Location = new Point(212, 74);
            BtnTab.Name = "BtnTab";
            BtnTab.Size = new Size(221, 25);
            BtnTab.TabIndex = 1;
            BtnTab.Text = "Les Tableaux";
            BtnTab.UseVisualStyleBackColor = true;
            BtnTab.Click += BtnTab_Click;
            // 
            // BtnJouer
            // 
            BtnJouer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnJouer.ForeColor = Color.Black;
            BtnJouer.Image = (Image)resources.GetObject("BtnJouer.Image");
            BtnJouer.ImageAlign = ContentAlignment.MiddleLeft;
            BtnJouer.Location = new Point(212, 105);
            BtnJouer.Name = "BtnJouer";
            BtnJouer.Size = new Size(221, 25);
            BtnJouer.TabIndex = 2;
            BtnJouer.Text = "Jouer";
            BtnJouer.UseVisualStyleBackColor = true;
            BtnJouer.Click += BtnJouer_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnQuitter.ForeColor = Color.Black;
            BtnQuitter.Image = (Image)resources.GetObject("BtnQuitter.Image");
            BtnQuitter.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQuitter.Location = new Point(212, 136);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(221, 25);
            BtnQuitter.TabIndex = 3;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 334);
            Controls.Add(BtnQuitter);
            Controls.Add(BtnJouer);
            Controls.Add(BtnTab);
            Controls.Add(BtnFactoriel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnFactoriel;
        private Button BtnTab;
        private Button BtnJouer;
        private Button BtnQuitter;
    }
}