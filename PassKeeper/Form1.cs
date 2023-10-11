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
            this.Location = new Point(199, 100);
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            form_sign_in formSignIn = new();
            formSignIn.StartPosition = FormStartPosition.Manual;
            formSignIn.Location = this.Location;
            formSignIn.ShowDialog();
        }
    }
}