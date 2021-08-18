using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiBank_Loan_Calculator
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void btn_applyloan_Click(object sender, EventArgs e)
        {
            txt_age.ResetText();
            txt_email.ResetText();
            txt_loanamount.ResetText();
            txt_yearlyincome.ResetText();
            cmb_loanterm.ResetText();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string mainmsg = "";
            int age = 0;
            double loanamount = 0;
            double yearlyincome = 0;
            int loanterm = 0;
            string emailaddress = "";

            try
            {
                age = Convert.ToInt32(txt_age.Text);
                loanamount = Convert.ToDouble(txt_loanamount.Text);
                yearlyincome = Convert.ToDouble(txt_yearlyincome.Text);
                loanterm = Convert.ToInt32(cmb_loanterm.SelectedItem);
                emailaddress = txt_email.Text;

                int maxterm = 60 - age;
                double rate = loanamount / (yearlyincome * loanterm) * 100;

                if (age < 18)
                {
                    mainmsg = "Sorry, at this time you have not been approved for a loan. You must be at least 18 years old for a loan.";
                }
                else if (loanterm > maxterm)
                {
                    mainmsg = "Sorry, at this time you have not been approved for a loan. The loan term exceeds age 60.";
                }
                else if (loanamount > 100000)
                {
                    mainmsg = "Sorry, at this time you have not been approved for a loan. The loan must not exceed 100k.";
                }
                else
                {
                    mainmsg = "Congrats! You've been approved for a loan with UiBank, at the rate of " + rate.ToString("0.##") + "%! You new loan ID is " + Guid.NewGuid();
                }
                MessageBox.Show(mainmsg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! "+ex.Message);

            }
        }
    }
}
