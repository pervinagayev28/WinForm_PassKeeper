namespace PassKeeper
{
    partial class ForgetPasswordSendCode
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
            tbox_resend_code_gmail = new TextBox();
            btn_sign_in = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 2;
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
            tbox_resend_code_gmail.TabIndex = 5;
            tbox_resend_code_gmail.Text = " e-mail";
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
            btn_sign_in.TabIndex = 7;
            btn_sign_in.Text = "Send code";
            btn_sign_in.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 624);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 8;
            label1.Text = "a product by Product Design LLC";
            // 
            // ForgetPasswordSendCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btn_sign_in);
            Controls.Add(tbox_resend_code_gmail);
            Controls.Add(lbl_logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ForgetPasswordSendCode";
            Text = "Forget pass Send code";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_logo;
        private TextBox tbox_resend_code_gmail;
        private Button btn_sign_in;
        private Label label1;
    }
}