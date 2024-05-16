using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab89
{

    public class Shape2
    {
       public enum ShapeType2
        {
            Circle,
            Triangle,
            Rectangle
        }

    public    List<Point> points =new List<Point>();
     
      public  Shape2(List<Point> points)
        {
            this.points = points;
            
        }

        public void Draw(Graphics graphics,Pen pen,ShapeType2 shapeType)
        {
            switch(shapeType)
            {
                case ShapeType2.Circle:
                    graphics.DrawEllipse(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
                    break;
                case ShapeType2.Rectangle:
                    graphics.DrawRectangle(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
                    break;
                case ShapeType2.Triangle:
                    graphics.DrawPolygon(pen, points.ToArray());
                    break;
            }
        }
        public void Fill(Graphics graphics,Brush brush,ShapeType2 shapeType)
        {
            switch (shapeType)
            {
                case ShapeType2.Circle:
                    graphics.FillEllipse(brush, points[0].X, points[0].Y, points[1].X, points[1].Y);
                    break;
                case ShapeType2.Rectangle:
                    graphics.FillRectangle(brush, points[0].X, points[0].Y, points[1].X, points[1].Y);
                    break;
                case ShapeType2.Triangle:
                    graphics.FillPolygon(brush, points.ToArray());
                    break;
            }
        }
    }
}
