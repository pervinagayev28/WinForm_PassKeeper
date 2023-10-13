namespace PassKeeper
{
    partial class form_sign_in
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_logo = new Label();
            tbox_log_in = new TextBox();
            tbox_password = new TextBox();
            btn_sign_in = new Button();
            label1 = new Label();
            lbl_forgotpassword = new Label();
            lbl_not_found_account = new Label();
            SuspendLayout();
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 1;
            // 
            // tbox_log_in
            // 
            tbox_log_in.BorderStyle = BorderStyle.None;
            tbox_log_in.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_log_in.ForeColor = SystemColors.InactiveCaption;
            tbox_log_in.HideSelection = false;
            tbox_log_in.Location = new Point(44, 261);
            tbox_log_in.Margin = new Padding(4);
            tbox_log_in.Multiline = true;
            tbox_log_in.Name = "tbox_log_in";
            tbox_log_in.ShortcutsEnabled = false;
            tbox_log_in.Size = new Size(260, 60);
            tbox_log_in.TabIndex = 4;
            tbox_log_in.Text = " log in";
            tbox_log_in.Click += tbox_log_in_Click;
            tbox_log_in.TextChanged += tbox_log_in_TextChanged;
            tbox_log_in.MouseLeave += tbox_log_in_MouseLeave;
            // 
            // tbox_password
            // 
            tbox_password.BorderStyle = BorderStyle.None;
            tbox_password.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_password.ForeColor = SystemColors.InactiveCaption;
            tbox_password.Location = new Point(44, 338);
            tbox_password.Multiline = true;
            tbox_password.Name = "tbox_password";
            tbox_password.ShortcutsEnabled = false;
            tbox_password.Size = new Size(260, 60);
            tbox_password.TabIndex = 5;
            tbox_password.Text = " password";
            tbox_password.Click += tbox_password_Click;
            tbox_password.TextChanged += tbox_password_TextChanged;
            tbox_password.MouseLeave += tbox_password_MouseLeave;
            tbox_password.ChangeUICues += tbox_password_ChangeUICues;
            // 
            // btn_sign_in
            // 
            btn_sign_in.BackColor = Color.FromArgb(32, 60, 133);
            btn_sign_in.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sign_in.ForeColor = SystemColors.Window;
            btn_sign_in.Location = new Point(44, 421);
            btn_sign_in.Name = "btn_sign_in";
            btn_sign_in.RightToLeft = RightToLeft.No;
            btn_sign_in.Size = new Size(260, 60);
            btn_sign_in.TabIndex = 6;
            btn_sign_in.Text = "Sign in";
            btn_sign_in.UseVisualStyleBackColor = false;
            btn_sign_in.Click += btn_sign_in_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 624);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 7;
            label1.Text = "a product by Product Design LLC";
            // 
            // lbl_forgotpassword
            // 
            lbl_forgotpassword.Font = new Font("Arial", 7.8F, FontStyle.Underline, GraphicsUnit.Point);
            lbl_forgotpassword.Location = new Point(89, 484);
            lbl_forgotpassword.Name = "lbl_forgotpassword";
            lbl_forgotpassword.Size = new Size(166, 22);
            lbl_forgotpassword.TabIndex = 8;
            lbl_forgotpassword.Text = "Forgot password? renew it!";
            lbl_forgotpassword.Click += lbl_forgotpassword_Click;
            lbl_forgotpassword.MouseEnter += lbl_forgotpassword_MouseEnter;
            lbl_forgotpassword.MouseLeave += lbl_forgotpassword_MouseLeave;
            // 
            // lbl_not_found_account
            // 
            lbl_not_found_account.BackColor = SystemColors.Control;
            lbl_not_found_account.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_not_found_account.ForeColor = Color.Crimson;
            lbl_not_found_account.Location = new Point(89, 401);
            lbl_not_found_account.Name = "lbl_not_found_account";
            lbl_not_found_account.Size = new Size(140, 25);
            lbl_not_found_account.TabIndex = 33;
            lbl_not_found_account.Text = "not found account";
            lbl_not_found_account.Visible = false;
            // 
            // form_sign_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(357, 653);
            Controls.Add(lbl_not_found_account);
            Controls.Add(lbl_forgotpassword);
            Controls.Add(label1);
            Controls.Add(btn_sign_in);
            Controls.Add(tbox_password);
            Controls.Add(tbox_log_in);
            Controls.Add(lbl_logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_sign_in";
            Text = "Sig in";
            FormClosing += form_sign_in_FormClosing;
            Load += form_sign_in_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbl_logo;
        public TextBox tbox_log_in;
        public TextBox tbox_password;
        public Button btn_sign_in;
        public Label label1;
        public Label lbl_forgotpassword;
        private Label lbl_not_found_account;
    }
}