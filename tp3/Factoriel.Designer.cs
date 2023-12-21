namespace tp3
{
    partial class Factoriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factoriel));
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BtnCalc = new Button();
            TxtN = new TextBox();
            LblRes = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            BtnQuitter = new Button();
            BtnBack = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(393, 23);
            label1.TabIndex = 0;
            label1.Text = "Factoriel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 85);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnCalc);
            groupBox2.Controls.Add(TxtN);
            groupBox2.Controls.Add(LblRes);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(3, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 206);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // BtnCalc
            // 
            BtnCalc.Image = (Image)resources.GetObject("BtnCalc.Image");
            BtnCalc.ImageAlign = ContentAlignment.TopLeft;
            BtnCalc.Location = new Point(379, 39);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(75, 68);
            BtnCalc.TabIndex = 3;
            BtnCalc.Text = "Calculer";
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // TxtN
            // 
            TxtN.Location = new Point(41, 82);
            TxtN.Name = "TxtN";
            TxtN.Size = new Size(232, 25);
            TxtN.TabIndex = 2;
            TxtN.TextChanged += TxtN_TextChanged;
            // 
            // LblRes
            // 
            LblRes.BackColor = SystemColors.ButtonHighlight;
            LblRes.BorderStyle = BorderStyle.FixedSingle;
            LblRes.ImageAlign = ContentAlignment.BottomCenter;
            LblRes.Location = new Point(41, 134);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(413, 29);
            LblRes.TabIndex = 1;
            LblRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 50);
            label2.Name = "label2";
            label2.Size = new Size(163, 17);
            label2.TabIndex = 0;
            label2.Text = "Donner un entier positif:";
            label2.Click += label2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuitter);
            groupBox3.Controls.Add(BtnBack);
            groupBox3.Location = new Point(3, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(496, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // BtnQuitter
            // 
            BtnQuitter.BackColor = Color.Red;
            BtnQuitter.Image = (Image)resources.GetObject("BtnQuitter.Image");
            BtnQuitter.ImageAlign = ContentAlignment.TopLeft;
            BtnQuitter.Location = new Point(301, 24);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(153, 56);
            BtnQuitter.TabIndex = 4;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = false;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Green;
            BtnBack.Image = (Image)resources.GetObject("BtnBack.Image");
            BtnBack.ImageAlign = ContentAlignment.TopLeft;
            BtnBack.Location = new Point(41, 24);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(158, 56);
            BtnBack.TabIndex = 5;
            BtnBack.Text = "Retour";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // Factoriel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Factoriel";
            Text = "Calcul Factoriel";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnCalc;
        private TextBox TxtN;
        private Label LblRes;
        private Label label2;
        private GroupBox groupBox3;
        private Button BtnQuitter;
        private Button BtnBack;
    }
}