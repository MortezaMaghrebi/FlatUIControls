namespace FlatUIControls
{
    partial class FlatMenuItem
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
            this.FlatItemButton = new System.Windows.Forms.Button();
            this.child = new FlatUIControls.FlatMenu();
            this.SuspendLayout();
            // 
            // FlatItemButton
            // 
            this.FlatItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlatItemButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlatItemButton.FlatAppearance.BorderSize = 0;
            this.FlatItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.FlatItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.FlatItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FlatItemButton.ForeColor = System.Drawing.Color.White;
            this.FlatItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlatItemButton.Location = new System.Drawing.Point(0, 0);
            this.FlatItemButton.Name = "FlatItemButton";
            this.FlatItemButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.FlatItemButton.Size = new System.Drawing.Size(100, 40);
            this.FlatItemButton.TabIndex = 0;
            this.FlatItemButton.Text = "---Item-";
            this.FlatItemButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlatItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FlatItemButton.UseCompatibleTextRendering = true;
            this.FlatItemButton.UseVisualStyleBackColor = true;
            this.FlatItemButton.Click += new System.EventHandler(this.FlatItemButton_Click);
            // 
            // child
            // 
            this.child.AutoSize = true;
            this.child.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(239)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.child.Dock = System.Windows.Forms.DockStyle.Top;
            this.child.HasScrollbar = false;
            this.child.Items = new FlatUIControls.FlatMenuItem[0];
            this.child.Location = new System.Drawing.Point(0, 40);
            this.child.MinimumSize = new System.Drawing.Size(100, 10);
            this.child.Name = "child";
            this.child.ScrollValue = 0;
            this.child.Size = new System.Drawing.Size(100, 23);
            this.child.TabIndex = 1;
            // 
            // FlatMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.child);
            this.Controls.Add(this.FlatItemButton);
            this.MinimumSize = new System.Drawing.Size(100, 0);
            this.Name = "FlatMenuItem";
            this.Size = new System.Drawing.Size(100, 63);
            this.Load += new System.EventHandler(this.FlatMenuItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FlatItemButton;
        private FlatMenu child;
    }
}
