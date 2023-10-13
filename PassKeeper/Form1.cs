using System.Text.Json;

namespace PassKeeper
{
    public partial class form_home : Form
    {
        public form_home()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("users.json"))
            {
                var file = File.ReadAllText("users.json");
                User.users = JsonSerializer.Deserialize<List<User>>(file);
            }
            this.Location = new Point(199, 100);
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            Forms.FSignIn = new();
            Forms.FSignIn.StartPosition = FormStartPosition.Manual;
            Forms.FSignIn.Location = this.Location;
            Forms.FSignIn.ShowDialog();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Forms.register = new();
            Forms.register.StartPosition = FormStartPosition.Manual;
            Forms.register.Location = this.Location;
            Forms.register.ShowDialog();
        }

        private void form_home_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}