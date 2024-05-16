using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab89
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            bitmap = new Bitmap(this.Width, this.Height);
            graphics2 = Graphics.FromImage(bitmap);
        }

        Graphics graphics, graphics2;
        Bitmap bitmap;
        Pen pen = new Pen(Color.Red);
        int value = 0;
        List<Shape2> shaapsList = new List<Shape2>();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = 1;
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)

        {
            List<Point> points = [new Point(e.X, e.Y), new Point(100, 100)];

            switch (value)
            {
                case 1:

                    Shape2 shape = new Shape2(points);
                    shaapsList.Add(shape);
                    if (e.Button == MouseButtons.Left)
                    {
                        shape.Draw(graphics, pen, Shape2.ShapeType2.Circle);
                        shape.Draw(graphics2, pen, Shape2.ShapeType2.Circle);

                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        shape.Fill(graphics, new SolidBrush(Color.Red), Shape2.ShapeType2.Circle);

                        shape.Fill(graphics2, new SolidBrush(Color.Red), Shape2.ShapeType2.Circle);


                    }
                    break;
                case 2:

                    Shape2 shape2 = new Shape2(points);
                    shaapsList.Add(shape2);
                    if (e.Button == MouseButtons.Left)
                    {
                        shape2.Draw(graphics, pen, Shape2.ShapeType2.Rectangle);
                        shape2.Draw(graphics2, pen, Shape2.ShapeType2.Rectangle);

                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        shape2.Fill(graphics, new SolidBrush(Color.Red), Shape2.ShapeType2.Rectangle);

                        shape2.Fill(graphics2, new SolidBrush(Color.Red), Shape2.ShapeType2.Rectangle);

                    }
                    break;
                case 3:

                    Shape2 shape3 = new Shape2(points);
                    shape3.points = new List<Point> { new Point(e.X, e.Y), new Point(e.X + 50, e.Y + 100), new Point(e.X - 50, e.Y + 100), };
                    shaapsList.Add(shape3);
                    if (e.Button == MouseButtons.Left)
                    {
                        shape3.Draw(graphics, pen, Shape2.ShapeType2.Triangle);
                        shape3.Draw(graphics2, pen, Shape2.ShapeType2.Triangle);

                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        shape3.Fill(graphics, new SolidBrush(Color.Red), Shape2.ShapeType2.Triangle);
                        shape3.Fill(graphics2, new SolidBrush(Color.Red), Shape2.ShapeType2.Triangle);

                    }
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            value = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            value = 3;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            value = 3;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            value = 3;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            graphics2.Clear(Color.White);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //save the bitimage
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "jpegImage|*.jpeg|pngImage|*.png|gifImage|*.gif";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FilterIndex == 1)
                {
                    //save jpeg
                    bitmap.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (saveFile.FilterIndex == 2)
                {
                    bitmap.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (saveFile.FilterIndex == 3)
                {
                    bitmap.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpegImage|*.jpeg|pngImage|*.png|gifImage|*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFile.FileName);
                graphics2 = Graphics.FromImage(bitmap);
                graphics.DrawImage(bitmap, 0, 0);
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            graphics.DrawImage(bitmap, 0, 0);

        }
    }
}
