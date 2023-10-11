namespace PassKeeper
{
    partial class CreatNewPassSuccsessed
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
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 624);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 21;
            label1.Text = "a product by Product Design LLC";
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(69, 127);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 22;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(50, 143, 76);
            label2.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(48, 176);
            label2.Name = "label2";
            label2.Size = new Size(260, 189);
            label2.TabIndex = 23;
            label2.Text = "Registration is succsesfully done";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 143, 76);
            button1.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(37, 380);
            button1.Name = "button1";
            button1.Size = new Size(281, 78);
            button1.TabIndex = 24;
            button1.Text = "Go to sign in page";
            button1.UseVisualStyleBackColor = false;
            // 
            // CreatNewPassSuccsessed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lbl_logo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreatNewPassSuccsessed";
            Text = "Creat New Pass Succsessed";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl_logo;
        private Label label2;
        private Button button1;
    }
}