using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlatUIControls
{
    public partial class FlatToolTip : Form
    {
        public FlatToolTip()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
        }

        public string TooltipText
        {
            get { return lToolTip.Text; }
            set { lToolTip.Text = value; }
        }

        public Color TooltipBackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color TooltipTextColor
        {
            get { return lToolTip.ForeColor; }
            set { lToolTip.ForeColor = value; }
        }

        
        public int TooltipShowDuration
        {
            get { return timer1.Interval; }
            set { timer1.Interval= value; }
        }
        bool isshown=false;
        public void ShowTooltip(Point Location)
        {
            if (!isshown)
            {
                isshown=true;
                this.Opacity = 50;
                this.TopMost = true;
                this.Visible = true;
                this.Show();
                this.Location = Location;
                timer1.Start();
            }

        }

        public void HideTooltip()
        {
            this.Hide();
            isshown = false;
            timer1.Stop();
        }

        private void lToolTip_Resize(object sender, EventArgs e)
        {
            this.Size = lToolTip.Size;
        }

        private void lToolTip_Paint(object sender, PaintEventArgs e)
        {
            //if(this.Size != lToolTip.Size) this.Size = lToolTip.Size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            HideTooltip();
        }

        private void FlatToolTip_Load(object sender, EventArgs e)
        {
            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile("Nunito-Regular.ttf");
            Font customFont = new Font(modernFont.Families[0], 10.5F, FontStyle.Regular);
            lToolTip.Font = customFont;
        }
    }
}
