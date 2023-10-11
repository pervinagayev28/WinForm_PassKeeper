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
            tbox_fisrtname.Location = new Point(44, 261);
            tbox_fisrtname.Multiline = true;
            tbox_fisrtname.Name = "tbox_fisrtname";
            tbox_fisrtname.Size = new Size(260, 60);
            tbox_fisrtname.TabIndex = 25;
            tbox_fisrtname.Text = " first name";
            tbox_fisrtname.TextChanged += tbox_new_pass_TextChanged;
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
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            ControlBox = false;
            Controls.Add(btn_next);
            Controls.Add(tbox_email);
            Controls.Add(tbox_lastname);
            Controls.Add(tbox_fisrtname);
            Controls.Add(label1);
            Controls.Add(lbl_logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            Text = "Register";
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
    }
}