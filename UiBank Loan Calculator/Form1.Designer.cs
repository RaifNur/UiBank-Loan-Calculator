
namespace UiBank_Loan_Calculator
{
    partial class form_main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_applyloan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_loanamount = new System.Windows.Forms.TextBox();
            this.cmb_loanterm = new System.Windows.Forms.ComboBox();
            this.txt_yearlyincome = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UiBank_Loan_Calculator.Properties.Resources.UiBankLogo_Blue;
            this.pictureBox1.Location = new System.Drawing.Point(32, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_applyloan
            // 
            this.btn_applyloan.Location = new System.Drawing.Point(684, 26);
            this.btn_applyloan.Name = "btn_applyloan";
            this.btn_applyloan.Size = new System.Drawing.Size(75, 23);
            this.btn_applyloan.TabIndex = 1;
            this.btn_applyloan.Text = "Apply Loan";
            this.btn_applyloan.UseVisualStyleBackColor = true;
            this.btn_applyloan.Click += new System.EventHandler(this.btn_applyloan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(294, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "UiBank Loan Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(289, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hi! Enter some details below to get started!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email address of requester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loan amount requested";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loan term";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Current yearly income (before taxes)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Age";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(32, 184);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(283, 23);
            this.txt_email.TabIndex = 9;
            // 
            // txt_loanamount
            // 
            this.txt_loanamount.Location = new System.Drawing.Point(32, 242);
            this.txt_loanamount.Name = "txt_loanamount";
            this.txt_loanamount.Size = new System.Drawing.Size(283, 23);
            this.txt_loanamount.TabIndex = 10;
            // 
            // cmb_loanterm
            // 
            this.cmb_loanterm.FormattingEnabled = true;
            this.cmb_loanterm.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10"});
            this.cmb_loanterm.Location = new System.Drawing.Point(32, 297);
            this.cmb_loanterm.Name = "cmb_loanterm";
            this.cmb_loanterm.Size = new System.Drawing.Size(283, 23);
            this.cmb_loanterm.TabIndex = 11;
            // 
            // txt_yearlyincome
            // 
            this.txt_yearlyincome.Location = new System.Drawing.Point(465, 184);
            this.txt_yearlyincome.Name = "txt_yearlyincome";
            this.txt_yearlyincome.Size = new System.Drawing.Size(294, 23);
            this.txt_yearlyincome.TabIndex = 12;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(465, 242);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(294, 23);
            this.txt_age.TabIndex = 13;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(465, 297);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(294, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit Loan Application";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_yearlyincome);
            this.Controls.Add(this.cmb_loanterm);
            this.Controls.Add(this.txt_loanamount);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_applyloan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "form_main";
            this.Text = "Loan Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_applyloan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_loanamount;
        private System.Windows.Forms.ComboBox cmb_loanterm;
        private System.Windows.Forms.TextBox txt_yearlyincome;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button btn_submit;
    }
}

