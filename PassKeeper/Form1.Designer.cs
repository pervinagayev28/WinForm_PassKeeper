namespace PassKeeper
{
    partial class form_home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_logo = new Label();
            btn_sign_in = new Button();
            btn_register = new Button();
            lbl_by_product = new Label();
            SuspendLayout();
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 0;
            // 
            // btn_sign_in
            // 
            btn_sign_in.BackColor = Color.FromArgb(32, 60, 133);
            btn_sign_in.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sign_in.ForeColor = SystemColors.Window;
            btn_sign_in.Location = new Point(87, 261);
            btn_sign_in.Name = "btn_sign_in";
            btn_sign_in.RightToLeft = RightToLeft.No;
            btn_sign_in.Size = new Size(163, 54);
            btn_sign_in.TabIndex = 1;
            btn_sign_in.Text = "Sign in";
            btn_sign_in.UseVisualStyleBackColor = false;
            btn_sign_in.Click += btn_sign_in_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(32, 60, 133);
            btn_register.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register.ForeColor = SystemColors.Window;
            btn_register.Location = new Point(87, 341);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(163, 54);
            btn_register.TabIndex = 2;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // lbl_by_product
            // 
            lbl_by_product.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_by_product.Location = new Point(69, 624);
            lbl_by_product.Name = "lbl_by_product";
            lbl_by_product.Size = new Size(300, 20);
            lbl_by_product.TabIndex = 3;
            lbl_by_product.Text = "a product by Product Design LLC";
            // 
            // form_home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(357, 653);
            Controls.Add(lbl_by_product);
            Controls.Add(btn_register);
            Controls.Add(btn_sign_in);
            Controls.Add(lbl_logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_home";
            Text = "Home";
            FormClosing += form_home_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_logo;
        private Button btn_sign_in;
        private Button btn_register;
        private Label lbl_by_product;
    }
}