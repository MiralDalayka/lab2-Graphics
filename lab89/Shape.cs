using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab89
{
    enum ShapeType
    {
        Rectangel
        , Polygon
    }
    internal class Shape
    {
        //define 2 points topleftcprner downrightcorner
        //define the hight and the width =downrightcorner
        Point topLeftCorner, downRightCorner;
        int width, hieght;
        ShapeType type;
        public Shape(int x1, int y1, int x2, int y2,ShapeType type)
        {
            //here i want to define which points are the left and right corners

            /*
              if (x1 > x2)
             {
                 //case 1: from downright to topleft OR topright to downleft 
                 if (y1 > y2)
                 {
                     //case 1.a: from downright to topleft
                     TopLeftCorner = new Point(x2, y2);
                     DownRightCorner = new Point(x1, y1);

                 }
                 else
                 {
                     if (y2 > y1)
                     {
                         //case 1.b:  topright to downleft
                         TopLeftCorner = new Point(x2, y1);
                         DownRightCorner = new Point(x1, y2);
                     }
                 }
             }
             else if (x2 > x1) // to right
             {
                 //case 2: from topleft to downright OR downleft to topright
                 if (y1 > y2) // down
                 {
                     //case 2.a: leftdown to righttop
                     TopLeftCorner = new Point(x1, y2);
                     DownRightCorner = new Point(x2, y1);
                 }
                 else if (y2 > y1)
                 {
                     //case 2.b:  topleft to down right
                     TopLeftCorner = new Point(x1, y1);
                     DownRightCorner = new Point(x2, y2);
                 }
             }
             */
            ////////////////////////////OR////////////////////////////

            TopLeftCorner = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            DownRightCorner = new Point(Math.Max(x1, x2), Math.Max(y1, y2));


            hieght = Math.Abs(y2 - y1);
            width = Math.Abs(x2 - x1);
            this.type = type;


        }
        public Point TopLeftCorner { get => topLeftCorner; set => topLeftCorner = value; }
        public Point DownRightCorner
        {
            get => downRightCorner; set => downRightCorner = value;
        }

        public int Width { get => width; set => width = value; }
        public int Hieght { get => hieght; set => hieght = value; }
        public void drawTheShape(Pen pen, Graphics graphics)
        {
            if (type == ShapeType.Rectangel)
                graphics.DrawRectangle(pen, TopLeftCorner.X, TopLeftCorner.Y, Width, Hieght);
            else
                graphics.DrawEllipse(pen, TopLeftCorner.X, TopLeftCorner.Y, Width, Hieght);

        }

        public void fillShape(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.Yellow);
            Brush brush2 = new SolidBrush(Color.Red);


            if (type == ShapeType.Rectangel)
                graphics.FillRectangle(brush, TopLeftCorner.X, TopLeftCorner.Y, Width, Hieght);
            else
                graphics.FillEllipse(brush2, TopLeftCorner.X, TopLeftCorner.Y, Width, Hieght);

        }

        public void moveShape(int dx,int dy)
        {
            topLeftCorner.X += dx;
            topLeftCorner.Y += dy;
            downRightCorner.X += dx;
            downRightCorner.Y += dy;

        }
    }



}
