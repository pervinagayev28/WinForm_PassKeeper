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
    public partial class CreatNewPass : Form
    {
        public CreatNewPass()
        {

            InitializeComponent();


        }

        private void CreatNewPass_Load(object sender, EventArgs e)
        {
        }

        private void tbox_new_pass_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_new_pass.Text == " password")
                tbox_new_pass.Text = "";
        }

        private void tbox_new_pass_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_new_pass.Text == "")
            {
                lbl_password_error.Visible = false;
                tbox_new_pass.Text = " new pass";
            }
            else if (!Regex.IsMatch(tbox_new_pass.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$"))
            {
                lbl_password_error.Visible = true;
            }
            else
            {
                lbl_password_error.Visible = false;
            }

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_confirmpass.Text == "")
            {
                tbox_confirmpass.Text = " confirm pass";
                lbl_confirm_pass.Visible = false;
            }
        }

        private void tbox_confirmpass_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_confirmpass.Text != tbox_new_pass.Text && tbox_new_pass.Text != " new pass")
                lbl_confirm_pass.Visible = true;
            else
                lbl_confirm_pass.Visible = false;
        }

        private void btn_update_pass_Click(object sender, EventArgs e)
        {
            if (lbl_confirm_pass.Visible == false && lbl_password_error.Visible == false)
            {
                foreach (var item in User.users)
                {
                    if (item.Email == ForgetPasswordSendCode.gmail)
                    {
                        item.Password = tbox_confirmpass.Text;
                        File.WriteAllText("users.json", JsonSerializer.Serialize(User.users, new JsonSerializerOptions() { WriteIndented = true }));
                        Forms.CreatNewPass.Close();
                    
                    }
                }
            }
        }

        private void tbox_new_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatNewPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.CreatNewPass.Dispose();

        }
    }
}
