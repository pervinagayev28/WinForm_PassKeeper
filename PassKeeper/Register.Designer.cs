namespace PassKeeper
{
    partial class Register
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
            label1 = new Label();
            tbox_fisrtname = new TextBox();
            tbox_lastname = new TextBox();
            tbox_email = new TextBox();
            btn_next = new Button();
            lbl_name_error = new Label();
            lbl_lastname_error = new Label();
            lbl_gmail_error = new Label();
            SuspendLayout();
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 23;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 624);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 24;
            label1.Text = "a product by Product Design LLC";
            // 
            // tbox_fisrtname
            // 
            tbox_fisrtname.BorderStyle = BorderStyle.None;
            tbox_fisrtname.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_fisrtname.ForeColor = SystemColors.InactiveCaption;
            tbox_fisrtname.Location = new Point(44, 259);
            tbox_fisrtname.Multiline = true;
            tbox_fisrtname.Name = "tbox_fisrtname";
            tbox_fisrtname.Size = new Size(260, 60);
            tbox_fisrtname.TabIndex = 25;
            tbox_fisrtname.Text = " first name";
            tbox_fisrtname.Click += tbox_fisrtname_Click;
            tbox_fisrtname.TextChanged += tbox_new_pass_TextChanged;
            tbox_fisrtname.MouseEnter += tbox_fisrtname_MouseEnter;
            tbox_fisrtname.MouseLeave += tbox_fisrtname_MouseLeave;
            // 
            // tbox_lastname
            // 
            tbox_lastname.BorderStyle = BorderStyle.None;
            tbox_lastname.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_lastname.ForeColor = SystemColors.InactiveCaption;
            tbox_lastname.Location = new Point(44, 340);
            tbox_lastname.Multiline = true;
            tbox_lastname.Name = "tbox_lastname";
            tbox_lastname.Size = new Size(260, 60);
            tbox_lastname.TabIndex = 26;
            tbox_lastname.Text = " last name";
            tbox_lastname.MouseEnter += tbox_lastname_MouseEnter;
            tbox_lastname.MouseLeave += tbox_lastname_MouseLeave;
            // 
            // tbox_email
            // 
            tbox_email.BorderStyle = BorderStyle.None;
            tbox_email.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_email.ForeColor = SystemColors.InactiveCaption;
            tbox_email.Location = new Point(44, 416);
            tbox_email.Multiline = true;
            tbox_email.Name = "tbox_email";
            tbox_email.Size = new Size(260, 60);
            tbox_email.TabIndex = 27;
            tbox_email.Text = " e-mail";
            tbox_email.SizeChanged += tbox_email_SizeChanged;
            tbox_email.TextChanged += tbox_email_TextChanged;
            tbox_email.MouseEnter += tbox_email_MouseEnter;
            tbox_email.MouseLeave += tbox_email_MouseLeave;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.FromArgb(32, 60, 133);
            btn_next.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.ForeColor = SystemColors.Window;
            btn_next.Location = new Point(44, 502);
            btn_next.Name = "btn_next";
            btn_next.RightToLeft = RightToLeft.No;
            btn_next.Size = new Size(260, 60);
            btn_next.TabIndex = 28;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // lbl_name_error
            // 
            lbl_name_error.BackColor = SystemColors.Control;
            lbl_name_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name_error.ForeColor = Color.Crimson;
            lbl_name_error.Location = new Point(54, 312);
            lbl_name_error.Name = "lbl_name_error";
            lbl_name_error.Size = new Size(250, 25);
            lbl_name_error.TabIndex = 29;
            lbl_name_error.Text = "fill name please";
            // 
            // lbl_lastname_error
            // 
            lbl_lastname_error.BackColor = SystemColors.Control;
            lbl_lastname_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_lastname_error.ForeColor = Color.Crimson;
            lbl_lastname_error.Location = new Point(54, 388);
            lbl_lastname_error.Name = "lbl_lastname_error";
            lbl_lastname_error.Size = new Size(250, 25);
            lbl_lastname_error.TabIndex = 30;
            lbl_lastname_error.Text = "fill last name please";
            // 
            // lbl_gmail_error
            // 
            lbl_gmail_error.BackColor = SystemColors.Control;
            lbl_gmail_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gmail_error.ForeColor = Color.Crimson;
            lbl_gmail_error.Location = new Point(54, 474);
            lbl_gmail_error.Name = "lbl_gmail_error";
            lbl_gmail_error.Size = new Size(250, 25);
            lbl_gmail_error.TabIndex = 31;
            lbl_gmail_error.Text = "fill gmail please";
            lbl_gmail_error.Click += lbl_gmail_error_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            Controls.Add(lbl_gmail_error);
            Controls.Add(lbl_lastname_error);
            Controls.Add(lbl_name_error);
            Controls.Add(btn_next);
            Controls.Add(tbox_email);
            Controls.Add(tbox_lastname);
            Controls.Add(tbox_fisrtname);
            Controls.Add(label1);
            Controls.Add(lbl_logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            Text = "Register";
            FormClosing += Register_FormClosing;
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_logo;
        private Label label1;
        private TextBox tbox_fisrtname;
        private TextBox tbox_lastname;
        private TextBox tbox_email;
        private Button btn_next;
        private Label lbl_name_error;
        private Label lbl_lastname_error;
        private Label lbl_gmail_error;
    }
}