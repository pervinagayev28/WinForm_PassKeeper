namespace PassKeeper
{
    partial class CreatNewPass
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
            tbox_new_pass = new TextBox();
            tbox_confirmpass = new TextBox();
            btn_update_pass = new Button();
            lbl_logo = new Label();
            label1 = new Label();
            lbl_password_error = new Label();
            lbl_confirm_pass = new Label();
            SuspendLayout();
            // 
            // tbox_new_pass
            // 
            tbox_new_pass.BorderStyle = BorderStyle.None;
            tbox_new_pass.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_new_pass.ForeColor = SystemColors.InactiveCaption;
            tbox_new_pass.Location = new Point(43, 251);
            tbox_new_pass.Multiline = true;
            tbox_new_pass.Name = "tbox_new_pass";
            tbox_new_pass.Size = new Size(260, 60);
            tbox_new_pass.TabIndex = 16;
            tbox_new_pass.Text = " new pass";
            tbox_new_pass.TextChanged += tbox_new_pass_TextChanged;
            tbox_new_pass.MouseEnter += tbox_new_pass_MouseEnter;
            tbox_new_pass.MouseLeave += tbox_new_pass_MouseLeave;
            // 
            // tbox_confirmpass
            // 
            tbox_confirmpass.BorderStyle = BorderStyle.None;
            tbox_confirmpass.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_confirmpass.ForeColor = SystemColors.InactiveCaption;
            tbox_confirmpass.Location = new Point(44, 338);
            tbox_confirmpass.Multiline = true;
            tbox_confirmpass.Name = "tbox_confirmpass";
            tbox_confirmpass.Size = new Size(260, 60);
            tbox_confirmpass.TabIndex = 17;
            tbox_confirmpass.Text = " confirm pass";
            tbox_confirmpass.MouseEnter += textBox1_MouseEnter;
            tbox_confirmpass.MouseLeave += tbox_confirmpass_MouseLeave;
            // 
            // btn_update_pass
            // 
            btn_update_pass.BackColor = Color.FromArgb(32, 60, 133);
            btn_update_pass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_pass.ForeColor = SystemColors.Window;
            btn_update_pass.Location = new Point(44, 421);
            btn_update_pass.Name = "btn_update_pass";
            btn_update_pass.RightToLeft = RightToLeft.No;
            btn_update_pass.Size = new Size(260, 60);
            btn_update_pass.TabIndex = 18;
            btn_update_pass.Text = "Update password";
            btn_update_pass.UseVisualStyleBackColor = false;
            btn_update_pass.Click += btn_update_pass_Click;
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 19;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 624);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 20;
            label1.Text = "a product by Product Design LLC";
            // 
            // lbl_password_error
            // 
            lbl_password_error.BackColor = SystemColors.Control;
            lbl_password_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password_error.ForeColor = Color.Crimson;
            lbl_password_error.Location = new Point(54, 324);
            lbl_password_error.Name = "lbl_password_error";
            lbl_password_error.Size = new Size(250, 25);
            lbl_password_error.TabIndex = 32;
            lbl_password_error.Text = "this password isn't strongly";
            lbl_password_error.Visible = false;
            // 
            // lbl_confirm_pass
            // 
            lbl_confirm_pass.BackColor = SystemColors.Control;
            lbl_confirm_pass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirm_pass.ForeColor = Color.Crimson;
            lbl_confirm_pass.Location = new Point(53, 393);
            lbl_confirm_pass.Name = "lbl_confirm_pass";
            lbl_confirm_pass.Size = new Size(250, 25);
            lbl_confirm_pass.TabIndex = 33;
            lbl_confirm_pass.Text = "this password doesn't suit another";
            lbl_confirm_pass.Visible = false;
            // 
            // CreatNewPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            Controls.Add(lbl_confirm_pass);
            Controls.Add(lbl_password_error);
            Controls.Add(label1);
            Controls.Add(lbl_logo);
            Controls.Add(btn_update_pass);
            Controls.Add(tbox_confirmpass);
            Controls.Add(tbox_new_pass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreatNewPass";
            Text = "Creat New Pass";
            FormClosing += CreatNewPass_FormClosing;
            Load += CreatNewPass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbox_new_pass;
        private TextBox tbox_confirmpass;
        private Button btn_update_pass;
        private Label lbl_logo;
        private Label label1;
        private Label lbl_password_error;
        private Label lbl_confirm_pass;
    }
}