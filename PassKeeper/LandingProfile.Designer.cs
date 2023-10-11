namespace PassKeeper
{
    partial class LandingProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingProfile));
            lbl_logo = new Label();
            label1 = new Label();
            lbl_image = new Label();
            SuspendLayout();
            // 
            // lbl_logo
            // 
            lbl_logo.Image = Properties.Resources.Screenshot_2023_10_11_165852;
            lbl_logo.Location = new Point(57, 20);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(212, 41);
            lbl_logo.TabIndex = 2;
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
            // lbl_image
            // 
            lbl_image.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_image.Image = (Image)resources.GetObject("lbl_image.Image");
            lbl_image.Location = new Point(92, 61);
            lbl_image.Name = "lbl_image";
            lbl_image.Size = new Size(149, 126);
            lbl_image.TabIndex = 9;
            lbl_image.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LandingProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 653);
            Controls.Add(lbl_image);
            Controls.Add(label1);
            Controls.Add(lbl_logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LandingProfile";
            Text = "LandingProfile";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_logo;
        private Label label1;
        private Label lbl_image;
    }
}