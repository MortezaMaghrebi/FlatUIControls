namespace FlatUIControls
{
    partial class FlatSliderMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlatSliderMenu));
            this.pHamberger = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pProfile = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatMenu1 = new FlatUIControls.FlatMenu();
            this.pHamberger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHamberger
            // 
            this.pHamberger.BackColor = System.Drawing.Color.Transparent;
            this.pHamberger.Controls.Add(this.pictureBox1);
            this.pHamberger.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHamberger.Location = new System.Drawing.Point(0, 0);
            this.pHamberger.Name = "pHamberger";
            this.pHamberger.Size = new System.Drawing.Size(191, 35);
            this.pHamberger.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pProfile
            // 
            this.pProfile.BackColor = System.Drawing.Color.Transparent;
            this.pProfile.Controls.Add(this.pLogo);
            this.pProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pProfile.Location = new System.Drawing.Point(0, 35);
            this.pProfile.Name = "pProfile";
            this.pProfile.Padding = new System.Windows.Forms.Padding(5);
            this.pProfile.Size = new System.Drawing.Size(191, 82);
            this.pProfile.TabIndex = 3;
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.Transparent;
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(22, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Padding = new System.Windows.Forms.Padding(3);
            this.pLogo.Size = new System.Drawing.Size(150, 80);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogo.TabIndex = 0;
            this.pLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flatMenu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 431);
            this.panel1.TabIndex = 4;
            // 
            // flatMenu1
            // 
            this.flatMenu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flatMenu1.BackColor = System.Drawing.Color.Transparent;
            this.flatMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatMenu1.HasScrollbar = false;
            this.flatMenu1.Items = new FlatUIControls.FlatMenuItem[0];
            this.flatMenu1.Location = new System.Drawing.Point(0, 0);
            this.flatMenu1.MinimumSize = new System.Drawing.Size(100, 100);
            this.flatMenu1.Name = "flatMenu1";
            this.flatMenu1.ScrollValue = 0;
            this.flatMenu1.Size = new System.Drawing.Size(191, 431);
            this.flatMenu1.TabIndex = 6;
            this.flatMenu1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            // 
            // FlatSliderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pProfile);
            this.Controls.Add(this.pHamberger);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.Name = "FlatSliderMenu";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.Size = new System.Drawing.Size(192, 548);
            this.Load += new System.EventHandler(this.FlatSliderMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FlatSliderMenu_Paint);
            this.Resize += new System.EventHandler(this.FlatSliderMenu_Resize);
            this.pHamberger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.Panel pHamberger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pProfile;
        private System.Windows.Forms.Panel panel1;
        private FlatMenu flatMenu1;
    }
}
