using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassKeeper
{
    public partial class LandingProfile : Form
    {
        public LandingProfile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Region = new System.Drawing.Region(path);
            }
        }

        private void LandingProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.landingProfile.Dispose();
          
        }

        private void LandingProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void LandingProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbox_first_name.Text, @"^[A-Z][a-zA-Z]*$"))
                lbl_firstname_error.Visible = true;
            else
            {
                lbl_firstname_error.Visible = false;
                foreach (var item in User.users)
                {
                    if (item.Email == tbox_gmail.Text)
                    {
                        item.FirstName = tbox_first_name.Text;
                        File.WriteAllText("users.json", JsonSerializer.Serialize(User.users, new JsonSerializerOptions() { WriteIndented = true }));

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbox_last_name.Text, @"^[A-Z][a-zA-Z]*$"))
                lbl_lastname_error.Visible = true;
            else
            {
                lbl_lastname_error.Visible = false;
                foreach (var item in User.users)
                {
                    if (item.Email == tbox_gmail.Text)
                    {
                        item.LastName = tbox_last_name.Text;
                        File.WriteAllText("users.json", JsonSerializer.Serialize(User.users, new JsonSerializerOptions() { WriteIndented = true }));

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbox_password.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$"))
                lbl_password_error.Visible = true;
            else
            {
                lbl_password_error.Visible = false;
                foreach (var item in User.users)
                {
                    if (item.Email == tbox_gmail.Text)
                    {
                        item.Password = tbox_password.Text;
                        File.WriteAllText("users.json", JsonSerializer.Serialize(User.users, new JsonSerializerOptions() { WriteIndented = true }));

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbox_gmail.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
                lbl_gmail_error.Visible = true;
            else
            {
                lbl_gmail_error.Visible = false;
                foreach (var item in User.users)
                {
                    if (item.Password == tbox_password.Text)
                    {
                        item.Email = tbox_gmail.Text;
                        File.WriteAllText("users.json", JsonSerializer.Serialize(User.users, new JsonSerializerOptions() { WriteIndented = true }));

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "(*.jpg;*.png)|*.jpg;*.png|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool check = false;
                string path = openFileDialog1.FileName;
                try
                {
                    pictureBox1.Image = new Bitmap(path);
                    check = true;
                    lbl_image_error.Visible = false;
                }
                catch (Exception)
                {
                    lbl_image_error.Visible = true;
                }
                if (check)
                {

                    foreach (var item in User.users)
                    {
                        if (item.Email == tbox_gmail.Text)
                            item.ImagePath = path;
                    }
                    File.WriteAllText("users.json", JsonSerializer.Serialize(User.users, new JsonSerializerOptions() { WriteIndented = true }));
                }
            }
        }
    }
}
