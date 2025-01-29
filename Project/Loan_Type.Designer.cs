namespace Bank_Loan_System
{
    partial class Loan_Type
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
            this.loanlabel = new System.Windows.Forms.Label();
            this.typelabel = new System.Windows.Forms.Label();
            this.amountlabel = new System.Windows.Forms.Label();
            this.ratelabel = new System.Windows.Forms.Label();
            this.loantext = new System.Windows.Forms.TextBox();
            this.typecombo = new System.Windows.Forms.ComboBox();
            this.amounttext = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loanlabel
            // 
            this.loanlabel.AutoSize = true;
            this.loanlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanlabel.Location = new System.Drawing.Point(102, 128);
            this.loanlabel.Name = "loanlabel";
            this.loanlabel.Size = new System.Drawing.Size(92, 29);
            this.loanlabel.TabIndex = 0;
            this.loanlabel.Text = "Loan Id";
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelabel.Location = new System.Drawing.Point(67, 196);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(127, 29);
            this.typelabel.TabIndex = 1;
            this.typelabel.Text = "Loan Type";
            this.typelabel.Click += new System.EventHandler(this.typelabel_Click);
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel.Location = new System.Drawing.Point(544, 128);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(153, 29);
            this.amountlabel.TabIndex = 2;
            this.amountlabel.Text = "Loan Amount";
            this.amountlabel.Click += new System.EventHandler(this.amountlabel_Click);
            // 
            // ratelabel
            // 
            this.ratelabel.AutoSize = true;
            this.ratelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratelabel.Location = new System.Drawing.Point(549, 196);
            this.ratelabel.Name = "ratelabel";
            this.ratelabel.Size = new System.Drawing.Size(148, 29);
            this.ratelabel.TabIndex = 3;
            this.ratelabel.Text = "Interest Rate";
            // 
            // loantext
            // 
            this.loantext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loantext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loantext.Location = new System.Drawing.Point(242, 128);
            this.loantext.Name = "loantext";
            this.loantext.Size = new System.Drawing.Size(261, 30);
            this.loantext.TabIndex = 4;
            this.loantext.TextChanged += new System.EventHandler(this.loantext_TextChanged);
            // 
            // typecombo
            // 
            this.typecombo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.typecombo.FormattingEnabled = true;
            this.typecombo.Items.AddRange(new object[] {
            "Student Loan",
            "Business Loan",
            "Home Loan",
            "Treatment Loan"});
            this.typecombo.Location = new System.Drawing.Point(232, 196);
            this.typecombo.Name = "typecombo";
            this.typecombo.Size = new System.Drawing.Size(260, 24);
            this.typecombo.TabIndex = 5;
            // 
            // amounttext
            // 
            this.amounttext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.amounttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttext.Location = new System.Drawing.Point(703, 128);
            this.amounttext.Name = "amounttext";
            this.amounttext.Size = new System.Drawing.Size(208, 30);
            this.amounttext.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(170, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 67);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bank Loan Management System";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_Loan_System.Properties.Resources.Icon3;
            this.pictureBox1.Location = new System.Drawing.Point(5, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Loan_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.amounttext);
            this.Controls.Add(this.typecombo);
            this.Controls.Add(this.loantext);
            this.Controls.Add(this.ratelabel);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.loanlabel);
            this.Name = "Loan_Type";
            this.Text = "Loan_Type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanlabel;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.Label ratelabel;
        private System.Windows.Forms.TextBox loantext;
        private System.Windows.Forms.ComboBox typecombo;
        private System.Windows.Forms.TextBox amounttext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}