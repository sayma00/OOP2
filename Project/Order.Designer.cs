namespace Bank_Loan_System
{
    partial class Order
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
            this.orderlabel = new System.Windows.Forms.Label();
            this.customerlabel = new System.Windows.Forms.Label();
            this.banklabel = new System.Windows.Forms.Label();
            this.commisionlabel = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.customertext = new System.Windows.Forms.TextBox();
            this.banktext = new System.Windows.Forms.TextBox();
            this.yesbutton = new System.Windows.Forms.RadioButton();
            this.nobutton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderlabel
            // 
            this.orderlabel.AutoSize = true;
            this.orderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlabel.Location = new System.Drawing.Point(12, 175);
            this.orderlabel.Name = "orderlabel";
            this.orderlabel.Size = new System.Drawing.Size(102, 29);
            this.orderlabel.TabIndex = 1;
            this.orderlabel.Text = "Order Id";
            // 
            // customerlabel
            // 
            this.customerlabel.AutoSize = true;
            this.customerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlabel.Location = new System.Drawing.Point(2, 235);
            this.customerlabel.Name = "customerlabel";
            this.customerlabel.Size = new System.Drawing.Size(143, 29);
            this.customerlabel.TabIndex = 2;
            this.customerlabel.Text = "Customer Id";
            // 
            // banklabel
            // 
            this.banklabel.AutoSize = true;
            this.banklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banklabel.Location = new System.Drawing.Point(34, 289);
            this.banklabel.Name = "banklabel";
            this.banklabel.Size = new System.Drawing.Size(93, 29);
            this.banklabel.TabIndex = 3;
            this.banklabel.Text = "Bank Id";
            // 
            // commisionlabel
            // 
            this.commisionlabel.AutoSize = true;
            this.commisionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commisionlabel.Location = new System.Drawing.Point(834, 299);
            this.commisionlabel.Name = "commisionlabel";
            this.commisionlabel.Size = new System.Drawing.Size(191, 29);
            this.commisionlabel.TabIndex = 4;
            this.commisionlabel.Text = "Commision Rate";
            this.commisionlabel.Click += new System.EventHandler(this.commisionlabel_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(849, 174);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(148, 29);
            this.statuslabel.TabIndex = 5;
            this.statuslabel.Text = "Order Status";
            // 
            // idtext
            // 
            this.idtext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtext.Location = new System.Drawing.Point(151, 174);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(155, 30);
            this.idtext.TabIndex = 6;
            // 
            // customertext
            // 
            this.customertext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.customertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customertext.Location = new System.Drawing.Point(151, 235);
            this.customertext.Name = "customertext";
            this.customertext.Size = new System.Drawing.Size(155, 30);
            this.customertext.TabIndex = 7;
            // 
            // banktext
            // 
            this.banktext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.banktext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banktext.Location = new System.Drawing.Point(151, 289);
            this.banktext.Name = "banktext";
            this.banktext.Size = new System.Drawing.Size(155, 30);
            this.banktext.TabIndex = 8;
            // 
            // yesbutton
            // 
            this.yesbutton.AutoSize = true;
            this.yesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbutton.Location = new System.Drawing.Point(823, 235);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(67, 29);
            this.yesbutton.TabIndex = 9;
            this.yesbutton.TabStop = true;
            this.yesbutton.Text = "Yes";
            this.yesbutton.UseVisualStyleBackColor = true;
            // 
            // nobutton
            // 
            this.nobutton.AutoSize = true;
            this.nobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobutton.Location = new System.Drawing.Point(939, 236);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(58, 29);
            this.nobutton.TabIndex = 10;
            this.nobutton.TabStop = true;
            this.nobutton.Text = "No";
            this.nobutton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(242, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 67);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bank Loan Management System";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 561);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_Loan_System.Properties.Resources.orderrrrr;
            this.pictureBox1.Location = new System.Drawing.Point(338, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1072, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nobutton);
            this.Controls.Add(this.yesbutton);
            this.Controls.Add(this.banktext);
            this.Controls.Add(this.customertext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.commisionlabel);
            this.Controls.Add(this.banklabel);
            this.Controls.Add(this.customerlabel);
            this.Controls.Add(this.orderlabel);
            this.Name = "Order";
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label orderlabel;
        private System.Windows.Forms.Label customerlabel;
        private System.Windows.Forms.Label banklabel;
        private System.Windows.Forms.Label commisionlabel;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox customertext;
        private System.Windows.Forms.TextBox banktext;
        private System.Windows.Forms.RadioButton yesbutton;
        private System.Windows.Forms.RadioButton nobutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}