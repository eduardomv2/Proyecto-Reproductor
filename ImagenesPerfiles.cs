using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Proyecto_Reproductor
{
    internal class ImagenesPerfiles : PictureBox
    {
        //Bordes
        private int bordersize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink; 
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;


        //Constructor
        public ImagenesPerfiles()
        {
            this.Size = new Size(100,100);  
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //propiedades
        public int Bordersize
        {
            get
            {
                return bordersize;
            }

            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }

            set
            {
                borderColor2 = value;
                this.Invalidate();
            }
        }

        public DashStyle BorderLineStyle
        {
            get
            {
                return borderLineStyle;
            }

            set
            {
                borderLineStyle = value;
                this.Invalidate();
            }
        }

        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }

            set
            {
                borderCapStyle = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }


        //OVERRIDE

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Height);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            //Bordes
            var graph = pe.Graphics;
            var rectCountourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectCountourSmooth, -bordersize, -bordersize);
            var SmoothSize= bordersize > 0 ? bordersize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder,BorderColor, BorderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor,SmoothSize))
            using (var penBorder = new Pen (borderGColor, bordersize))
            {
              penBorder.DashStyle = DashStyle.Dot;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectCountourSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode= SmoothingMode.AntiAlias;


                //Dibujar el suavizado

                graph.DrawEllipse(penSmooth, rectCountourSmooth);
                if (Bordersize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);

                     
            }
        }
    }


   
}
