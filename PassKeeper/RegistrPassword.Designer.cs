namespace PassKeeper
{
    partial class RegistrPassword
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
            tbox_confirm_oass = new TextBox();
            tbox_password = new TextBox();
            btn_confirm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 24;
            // 
            // tbox_confirm_oass
            // 
            tbox_confirm_oass.BorderStyle = BorderStyle.None;
            tbox_confirm_oass.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_confirm_oass.ForeColor = SystemColors.InactiveCaption;
            tbox_confirm_oass.Location = new Point(44, 340);
            tbox_confirm_oass.Multiline = true;
            tbox_confirm_oass.Name = "tbox_confirm_oass";
            tbox_confirm_oass.Size = new Size(260, 60);
            tbox_confirm_oass.TabIndex = 26;
            tbox_confirm_oass.Text = " confirm pass";
            // 
            // tbox_password
            // 
            tbox_password.BorderStyle = BorderStyle.None;
            tbox_password.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_password.ForeColor = SystemColors.InactiveCaption;
            tbox_password.Location = new Point(44, 261);
            tbox_password.Multiline = true;
            tbox_password.Name = "tbox_password";
            tbox_password.Size = new Size(260, 60);
            tbox_password.TabIndex = 27;
            tbox_password.Text = " password";
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.FromArgb(32, 60, 133);
            btn_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirm.ForeColor = SystemColors.Window;
            btn_confirm.Location = new Point(44, 421);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.RightToLeft = RightToLeft.No;
            btn_confirm.Size = new Size(260, 60);
            btn_confirm.TabIndex = 29;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 624);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 30;
            label1.Text = "a product by Product Design LLC";
            // 
            // RegistrPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btn_confirm);
            Controls.Add(tbox_password);
            Controls.Add(tbox_confirm_oass);
            Controls.Add(lbl_logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrPassword";
            Text = "Registr Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_logo;
        private TextBox tbox_confirm_oass;
        private TextBox tbox_password;
        private Button btn_confirm;
        private Label label1;
    }
}