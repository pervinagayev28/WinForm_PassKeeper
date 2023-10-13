using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class ForgotPassActivateCode : Form
    {
        public ForgotPassActivateCode()
        {
            InitializeComponent();
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbox_resend_code_gmail.Text) != ForgetPasswordSendCode.vc)
                {
                    lbl_verifycode_error.Visible = true;
                    return;
                }

            }
            catch (Exception)
            {

                lbl_verifycode_error.Visible = true;
                return;
            }


            Forms.forgotPassActivateCode.Close();
            Forms.CreatNewPass = new();
            Forms.CreatNewPass.StartPosition = FormStartPosition.Manual;
            Forms.CreatNewPass.Location = this.Location;
            Forms.CreatNewPass.ShowDialog();
        }

        private void ForgotPassActivateCode_Load(object sender, EventArgs e)
        {
        }

        private void tbox_resend_code_gmail_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_resend_code_gmail.Text == " code")
                tbox_resend_code_gmail.Text = "";
        }

        private void tbox_resend_code_gmail_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_resend_code_gmail.Text == "")
                tbox_resend_code_gmail.Text = " code";
        }

        private void ForgotPassActivateCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.forgotPassActivateCode.Dispose();

        }

        private void lbl_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
