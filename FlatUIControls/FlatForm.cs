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
    public partial class FlatForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        ///[System.Runtime.InteropServices.DllImport("user32.dll")]
        ///public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        ///[System.Runtime.InteropServices.DllImport("user32.dll")]
        ///public static extern bool ReleaseCapture();

        public FlatForm()
        {
            InitializeComponent();
            bExit.Left = this.Width - bExit.Width;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
           
        }
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {  // Trap WM_NCHITTEST
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;  // HTCAPTION
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17; // HTBOTTOMRIGHT
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}

        private void FlatForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(ThemeColor), new RectangleF(1, 1, this.Width-2, 4));
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(90,200,200,200)), 0,0,this.Width-1,this.Height-1);

            if(bExit.Left != this.Width - bExit.Width-1)
            {
                bExit.Left = this.Width - bExit.Width-1;
                bMaximize.Left =  bExit.Left - bMaximize.Width;
                bMinimize.Left = bMaximize.Left - bMinimize.Width;
            }

            e.Graphics.FillPolygon(new SolidBrush(Color.Gray), new Point[] { new Point(this.Width - 9, this.Height - 1), new Point(this.Width - 1, this.Height - 9), new Point(this.Width - 1, this.Height- 1) });
            if (pMain.Left!=1)pMain.Left = 1;
            if(pMain.Top!= 5 + bExit.Height) pMain.Top = 5 + bExit.Height;
            if(pMain.Width!=Width-2)pMain.Width = Width-2;
            if(pMain.Height!=Height-6-bExit.Height)pMain.Height = Height-6-bExit.Height;


        }

        public Color _ThemeColor= Color.FromArgb(239, 41, 84);
        public Color ThemeColor
        {
            get
            {
                return _ThemeColor;
            }
            set { _ThemeColor = value;
                bExit.FlatAppearance.MouseDownBackColor = _ThemeColor;
                bExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, _ThemeColor);
                bMaximize.FlatAppearance.MouseDownBackColor = _ThemeColor;
                bMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, _ThemeColor);
                bMinimize.FlatAppearance.MouseDownBackColor = _ThemeColor;
                bMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, _ThemeColor);
            }

        }

        private void FlatForm_Load(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Application.ExitThread();
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void bMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }else this.WindowState = FormWindowState.Maximized;
        }

        private void FlatForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               // ReleaseCapture();
               // SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        Pen bExitPen;
        Point[] bExitPoints = null;
        bool bExitMouseOver = false;

        private void bExit_Paint(object sender, PaintEventArgs e)
        {
            int Height = ((Button)sender).Height;
            int Width= ((Button)sender).Width;
            if(bExitPoints == null)
            {
                bExitPoints = new Point[4];
                bExitPoints[0] = new Point(Width / 2 - 4, Height / 2 - 4);
                bExitPoints[1] = new Point(Width / 2 + 4, Height / 2 + 4);
                bExitPoints[2] = new Point(Width / 2 - 4, Height / 2 + 4);
                bExitPoints[3] = new Point(Width / 2 + 4, Height / 2 - 4);
            }
            if (bExitMouseOver)
            {
                bExitPen = new Pen(Color.White);
            }
            else bExitPen = new Pen(ThemeColor);
            e.Graphics.DrawLine(bExitPen, bExitPoints[0], bExitPoints[1]);
            e.Graphics.DrawLine(bExitPen, bExitPoints[2], bExitPoints[3]);
        }

        Rectangle bMaximizeRectangle;
        bool maximizeInitial = false;
        Pen bMaximizePen;
        bool bMaximaizeMouseOver = false;
        private void bMaximize_Paint(object sender, PaintEventArgs e)
        {
           int Height = ((Button)sender).Height;
           int Width = ((Button)sender).Width;
            if (!maximizeInitial)
            {
                maximizeInitial = true;
                bMaximizeRectangle = new Rectangle(Width / 2 - 4, Height / 2 - 4, 8, 8);
            }
            if (bMaximaizeMouseOver)
            {
                bMaximizePen = new Pen(Color.White);
            }else bMaximizePen= new Pen(ThemeColor);
            e.Graphics.DrawRectangle(bMaximizePen, bMaximizeRectangle);
        }

        Point[] bMinimizePoints = null;
        bool minimizeInitial = false;
        Pen bMinimizePen;
        bool bMinimaizeMouseOver = false;
        private void bMinimize_Paint(object sender, PaintEventArgs e)
        {
            int Height = ((Button)sender).Height;
            int Width = ((Button)sender).Width;
            if (!minimizeInitial)
            {
                minimizeInitial = true; bMinimizePoints = new Point[2];
                bMinimizePoints[0] = new Point(Width / 2 - 5, Height / 2);
                bMinimizePoints[1] = new Point(Width / 2 + 5, Height / 2);
            }            if(bMinimaizeMouseOver) bMinimizePen = new Pen(Color.White);
            else bMinimizePen = new Pen(ThemeColor);
            e.Graphics.DrawLine(bMinimizePen, bMinimizePoints[0], bMinimizePoints[1]);
        }

        private void bExit_MouseEnter(object sender, EventArgs e)
        {
            bExitMouseOver = true;
        }

        private void bExit_MouseLeave(object sender, EventArgs e)
        {
            bExitMouseOver =false;
        }

        private void bMaximize_MouseEnter(object sender, EventArgs e)
        {
            bMaximaizeMouseOver = true;
        }

        private void bMaximize_MouseLeave(object sender, EventArgs e)
        {
            bMaximaizeMouseOver = false;
        }

        private void bEMinimize_MouseEnter(object sender, EventArgs e)
        {
            bMinimaizeMouseOver = true;
        }

        private void bEMinimize_MouseLeave(object sender, EventArgs e)
        {
            bMinimaizeMouseOver = false;
        }

        public FlatSliderMenu SliderMenu
        {
            get { return this.flatSliderMenu1; }
            set { this.flatSliderMenu1 = value;}
        }

        private void pBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
