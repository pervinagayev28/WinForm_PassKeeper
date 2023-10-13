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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void tbox_new_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_fisrtname_Click(object sender, EventArgs e)
        {

        }

        private void tbox_fisrtname_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_fisrtname.Text == "")
            {
                lbl_name_error.Text = "fill name please";
                tbox_fisrtname.Text = " first name";
            }
            else
            {
                if (!Regex.IsMatch(tbox_fisrtname.Text, @"^[A-Z][a-zA-Z]*$"))
                {
                    lbl_name_error.Text = "incorrect format";
                    lbl_name_error.Visible = true;
                }
                else
                    lbl_name_error.Visible = false;
            }
        }

        private void tbox_fisrtname_MouseEnter(object sender, EventArgs e)
        {

            if (tbox_fisrtname.Text == " first name")
                tbox_fisrtname.Text = "";
        }

        private void tbox_lastname_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_lastname.Text == " last name")
                tbox_lastname.Text = "";
        }

        private void tbox_lastname_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_lastname.Text == "")
            {
                lbl_lastname_error.Text = "fill last name please";
                tbox_lastname.Text = " last name";
            }
            else
            {
                if (!Regex.IsMatch(tbox_lastname.Text, @"^[A-Z][a-zA-Z]*$"))
                {
                    lbl_lastname_error.Text = "incorrect format";
                    lbl_lastname_error.Visible = true;
                }
                else
                    lbl_lastname_error.Visible = false;

            }
        }

        private void tbox_email_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_email.Text == " e-mail")
                tbox_email.Text = "";
        }

        private void tbox_email_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_email.Text == "")
            {
                lbl_gmail_error.Text = "fill name please";

                tbox_email.Text = " e-mail";
            }

            else
            {
                if (!Regex.IsMatch(tbox_email.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
                {
                    lbl_gmail_error.Text = "incorrect format";
                    lbl_gmail_error.Visible = true;
                }
                else
                    lbl_gmail_error.Visible = false;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (lbl_name_error.Visible == false && lbl_lastname_error.Visible == false && lbl_name_error.Visible == false)
            {
                User.users.Add(new User()
                {
                    FirstName = tbox_fisrtname.Text,
                    LastName = tbox_lastname.Text,
                    Email = tbox_email.Text,
                });

                Forms.register.Close();
                Forms.registrPassword = new();
                Forms.registrPassword.StartPosition = FormStartPosition.Manual;
                Forms.registrPassword.Location = this.Location;
                Forms.registrPassword.ShowDialog();
            }
        }

        private void lbl_gmail_error_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void tbox_email_SizeChanged(object sender, EventArgs e)
        {
        }

        private void tbox_email_TextChanged(object sender, EventArgs e)
        {
            if (tbox_email.Text.Length == 10 || tbox_email.Text.Length == 15 || tbox_email.Text.Length == 19)
                tbox_email.Font = new Font(tbox_email.Font.FontFamily.ToString(), (int)tbox_email.Font.Size - 2, tbox_email.Font.Style);

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.register.Dispose();
        }
    }
}
