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
    public partial class form_sign_in : Form
    {
        public form_sign_in()
        {
            InitializeComponent();
        }

        private void form_sign_in_Load(object sender, EventArgs e)
        {

        }

        private void tbox_log_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_log_in_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_log_in.Text == "")
                tbox_log_in.Text = " log in";
        }

        private void tbox_log_in_Click(object sender, EventArgs e)
        {
            tbox_log_in.Text = "";
        }

        private void tbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_password_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void tbox_password_Click(object sender, EventArgs e)
        {
            tbox_password.Text = "";
        }

        private void tbox_password_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_password.Text == "")
                tbox_password.Text = " password";
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            if (tbox_log_in.Text == " log in" || tbox_password.Text == " password")
            {
                lbl_not_found_account.Text = "is empty";
                lbl_not_found_account.Visible = true;
                return;
            }
            foreach (var user in User.users)
            {
                lbl_not_found_account.Text = "not found account";
                if (user.FirstName == Forms.FSignIn.tbox_log_in.Text.ToString() && user.Password == Forms.FSignIn.tbox_password.Text.ToString())
                {
                    lbl_not_found_account.Visible = true;
                    var loc = Forms.FSignIn.Location;
                    Forms.FSignIn.Close();
                    Forms.landingProfile = new();
                    if (user.ImagePath != default)
                        Forms.landingProfile.pictureBox1.Image = new Bitmap(user.ImagePath);
                    Forms.landingProfile.tbox_first_name.Text = user.FirstName;
                    Forms.landingProfile.tbox_last_name.Text = user.LastName;
                    Forms.landingProfile.tbox_password.Text = user.Password;
                    Forms.landingProfile.tbox_gmail.Text = user.Email;

                    Forms.landingProfile.StartPosition = FormStartPosition.Manual;
                    Forms.landingProfile.Location = loc;
                    Forms.landingProfile.ShowDialog();
                }
            }
            lbl_not_found_account.Text = "not found account";
            lbl_not_found_account.Visible = true;

        }

        private void lbl_forgotpassword_Click(object sender, EventArgs e)
        {
            Forms.FSignIn.Close();
            Forms.FForgetPassSendCode = new();
            Forms.FForgetPassSendCode.StartPosition = FormStartPosition.Manual;
            Forms.FForgetPassSendCode.Location =this.Location;
            Forms.FForgetPassSendCode.ShowDialog();
        }

        private void lbl_forgotpassword_MouseEnter(object sender, EventArgs e)
        {
            lbl_forgotpassword.Font = new Font(lbl_forgotpassword.Font.FontFamily.ToString(), (int)lbl_forgotpassword.Font.Size + 1, lbl_forgotpassword.Font.Style);
        }

        private void lbl_forgotpassword_MouseLeave(object sender, EventArgs e)
        {
            lbl_forgotpassword.Font = new Font(lbl_forgotpassword.Font.FontFamily.ToString(), (int)lbl_forgotpassword.Font.Size - 1, lbl_forgotpassword.Font.Style);

        }

        private void form_sign_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.FSignIn.Dispose();
        }
    }
}
