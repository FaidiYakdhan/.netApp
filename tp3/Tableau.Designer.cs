namespace tp3
{
    partial class Tableau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tableau));
            groupBox1 = new GroupBox();
            TxtN = new TextBox();
            BtnEnreg = new Button();
            LblT = new Label();
            LblRes = new Label();
            groupBox2 = new GroupBox();
            LblSup = new Label();
            LblInf = new Label();
            LblEcart = new Label();
            BtnQ = new Button();
            BtnCalc = new Button();
            LblMoy = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtN);
            groupBox1.Controls.Add(BtnEnreg);
            groupBox1.Controls.Add(LblT);
            groupBox1.Controls.Add(LblRes);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enrregistrement des Notes:";
            // 
            // TxtN
            // 
            TxtN.Location = new Point(262, 32);
            TxtN.Name = "TxtN";
            TxtN.Size = new Size(100, 25);
            TxtN.TabIndex = 3;
            TxtN.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnEnreg
            // 
            BtnEnreg.Image = (Image)resources.GetObject("BtnEnreg.Image");
            BtnEnreg.ImageAlign = ContentAlignment.TopLeft;
            BtnEnreg.Location = new Point(433, 26);
            BtnEnreg.Name = "BtnEnreg";
            BtnEnreg.Size = new Size(147, 35);
            BtnEnreg.TabIndex = 2;
            BtnEnreg.Text = "Enregistrer";
            BtnEnreg.UseVisualStyleBackColor = true;
            BtnEnreg.Click += BtnEnreg_Click;
            // 
            // LblT
            // 
            LblT.BackColor = SystemColors.ButtonHighlight;
            LblT.BorderStyle = BorderStyle.FixedSingle;
            LblT.Location = new Point(235, 73);
            LblT.Name = "LblT";
            LblT.Size = new Size(230, 37);
            LblT.TabIndex = 1;
            LblT.TextAlign = ContentAlignment.MiddleCenter;
            LblT.Click += LblT_Click;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(67, 35);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(189, 17);
            LblRes.TabIndex = 0;
            LblRes.Text = "Entrez la note de l'èléve N : 5\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LblSup);
            groupBox2.Controls.Add(LblInf);
            groupBox2.Controls.Add(LblEcart);
            groupBox2.Controls.Add(BtnQ);
            groupBox2.Controls.Add(BtnCalc);
            groupBox2.Controls.Add(LblMoy);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // LblSup
            // 
            LblSup.BorderStyle = BorderStyle.FixedSingle;
            LblSup.Location = new Point(204, 114);
            LblSup.Name = "LblSup";
            LblSup.Size = new Size(158, 17);
            LblSup.TabIndex = 13;
            LblSup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblInf
            // 
            LblInf.BorderStyle = BorderStyle.FixedSingle;
            LblInf.Location = new Point(204, 84);
            LblInf.Name = "LblInf";
            LblInf.Size = new Size(158, 17);
            LblInf.TabIndex = 12;
            LblInf.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblEcart
            // 
            LblEcart.BorderStyle = BorderStyle.FixedSingle;
            LblEcart.Location = new Point(204, 53);
            LblEcart.Name = "LblEcart";
            LblEcart.Size = new Size(158, 17);
            LblEcart.TabIndex = 11;
            LblEcart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnQ
            // 
            BtnQ.Image = (Image)resources.GetObject("BtnQ.Image");
            BtnQ.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQ.Location = new Point(423, 85);
            BtnQ.Name = "BtnQ";
            BtnQ.Size = new Size(157, 46);
            BtnQ.TabIndex = 10;
            BtnQ.Text = "Quitter";
            BtnQ.UseVisualStyleBackColor = true;
            BtnQ.Click += BtnQ_Click;
            // 
            // BtnCalc
            // 
            BtnCalc.Image = (Image)resources.GetObject("BtnCalc.Image");
            BtnCalc.ImageAlign = ContentAlignment.TopLeft;
            BtnCalc.Location = new Point(423, 24);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(157, 46);
            BtnCalc.TabIndex = 4;
            BtnCalc.Text = "Calculer";
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // LblMoy
            // 
            LblMoy.BorderStyle = BorderStyle.FixedSingle;
            LblMoy.Location = new Point(204, 21);
            LblMoy.Name = "LblMoy";
            LblMoy.Size = new Size(158, 17);
            LblMoy.TabIndex = 6;
            LblMoy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 114);
            label6.Name = "label6";
            label6.Size = new Size(167, 17);
            label6.TabIndex = 5;
            label6.Text = "Nombre des Notes >= 10:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 84);
            label5.Name = "label5";
            label5.Size = new Size(158, 17);
            label5.TabIndex = 4;
            label5.Text = "Nombre des Notes < 10:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 53);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 3;
            label4.Text = "L'ecart-type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 21);
            label3.Name = "label3";
            label3.Size = new Size(143, 17);
            label3.TabIndex = 2;
            label3.Text = "Moyenne de la classe:";
            label3.Click += label3_Click;
            // 
            // Tableau
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Tableau";
            Text = "Les Tableaux";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblT;
        private Label LblRes;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox TxtN;
        private Button BtnEnreg;
        private Label LblMoy;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BtnQ;
        private Button BtnCalc;
        private Label LblSup;
        private Label LblInf;
        private Label LblEcart;
    }
}