﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FlatUIControls
{
    public partial class FlatMenuItem : UserControl
    {
        public static int k = 0;
        FlatToolTip tooltip;
        public FlatMenuItem()
        {
            InitializeComponent();
            if (Caption != null && Caption == "---Item-") Caption = this.Name;
            else if (Caption != null && Caption.Length == 0) Caption = "MenuItem";
           
        }

        public FlatMenuItem(string Key,String caption, ImageList imageList, int imageIndex)
        {
            InitializeComponent();
            this.Caption = caption;
            this.ImageList = imageList;
            this.ImageIndex=imageIndex;
            this.Key = Key;
        }

        public FlatMenuItem(string Key, String caption, ImageList imageList, int imageIndex,FlatMenuItem parent)
        {
            InitializeComponent();
            this.Caption = caption;
            this.ImageList = imageList;
            this.ImageIndex = imageIndex;
            this.Key = Key;
            this.Parent = parent;
        }



        public FlatMenuItem(string Key, String caption)
        {
            InitializeComponent();
            this.Caption = caption;
            this.Key = Key;
        }


        public FlatSliderMenu SliderMenuParent;

        private FlatMenuItem _Parent = null;
        private int Level = 0;


        private void FlatMenuItem_Load(object sender, EventArgs e)
        {
            child.Visible = false;
            //foreach(FlatMenuItem item in this.ch)
            if (Caption == null) Caption = this.Name + k++;
        }

        bool painted = false;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!painted)
            {
                if (Parent != null) this.Level = Parent.Level + 1;
                this.FlatItemButton.Padding = new Padding(10 * Level + _ImagePadding, 0, 0, 0);
                painted = true;
                string strpadding = "";
                for (int i = 0; i < this._CaptionPadding; i++) strpadding += " ";
                if (_ShowCaption) FlatItemButton.Text = strpadding + _Caption;
                else FlatItemButton.Text = "";
            }
        }

        public void CollapseMenu()
        {
            child.Visible = false;
            if (this.Parent != null)
            {
                this.Parent.CollapseMenu();
            }
        }




        private void FlatItemButton_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                if (child.Items.Length > 0)
                {
                    if (child.InvokeRequired)
                    {
                        child.Invoke(new MethodInvoker(() =>
                        {
                            child.Visible = !child.Visible;
                        }));
                    }
                    else { child.Visible = !child.Visible; }
                    foreach (FlatMenuItem item in child.Items)
                    {
                        //Application.DoEvents();
                        //item.Invalidate();
                        if (item.InvokeRequired)
                        {
                            item.Invoke(new MethodInvoker(() =>
                            {
                                item.ShowCaption = item.ShowCaption; //refresh children view}));
                                }));
                        }
                        else item.ShowCaption = item.ShowCaption;

                    }
                }
                else
                {
                    if (Parent != null)
                    {
                        if (Parent.InvokeRequired)
                        {
                            Parent.Invoke(new MethodInvoker(() =>
                            {
                                Parent.CollapseMenu();
                                Parent.Invalidate();
                            }));
                        }
                        else
                        {
                            Parent.CollapseMenu();
                            Parent.Invalidate();
                        }
                    }

                }
                if (SliderMenuParent != null)
                {
                    if (SliderMenuParent.InvokeRequired)
                    {
                        SliderMenuParent.Invoke(new MethodInvoker(() =>
                        {
                            SliderMenuParent.SendItemClickEvent(this, e);
                            SliderMenuParent.Invalidate();
                        }));
                    }
                    else
                    {
                        SliderMenuParent.SendItemClickEvent(this, e);
                        SliderMenuParent.Invalidate();
                    }

                }
                System.Threading.Thread.Sleep(100);
                if (SliderMenuParent != null)
                {
                    if (SliderMenuParent.InvokeRequired)
                    {
                        SliderMenuParent.Invoke(new MethodInvoker(() =>
                        {
                            SliderMenuParent.ScrollValue=0;
                        }));
                    }
                    else
                    {
                        SliderMenuParent.ScrollValue = 0;
                    }

                }
            }).Start();

            
        }

        private FlatMenuItem Parent
        {
            get { return _Parent; }
            set
            {
                this._Parent = value;
                if (_Parent == null) this.Level = 0;
                else this.Level = _Parent.Level + 1;


            }
        }

        private string _Caption;
        [Category("Advanced Options")]
        public String Caption
        {
            get { return _Caption; }
            set { _Caption = value;
                string strpadding = "";
                for (int i = 0; i < this._CaptionPadding; i++) strpadding += " ";
                if (_ShowCaption) FlatItemButton.Text = strpadding + _Caption;
                else FlatItemButton.Text = "";
            }
        }

        [Category("Advanced Options")]
        public Color BackColor
        {
            get { return FlatItemButton.BackColor; }
            set { FlatItemButton.BackColor = value; }
        }

        [Category("Advanced Options")]
        public Color ForeColor
        {
            get { return FlatItemButton.ForeColor; }
            set { FlatItemButton.ForeColor = value; }
        }

        [Category("Advanced Options")]
        public Color MouseDownBackColor
        {
            get { return FlatItemButton.FlatAppearance.MouseDownBackColor; }
            set { FlatItemButton.FlatAppearance.MouseDownBackColor = value; }
        }

        [Category("Advanced Options")]
        public Color MouseOverBackColor
        {
            get { return FlatItemButton.FlatAppearance.MouseOverBackColor; }
            set { FlatItemButton.FlatAppearance.MouseOverBackColor = value; }
        }

        private FlatMenuItem[] _childrens;
        [Category("Advanced Options")]
        public FlatMenuItem[] Childrens
        {
            get { return _childrens; }
            set
            {
                _childrens = value;
                if (_childrens != null)
                {
                    foreach (FlatMenuItem item in _childrens)
                    {
                        item.Parent = this;
                        item.SliderMenuParent = this.SliderMenuParent;
                    }
                }
                else _childrens = new FlatMenuItem[0];
                this.child.pItemContainer.AutoSize = true;
                this.child.pPanelContainer.AutoSize = true;
                this.child.pPanelContainer.Dock = DockStyle.Top;
                this.child.Items = _childrens;
            }
        }

        [Category("Advanced Options")]
        public ImageList ImageList
        {
            get { return FlatItemButton.ImageList; }
            set { FlatItemButton.ImageList = value; }
        }

        [Category("Advanced Options")]
        public int ImageIndex
        {
            get { return FlatItemButton.ImageIndex; }
            set { FlatItemButton.ImageIndex = value; }
        }

        private int _ImagePadding = 5;
        [Category("Advanced Options")]
        public int ImagePadding
        {
            get { return _ImagePadding; }
            set
            {
                _ImagePadding = value;
            }
        }

        private int _CaptionPadding = 0;
        [Category("Advanced Options")]
        public int CaptionPadding
        {
            get { return _CaptionPadding; }
            set { this._CaptionPadding = value;
                string strpadding = "";
                for (int i = 0; i < this._CaptionPadding; i++) strpadding += " ";
                if (_ShowCaption) FlatItemButton.Text = strpadding + _Caption;
                else FlatItemButton.Text = "";
            }
        }

        private bool _ShowCaption = true;
        [Category("Advanced Options")]
        public bool ShowCaption
        {
            get { return _ShowCaption; }
            set
            {
                this._ShowCaption = value;
                string strpadding = "";
                for (int i = 0; i < this._CaptionPadding; i++) strpadding += " ";
                if (_ShowCaption) FlatItemButton.Text = strpadding + _Caption;
                else FlatItemButton.Text = "";
                if (_ShowCaption)
                {
                    this.FlatItemButton.Padding = new Padding(10 * Level + _ImagePadding, 0, 0, 0);
                    this.FlatItemButton.Invalidate();
                }
                else
                {
                    this.FlatItemButton.Padding = new Padding(_ImagePadding, 0, 0, 0);
                    this.FlatItemButton.Invalidate();
                }
                this.FlatItemButton.Invalidate();
                if (this._childrens != null)
                {
                    foreach (FlatMenuItem child in this._childrens)
                    {
                        child.ShowCaption = _ShowCaption;
                    }
                }
            }
        }

        public Color CaptionColor {
            get { return this.FlatItemButton.ForeColor; }
            set { this.FlatItemButton.ForeColor = value;}
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
                FlatItemButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, _ThemeColor);
                FlatItemButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, _ThemeColor);
                this.child.BackColor = Color.FromArgb(10, _ThemeColor);
                this.child.ThemeColor = _ThemeColor;
            }
        }

        private string _Key;
        public string Key
        {
            get { return _Key; }
            set { this._Key = value; }
        }

        int mouseon = 0;
        private void timerToolTip_Tick(object sender, EventArgs e)
        {
            if(mouseenter)
            {
                mouseon++;
                Point location = this.PointToScreen(Point.Empty);
                location.X  += 60;
                location.Y += this.Height/3;
                if (mouseon == 5 && !this.ShowCaption)
                {
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        tooltip = new FlatToolTip();
                        if (tooltip == null) tooltip = new FlatToolTip();
                        tooltip.TooltipShowDuration = 3000;
                        tooltip.TooltipText = this.Caption;
                        tooltip.ShowTooltip( new Point(location.X , location.Y));
                        tooltip.Refresh();
                        System.Threading.Thread.Sleep(2000);
                        tooltip.Close();
                        tooltip.Dispose();
                        mouseenter = false;
                    }).Start();
                }else if(mouseon == 30 && !this.ShowCaption)
                {
                    mouseon = 0;
                }
            }else
            {
                mouseon = 0;
            }
        }

        bool mouseenter = false;
        private void FlatItemButton_MouseEnter(object sender, EventArgs e)
        {
            mouseenter = true;
        }

        private void FlatItemButton_MouseLeave(object sender, EventArgs e)
        {
            //
            //
            if(mouseon<5)    mouseenter = false;
            //if(tooltip != null)tooltip.HideTooltip();
        }
    }
}
