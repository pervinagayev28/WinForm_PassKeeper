using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class ForgetPasswordSendCode : Form
    {
        public static int vc = default;
        public static string gmail = default;
        public ForgetPasswordSendCode()
        {
            InitializeComponent();
        }

        private void tbox_resend_code_gmail_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_resend_code_gmail.Text == " e-mail")
                tbox_resend_code_gmail.Text = "";
        }

        private void tbox_resend_code_gmail_MouseLeave(object sender, EventArgs e)
        {

            if (tbox_resend_code_gmail.Text == "")
            {
                tbox_resend_code_gmail.Text = " e-mail";
                lbl_gmail_error.Visible = false;
            }

            else
            {
                if (!Regex.IsMatch(tbox_resend_code_gmail.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
                {
                    lbl_gmail_error.Visible = true;
                }
                else
                    lbl_gmail_error.Visible = false;
            }
        }

        private void tbox_resend_code_gmail_TextChanged(object sender, EventArgs e)
        {
            if (tbox_resend_code_gmail.Text.Length == 10 || tbox_resend_code_gmail.Text.Length == 15 || tbox_resend_code_gmail.Text.Length == 19)
                tbox_resend_code_gmail.Font = new Font(tbox_resend_code_gmail.Font.FontFamily.ToString(), (int)tbox_resend_code_gmail.Font.Size - 2, tbox_resend_code_gmail.Font.Style);
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            if (lbl_gmail_error.Visible == false && tbox_resend_code_gmail.Text != " e-mail")
            {
                try
                {
                    vc = SmtpServerConnection.GmailVerify(tbox_resend_code_gmail.Text);
                }
                catch (Exception)
                {
                    lbl_gmail_error.Visible = true;
                    return;
                }
                gmail = tbox_resend_code_gmail.Text;
                Forms.FForgetPassSendCode.Close();
                Forms.forgotPassActivateCode = new();
                Forms.forgotPassActivateCode.StartPosition = FormStartPosition.Manual;
                Forms.forgotPassActivateCode.Location = this.Location;
                Forms.forgotPassActivateCode.ShowDialog();
            }
        }

        private void ForgetPasswordSendCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.FForgetPassSendCode.Dispose();

        }

        private void ForgetPasswordSendCode_Load(object sender, EventArgs e)
        {

        }
    }
}
