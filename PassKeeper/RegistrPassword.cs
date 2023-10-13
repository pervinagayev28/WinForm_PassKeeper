using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class RegistrPassword : Form
    {
        public RegistrPassword()
        {
            InitializeComponent();
        }

        private void tbox_password_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_password.Text == " password")
                tbox_password.Text = "";
        }

        private void tbox_password_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_password.Text == "")
            {
                lbl_password_error.Visible = false;
                tbox_password.Text = " password";
            }
            else
            {
                if (!Regex.IsMatch(tbox_password.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$"))
                    lbl_password_error.Visible = true;
                else
                    lbl_password_error.Visible = false;

            }
        }

        private void tbox_confirm_oass_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_confirm_oass.Text == " confirm pass")
                tbox_confirm_oass.Text = "";
        }

        private void tbox_confirm_oass_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_confirm_oass.Text == "")
            {
                lbl_password_error.Text = "the pass isn't strongly";
                tbox_confirm_oass.Text = " confirm pass";
            }
            else if (tbox_password.Text != "")
            {
                if (tbox_confirm_oass.Text != tbox_password.Text)
                {
                    lbl_password_error.Text = "the pass isn't strongly";
                    lbl_password_error2.Visible = true;
                }
                else
                    lbl_password_error2.Visible = false;

            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (lbl_password_error.Visible == false && lbl_password_error2.Visible == false)
            {

                User.users[User.users.Count - 1].Password = tbox_password.Text;
                File.WriteAllText("users.json", JsonSerializer.Serialize(User.users, new JsonSerializerOptions() { WriteIndented = true }));
                Forms.registrPassword.Close();
                Forms.CreatNewPassSuccsessed = new();
                Forms.CreatNewPassSuccsessed.StartPosition = FormStartPosition.Manual;
                Forms.CreatNewPassSuccsessed.Location = this.Location;
                Forms.CreatNewPassSuccsessed.ShowDialog();
            }
        }

        private void RegistrPassword_Load(object sender, EventArgs e)
        {

        }

        private void lbl_password_error_Click(object sender, EventArgs e)
        {

        }

        private void RegistrPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.registrPassword.Dispose();
        }
    }
}
