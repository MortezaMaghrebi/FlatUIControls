using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlatUIControls
{
    public partial class FlatSliderMenu : UserControl
    {
        public FlatSliderMenu()
        {
            InitializeComponent();
            _DesiredWidth = this.Width;
        }
        bool collapsed = false;
        private void FlatSliderMenu_Load(object sender, EventArgs e)
        {
            pLogo.Image = LogoImage;
            pLogo.Left = (this.Width - pLogo.Width) / 2;
            flatMenu1.HasScrollbar = true;
        }

        private bool dontresize = false;
        private void FlatSliderMenu_Resize(object sender, EventArgs e)
        {
            if (!dontresize)
            {
                if (pProfile.Width < 160)
                {
                    pLogo.Width = pProfile.Width - 10;
                    pLogo.Height = 40;
                }
                else
                {
                    pLogo.Width = 150;
                    pLogo.Height = 80;
                }
                pLogo.Left = (pProfile.Width - pLogo.Width) / 2;
                pLogo.Top = (pProfile.Height - pLogo.Height) / 2;


                if (pProfile.Width < 160)
                {
                    pLogo.Image = _SmallLogoImage;
                }
                else
                {
                    pLogo.Image = _LogoImage;
                }
                if (Width < 120)
                {
                    if (this.MenuItems != null)
                    {
                        foreach (FlatMenuItem item in this.MenuItems)
                        {
                            item.ShowCaption = false;
                        }
                    }
                }
                else
                {
                    if (this.MenuItems != null)
                    {
                        foreach (FlatMenuItem item in this.MenuItems)
                        {
                            item.ShowCaption = true;
                        }
                    }
                }
            }
            this.Invalidate();

        }

        public void SendItemClickEvent(object sender,EventArgs e)
        {
            flatMenu1.ScrollValue = flatMenu1.getCurrentScroll();
            if(OnItemClick != null) OnItemClick(sender, e);
        }

        //Settings
        private Image _LogoImage;
        [Category ("Advance Options")]
        public Image LogoImage
        {
            get { return _LogoImage; }
            set { _LogoImage = value;
                if (pProfile.Width < 160)
                {
                    pLogo.Image = _SmallLogoImage;
                }
                else
                {
                    pLogo.Image = _LogoImage;
                }
            }
        }

        private Image _SmallLogoImage;
        [Category("Advance Options")]
        public Image SmallLogoImage
        {
            get { return _SmallLogoImage; }
            set { _SmallLogoImage = value;
                if (pProfile.Width < 160)
                {
                    pLogo.Image = _SmallLogoImage;
                }
                else
                {
                    pLogo.Image = _LogoImage;
                }
            }
        }

        [Browsable(true)]
        [Category("Advance Options")]
        public int LogoMarginTop
        {
            get { return pLogo.Top; }
            set { pLogo.Top = value;}
        }


        [Category("Advance Options")]
        public FlatMenuItem[] MenuItems
        {
            get
            {
                return flatMenu1.Items;
            }
            set
            {
                foreach(FlatMenuItem item in value)
                {
                    item.SliderMenuParent = this;
                    setCaptionColorWithchild(item, this.CaptionColor);
                }
               this.flatMenu1.Items = value;
            }
        }

        private int _DesiredWidth;
        [Category("Advance Options")]
        public int DesiredWidth
        {
            get{return _DesiredWidth;}
            set{_DesiredWidth = value;
                if(!collapsed) Width = _DesiredWidth;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Width -= 2;
            pictureBox1.Height -= 2;
            pictureBox1.Left += 1;
            pictureBox1.Top += 1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            pictureBox1.Width += 2;
            pictureBox1.Height += 2;
            pictureBox1.Left -= 1;
            pictureBox1.Top -= 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!collapsed)
            {
                int i = 50;
                {
                    this.Width = i;
                    Application.DoEvents();
                }
                collapsed = true;
            }else 
            {
                int i= _DesiredWidth;
                {
                    this.Width = i;
                    Application.DoEvents();
                }
                //dontresize=false;
                collapsed = false;
            }
        }

        public event EventHandler OnItemClick;



        public int ScrollValue
        {
            get { return flatMenu1.ScrollValue; }
            set
            {
                if (value > 100) value = 100;
                if (value < 0) value = 0;
                flatMenu1.ScrollValue = value;
            }
        }
    

        private void FlatSliderMenu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromArgb(20,0,0,0)), new Point(this.Width - 1, 0), new Point(this.Width - 1, this.Height - 1));
        }

        private void flatMenu1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int Width = pictureBox1.Width;
            int Height = pictureBox1.Height;
            Pen pen = new Pen(ThemeColor, 2);
            int X1 = Width / 8;
            int X2 = Width - X1;
            int Y1 = 2* Height / 8;
            int Y2 = 4* Height / 8;
            int Y3 = 6* Height / 8;
            e.Graphics.DrawLine(pen, new Point(X1, Y1), new Point(X2, Y1));
            e.Graphics.DrawLine(pen, new Point(X1, Y2), new Point(X2, Y2));
            e.Graphics.DrawLine(pen, new Point(X1, Y3), new Point(X2, Y3));
        }

        void setCaptionColorWithchild(FlatUIControls.FlatMenuItem item ,Color color)
        {
            item.CaptionColor = color;
            if (item.Childrens != null)
            {
                foreach (FlatMenuItem child in item.Childrens)
                {
                    setCaptionColorWithchild(child, color);
                }
            }
        }

        private Color _CaptionColor = Color.White;
        public Color CaptionColor
        {
            get { return _CaptionColor;}
            set { _CaptionColor = value;
                foreach (FlatMenuItem item in flatMenu1.Items)
                {
                    setCaptionColorWithchild(item, _CaptionColor);
                }
            }
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
                this.flatMenu1.ThemeColor = _ThemeColor;
            }

        }
    }
}
