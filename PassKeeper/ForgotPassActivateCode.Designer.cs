﻿namespace PassKeeper
{
    partial class ForgotPassActivateCode
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
            label1 = new Label();
            lbl_logo = new Label();
            tbox_resend_code_gmail = new TextBox();
            btn_sign_in = new Button();
            lbl_verifycode_error = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 624);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 9;
            label1.Text = "a product by Product Design LLC";
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 10;
            lbl_logo.Click += lbl_logo_Click;
            // 
            // tbox_resend_code_gmail
            // 
            tbox_resend_code_gmail.BorderStyle = BorderStyle.None;
            tbox_resend_code_gmail.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_resend_code_gmail.ForeColor = SystemColors.InactiveCaption;
            tbox_resend_code_gmail.Location = new Point(44, 261);
            tbox_resend_code_gmail.Multiline = true;
            tbox_resend_code_gmail.Name = "tbox_resend_code_gmail";
            tbox_resend_code_gmail.Size = new Size(260, 60);
            tbox_resend_code_gmail.TabIndex = 11;
            tbox_resend_code_gmail.Text = " code";
            tbox_resend_code_gmail.MouseEnter += tbox_resend_code_gmail_MouseEnter;
            tbox_resend_code_gmail.MouseLeave += tbox_resend_code_gmail_MouseLeave;
            // 
            // btn_sign_in
            // 
            btn_sign_in.BackColor = Color.FromArgb(32, 60, 133);
            btn_sign_in.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sign_in.ForeColor = SystemColors.Window;
            btn_sign_in.Location = new Point(44, 351);
            btn_sign_in.Name = "btn_sign_in";
            btn_sign_in.RightToLeft = RightToLeft.No;
            btn_sign_in.Size = new Size(260, 60);
            btn_sign_in.TabIndex = 12;
            btn_sign_in.Text = "Submit";
            btn_sign_in.UseVisualStyleBackColor = false;
            btn_sign_in.Click += btn_sign_in_Click;
            // 
            // lbl_verifycode_error
            // 
            lbl_verifycode_error.BackColor = SystemColors.Control;
            lbl_verifycode_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_verifycode_error.ForeColor = Color.Crimson;
            lbl_verifycode_error.Location = new Point(54, 323);
            lbl_verifycode_error.Name = "lbl_verifycode_error";
            lbl_verifycode_error.Size = new Size(250, 25);
            lbl_verifycode_error.TabIndex = 31;
            lbl_verifycode_error.Text = "incorrect verify code";
            lbl_verifycode_error.Visible = false;
            // 
            // ForgotPassActivateCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            Controls.Add(lbl_verifycode_error);
            Controls.Add(btn_sign_in);
            Controls.Add(tbox_resend_code_gmail);
            Controls.Add(lbl_logo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ForgotPassActivateCode";
            Text = "Forgot Pass Activate Code";
            FormClosing += ForgotPassActivateCode_FormClosing;
            Load += ForgotPassActivateCode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_logo;
        public TextBox tbox_resend_code_gmail;
        private Button btn_sign_in;
        private Label lbl_verifycode_error;
    }
}