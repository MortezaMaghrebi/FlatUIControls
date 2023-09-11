namespace FlatUIControls
{
    partial class FlatForm
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
            this.bMaximize = new System.Windows.Forms.Button();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.pBody = new System.Windows.Forms.Panel();
            this.flatSliderMenu1 = new FlatUIControls.FlatSliderMenu();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bMaximize
            // 
            this.bMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMaximize.BackColor = System.Drawing.Color.Transparent;
            this.bMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMaximize.FlatAppearance.BorderSize = 0;
            this.bMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.bMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.bMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bMaximize.ForeColor = System.Drawing.Color.White;
            this.bMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMaximize.Location = new System.Drawing.Point(561, 5);
            this.bMaximize.Name = "bMaximize";
            this.bMaximize.Padding = new System.Windows.Forms.Padding(1);
            this.bMaximize.Size = new System.Drawing.Size(33, 19);
            this.bMaximize.TabIndex = 3;
            this.bMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMaximize.UseCompatibleTextRendering = true;
            this.bMaximize.UseVisualStyleBackColor = false;
            this.bMaximize.Click += new System.EventHandler(this.bMaximize_Click);
            this.bMaximize.Paint += new System.Windows.Forms.PaintEventHandler(this.bMaximize_Paint);
            this.bMaximize.MouseEnter += new System.EventHandler(this.bMaximize_MouseEnter);
            this.bMaximize.MouseLeave += new System.EventHandler(this.bMaximize_MouseLeave);
            // 
            // bMinimize
            // 
            this.bMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMinimize.FlatAppearance.BorderSize = 0;
            this.bMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.bMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bMinimize.ForeColor = System.Drawing.Color.White;
            this.bMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMinimize.Location = new System.Drawing.Point(522, 5);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(33, 19);
            this.bMinimize.TabIndex = 2;
            this.bMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMinimize.UseCompatibleTextRendering = true;
            this.bMinimize.UseVisualStyleBackColor = false;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            this.bMinimize.Paint += new System.Windows.Forms.PaintEventHandler(this.bMinimize_Paint);
            this.bMinimize.MouseEnter += new System.EventHandler(this.bEMinimize_MouseEnter);
            this.bMinimize.MouseLeave += new System.EventHandler(this.bEMinimize_MouseLeave);
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExit.Location = new System.Drawing.Point(600, 5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(33, 19);
            this.bExit.TabIndex = 1;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExit.UseCompatibleTextRendering = true;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            this.bExit.Paint += new System.Windows.Forms.PaintEventHandler(this.bExit_Paint);
            this.bExit.MouseEnter += new System.EventHandler(this.bExit_MouseEnter);
            this.bExit.MouseLeave += new System.EventHandler(this.bExit_MouseLeave);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.pBody);
            this.pMain.Controls.Add(this.flatSliderMenu1);
            this.pMain.Location = new System.Drawing.Point(4, 28);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(638, 409);
            this.pMain.TabIndex = 5;
            // 
            // pBody
            // 
            this.pBody.BackColor = System.Drawing.Color.Transparent;
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(192, 0);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(446, 409);
            this.pBody.TabIndex = 6;
            this.pBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pBody_Paint);
            // 
            // flatSliderMenu1
            // 
            this.flatSliderMenu1.BackColor = System.Drawing.Color.Transparent;
            this.flatSliderMenu1.CaptionColor = System.Drawing.Color.White;
            this.flatSliderMenu1.DesiredWidth = 192;
            this.flatSliderMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatSliderMenu1.Location = new System.Drawing.Point(0, 0);
            this.flatSliderMenu1.LogoImage = null;
            this.flatSliderMenu1.LogoMarginTop = 1;
            this.flatSliderMenu1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.flatSliderMenu1.MenuItems = new FlatUIControls.FlatMenuItem[0];
            this.flatSliderMenu1.Name = "flatSliderMenu1";
            this.flatSliderMenu1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.flatSliderMenu1.ScrollValue = 0;
            this.flatSliderMenu1.Size = new System.Drawing.Size(192, 409);
            this.flatSliderMenu1.SmallLogoImage = null;
            this.flatSliderMenu1.TabIndex = 5;
            this.flatSliderMenu1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(646, 441);
            this.Controls.Add(this.bMaximize);
            this.Controls.Add(this.bMinimize);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlatForm";
            this.Padding = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FlatForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FlatForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlatForm_MouseDown);
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Button bMaximize;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pBody;
        public FlatSliderMenu flatSliderMenu1;
    }
}
