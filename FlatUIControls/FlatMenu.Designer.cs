namespace FlatUIControls
{
    partial class FlatMenu
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
            this.pPanelContainer = new System.Windows.Forms.Panel();
            this.pItemContainer = new System.Windows.Forms.Panel();
            this.pPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPanelContainer
            // 
            this.pPanelContainer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pPanelContainer.Controls.Add(this.pItemContainer);
            this.pPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.pPanelContainer.MinimumSize = new System.Drawing.Size(20, 20);
            this.pPanelContainer.Name = "pPanelContainer";
            this.pPanelContainer.Size = new System.Drawing.Size(80, 100);
            this.pPanelContainer.TabIndex = 1;
            this.pPanelContainer.Resize += new System.EventHandler(this.pPanelContainer_Resize);
            // 
            // pItemContainer
            // 
            this.pItemContainer.AutoSize = true;
            this.pItemContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pItemContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pItemContainer.Location = new System.Drawing.Point(0, 0);
            this.pItemContainer.Name = "pItemContainer";
            this.pItemContainer.Size = new System.Drawing.Size(80, 0);
            this.pItemContainer.TabIndex = 1;
            this.pItemContainer.Resize += new System.EventHandler(this.pItemContainer_resize);
            // 
            // FlatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pPanelContainer);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "FlatMenu";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.FlatMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FlatMenu_Paint);
            this.Resize += new System.EventHandler(this.FlatMenu_Resize);
            this.pPanelContainer.ResumeLayout(false);
            this.pPanelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pPanelContainer;
        public System.Windows.Forms.Panel pItemContainer;
    }
}
