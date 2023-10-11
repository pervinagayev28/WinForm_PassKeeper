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
            textBox1 = new TextBox();
            btn_update_pass = new Button();
            lbl_logo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbox_new_pass
            // 
            tbox_new_pass.BorderStyle = BorderStyle.None;
            tbox_new_pass.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_new_pass.ForeColor = SystemColors.InactiveCaption;
            tbox_new_pass.Location = new Point(44, 261);
            tbox_new_pass.Multiline = true;
            tbox_new_pass.Name = "tbox_new_pass";
            tbox_new_pass.Size = new Size(260, 60);
            tbox_new_pass.TabIndex = 16;
            tbox_new_pass.Text = " new pass";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(44, 338);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 60);
            textBox1.TabIndex = 17;
            textBox1.Text = " confirm pass";
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
            // CreatNewPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(lbl_logo);
            Controls.Add(btn_update_pass);
            Controls.Add(textBox1);
            Controls.Add(tbox_new_pass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreatNewPass";
            Text = "Creat New Pass";
            Load += CreatNewPass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbox_new_pass;
        private TextBox textBox1;
        private Button btn_update_pass;
        private Label lbl_logo;
        private Label label1;
    }
}