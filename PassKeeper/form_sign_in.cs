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
    }
}
