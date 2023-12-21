namespace tp3
{
    partial class Jeux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            LblNbJeux = new Label();
            Cacher = new Button();
            Afficher = new Button();
            Nouvelle = new Button();
            groupBox2 = new GroupBox();
            Txt4 = new TextBox();
            Txt3 = new TextBox();
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            groupBox3 = new GroupBox();
            TxtP4 = new TextBox();
            TxtP3 = new TextBox();
            TxtP2 = new TextBox();
            TxtP1 = new TextBox();
            Rejouer = new Button();
            Quitter = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Nomber Caché";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblNbJeux);
            groupBox1.Controls.Add(Cacher);
            groupBox1.Controls.Add(Afficher);
            groupBox1.Controls.Add(Nouvelle);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 137);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // LblNbJeux
            // 
            LblNbJeux.BorderStyle = BorderStyle.FixedSingle;
            LblNbJeux.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LblNbJeux.Location = new Point(209, 101);
            LblNbJeux.Name = "LblNbJeux";
            LblNbJeux.Size = new Size(142, 25);
            LblNbJeux.TabIndex = 7;
            LblNbJeux.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cacher
            // 
            Cacher.Location = new Point(472, 75);
            Cacher.Name = "Cacher";
            Cacher.Size = new Size(101, 23);
            Cacher.TabIndex = 6;
            Cacher.Text = "Cacher";
            Cacher.UseVisualStyleBackColor = true;
            Cacher.Click += Cacher_Click;
            // 
            // Afficher
            // 
            Afficher.Location = new Point(472, 32);
            Afficher.Name = "Afficher";
            Afficher.Size = new Size(101, 23);
            Afficher.TabIndex = 5;
            Afficher.Text = "Afficher";
            Afficher.UseVisualStyleBackColor = true;
            Afficher.Click += Afficher_Click;
            // 
            // Nouvelle
            // 
            Nouvelle.Location = new Point(25, 32);
            Nouvelle.Name = "Nouvelle";
            Nouvelle.Size = new Size(75, 53);
            Nouvelle.TabIndex = 4;
            Nouvelle.Text = "Nouvelle Partie";
            Nouvelle.UseVisualStyleBackColor = true;
            Nouvelle.Click += Nouvelle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Txt4);
            groupBox2.Controls.Add(Txt3);
            groupBox2.Controls.Add(Txt1);
            groupBox2.Controls.Add(Txt2);
            groupBox2.Location = new Point(120, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 74);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Numéro à deviner";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Txt4
            // 
            Txt4.Location = new Point(220, 30);
            Txt4.Name = "Txt4";
            Txt4.Size = new Size(37, 25);
            Txt4.TabIndex = 11;
            // 
            // Txt3
            // 
            Txt3.Location = new Point(155, 30);
            Txt3.Name = "Txt3";
            Txt3.Size = new Size(37, 25);
            Txt3.TabIndex = 9;
            // 
            // Txt1
            // 
            Txt1.Location = new Point(25, 30);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(37, 25);
            Txt1.TabIndex = 8;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(89, 30);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(37, 25);
            Txt2.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtP4);
            groupBox3.Controls.Add(TxtP3);
            groupBox3.Controls.Add(TxtP2);
            groupBox3.Controls.Add(TxtP1);
            groupBox3.Location = new Point(132, 194);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(329, 74);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Votre proposition";
            // 
            // TxtP4
            // 
            TxtP4.Location = new Point(220, 30);
            TxtP4.Name = "TxtP4";
            TxtP4.Size = new Size(36, 25);
            TxtP4.TabIndex = 13;
            // 
            // TxtP3
            // 
            TxtP3.Location = new Point(154, 28);
            TxtP3.Name = "TxtP3";
            TxtP3.Size = new Size(36, 25);
            TxtP3.TabIndex = 12;
            // 
            // TxtP2
            // 
            TxtP2.Location = new Point(89, 28);
            TxtP2.Name = "TxtP2";
            TxtP2.Size = new Size(36, 25);
            TxtP2.TabIndex = 11;
            TxtP2.TextChanged += textBox1_TextChanged_1;
            // 
            // TxtP1
            // 
            TxtP1.Location = new Point(26, 28);
            TxtP1.Name = "TxtP1";
            TxtP1.Size = new Size(36, 25);
            TxtP1.TabIndex = 10;
            TxtP1.TextChanged += textBox1_TextChanged;
            // 
            // Rejouer
            // 
            Rejouer.Location = new Point(12, 215);
            Rejouer.Name = "Rejouer";
            Rejouer.Size = new Size(101, 23);
            Rejouer.TabIndex = 7;
            Rejouer.Text = "Rejouer";
            Rejouer.UseVisualStyleBackColor = true;
            Rejouer.Click += Rejouer_Click;
            // 
            // Quitter
            // 
            Quitter.Location = new Point(221, 314);
            Quitter.Name = "Quitter";
            Quitter.Size = new Size(101, 23);
            Quitter.TabIndex = 8;
            Quitter.Text = "Quitter";
            Quitter.UseVisualStyleBackColor = true;
            Quitter.Click += Quitter_Click;
            // 
            // button6
            // 
            button6.Location = new Point(484, 224);
            button6.Name = "button6";
            button6.Size = new Size(101, 23);
            button6.TabIndex = 9;
            button6.Text = "Verifier";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Jeux
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(button6);
            Controls.Add(Quitter);
            Controls.Add(Rejouer);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Jeux";
            Text = "Jeux";
            Load += Jeux_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label LblNbJeux;
        private Button Cacher;
        private Button Afficher;
        private Button Nouvelle;
        private GroupBox groupBox3;
        private Button Rejouer;
        private Button Quitter;
        private Button button6;
        private TextBox Txt3;
        private TextBox Txt1;
        private TextBox Txt2;
        private TextBox Txt4;
        private TextBox TxtP1;
        private TextBox TxtP2;
        private TextBox TxtP4;
        private TextBox TxtP3;
    }
}