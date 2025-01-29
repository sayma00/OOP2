namespace Bank_Loan_System
{
    partial class Review
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.banklabel = new System.Windows.Forms.Label();
            this.loanlabel = new System.Windows.Forms.Label();
            this.customerlabel = new System.Windows.Forms.Label();
            this.commentlabel = new System.Windows.Forms.Label();
            this.ratinglabel = new System.Windows.Forms.Label();
            this.banktext = new System.Windows.Forms.TextBox();
            this.loantext = new System.Windows.Forms.TextBox();
            this.customertext = new System.Windows.Forms.TextBox();
            this.commentpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ratingpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.commentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(199, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 67);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 43);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bank Loan Management System";
            // 
            // banklabel
            // 
            this.banklabel.AutoSize = true;
            this.banklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banklabel.Location = new System.Drawing.Point(357, 170);
            this.banklabel.Name = "banklabel";
            this.banklabel.Size = new System.Drawing.Size(93, 29);
            this.banklabel.TabIndex = 17;
            this.banklabel.Text = "Bank Id";
            // 
            // loanlabel
            // 
            this.loanlabel.AutoSize = true;
            this.loanlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanlabel.Location = new System.Drawing.Point(357, 220);
            this.loanlabel.Name = "loanlabel";
            this.loanlabel.Size = new System.Drawing.Size(92, 29);
            this.loanlabel.TabIndex = 18;
            this.loanlabel.Text = "Loan Id";
            this.loanlabel.Click += new System.EventHandler(this.loanlabel_Click);
            // 
            // customerlabel
            // 
            this.customerlabel.AutoSize = true;
            this.customerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlabel.Location = new System.Drawing.Point(307, 271);
            this.customerlabel.Name = "customerlabel";
            this.customerlabel.Size = new System.Drawing.Size(143, 29);
            this.customerlabel.TabIndex = 19;
            this.customerlabel.Text = "Customer Id";
            // 
            // commentlabel
            // 
            this.commentlabel.AutoSize = true;
            this.commentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentlabel.Location = new System.Drawing.Point(94, 124);
            this.commentlabel.Name = "commentlabel";
            this.commentlabel.Size = new System.Drawing.Size(124, 29);
            this.commentlabel.TabIndex = 20;
            this.commentlabel.Text = "Comment";
            // 
            // ratinglabel
            // 
            this.ratinglabel.AutoSize = true;
            this.ratinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratinglabel.Location = new System.Drawing.Point(853, 138);
            this.ratinglabel.Name = "ratinglabel";
            this.ratinglabel.Size = new System.Drawing.Size(88, 29);
            this.ratinglabel.TabIndex = 21;
            this.ratinglabel.Text = "Rating";
            // 
            // banktext
            // 
            this.banktext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.banktext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banktext.Location = new System.Drawing.Point(468, 170);
            this.banktext.Name = "banktext";
            this.banktext.Size = new System.Drawing.Size(249, 30);
            this.banktext.TabIndex = 22;
            // 
            // loantext
            // 
            this.loantext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loantext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loantext.Location = new System.Drawing.Point(466, 219);
            this.loantext.Name = "loantext";
            this.loantext.Size = new System.Drawing.Size(251, 30);
            this.loantext.TabIndex = 23;
            // 
            // customertext
            // 
            this.customertext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.customertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customertext.Location = new System.Drawing.Point(468, 271);
            this.customertext.Name = "customertext";
            this.customertext.Size = new System.Drawing.Size(249, 30);
            this.customertext.TabIndex = 24;
            // 
            // commentpanel
            // 
            this.commentpanel.BackColor = System.Drawing.Color.White;
            this.commentpanel.Controls.Add(this.label1);
            this.commentpanel.Location = new System.Drawing.Point(12, 170);
            this.commentpanel.Name = "commentpanel";
            this.commentpanel.Size = new System.Drawing.Size(282, 162);
            this.commentpanel.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ratingpanel
            // 
            this.ratingpanel.BackColor = System.Drawing.Color.Tan;
            this.ratingpanel.Location = new System.Drawing.Point(829, 182);
            this.ratingpanel.Name = "ratingpanel";
            this.ratingpanel.Size = new System.Drawing.Size(169, 115);
            this.ratingpanel.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(858, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_Loan_System.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1043, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1028, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ratingpanel);
            this.Controls.Add(this.commentpanel);
            this.Controls.Add(this.customertext);
            this.Controls.Add(this.loantext);
            this.Controls.Add(this.banktext);
            this.Controls.Add(this.ratinglabel);
            this.Controls.Add(this.commentlabel);
            this.Controls.Add(this.customerlabel);
            this.Controls.Add(this.loanlabel);
            this.Controls.Add(this.banklabel);
            this.Controls.Add(this.panel1);
            this.Name = "Review";
            this.Text = "Review";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.commentpanel.ResumeLayout(false);
            this.commentpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label banklabel;
        private System.Windows.Forms.Label loanlabel;
        private System.Windows.Forms.Label customerlabel;
        private System.Windows.Forms.Label commentlabel;
        private System.Windows.Forms.Label ratinglabel;
        private System.Windows.Forms.TextBox banktext;
        private System.Windows.Forms.TextBox loantext;
        private System.Windows.Forms.TextBox customertext;
        private System.Windows.Forms.Panel commentpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ratingpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}