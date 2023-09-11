using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FlatUIControls
{
    public partial class FlatMenu : UserControl
    {
        public FlatMenu()
        {
            InitializeComponent();
        }

        
        private void FlatMenu_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(FlautMenu_MouseWheel);
            pPanelContainer.Left = 0;
            pPanelContainer.Width = this.Width-5;
            pPanelContainer.Top = 0;
            _ScrollValue = 0;

        }
       

        public int getCurrentScroll()
        {
            //Application.DoEvents();
            if (pPanelContainer.Height < this.Height) return 0;
            int extraheight = (pPanelContainer.Height - this.Height);
            return (-pPanelContainer.Top) * 100 / extraheight;
        }

        bool _wheelok = true;
        Graphics g = null;
        double newScrollValue = 0;
        private void FlautMenu_MouseWheel(object sender, MouseEventArgs e)
        {// Determine whether the mouse wheel was scrolled up or down.
            if(!_wheelok) return;
            _wheelok = false;
            int dH = pPanelContainer.Height - this.Height;

            int Dscroll = 10;
            if(this.Height>dH)
            {
                Dscroll = 100;
            }else
            {
                Dscroll = this.Height*50 / dH;
            }
            if (dH > 0)
            {
                //double newScrollValue = 0;
                if (e.Delta > 0)
                {
                    newScrollValue = _ScrollValue- Dscroll;
                    if (newScrollValue < 0) newScrollValue = 0;

                }
                else
                {
                    newScrollValue = _ScrollValue + Dscroll;
                    if (newScrollValue > 100) newScrollValue = 100;
                }
               // tScroller.Start();
                new System.Threading.Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    double scrollvalue = _ScrollValue;
                    while (Math.Abs(scrollvalue - newScrollValue) > 1)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            scrollvalue = newScrollValue * 0.2 + scrollvalue * 0.8;
                            double target = (-dH * scrollvalue / 100);
                            double top = target;
                            pPanelContainer.Top = (int)top;
                            _ScrollValue = (int)scrollvalue;
                            this.Invalidate();
                        }));
                        System.Threading.Thread.Sleep(1);

                    }

                    _ScrollValue = (int)newScrollValue;
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pPanelContainer.Top = (int)(-dH * _ScrollValue / 100);
                    }));
                }).Start();
            }
            else
            {
                pPanelContainer.Top = 0;
            }
            _wheelok = true;
        }

        private FlatMenuItem[] _items;
        public FlatMenuItem[] Items
        {
            get {
                return _items;
            }
            set { 
                _items = value; 
                this.pItemContainer.Controls.Clear();
                this._items = value;
                if(this._items != null)
                foreach(FlatMenuItem item in this._items)
                {
                    item.Dock = DockStyle.Top;
                    item.CaptionPadding = 2;
                    this.pItemContainer.Controls.Add(item);
                    item.BringToFront();
                }
            }
        }



       
        private int _ScrollValue=0;
        public int ScrollValue
        {
            get { return _ScrollValue; }
            set { _ScrollValue = value;
            }
        }

      
    

       

        private void pItemContainer_resize(object sender, EventArgs e)
        {
            pPanelContainer.Height = pItemContainer.Height;
        }
        private void FlatMenu_Paint(object sender, PaintEventArgs e)
        {
            if(HasScrollbar)
            {
                if (this.Height < this.pPanelContainer.Height)
                {
                    var myPen2 = new SolidBrush(Color.FromArgb(60,200,200,200));
                    var scroll = new Rectangle(new Point(this.Width - 5, _ScrollValue * (this.Height - 30) / 100), new Size(5, 30));
                    e.Graphics.FillRectangle(myPen2, scroll);
                }
            }
        }

        private void FlatMenu_Resize(object sender, EventArgs e)
        {
            pPanelContainer.Left = 0;
            pPanelContainer.Top = 0;
            ScrollValue = 0;
            pPanelContainer.Width = this.Width-5;
        }

        private bool _HasScrollbar = false;
        public bool HasScrollbar
        {
            get { return _HasScrollbar; }
            set { _HasScrollbar = value; }
        }

        public Color _ThemeColor = Color.FromArgb(239, 41, 84);
        public Color ThemeColor
        {
            get
            {
                return _ThemeColor;
            }
            set
            {
                _ThemeColor = value;
                foreach(var item in Items)
                {
                    item.ThemeColor = _ThemeColor;
                }
            }

        }
    }
}
