using System.Diagnostics;

namespace lab89
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen pen = new Pen(Color.Blue);
        Graphics graphics;
        int x1, x2, y1, y2;
        List<Shape> shapes = [];
        int selectecShapeIndex;
        bool mode = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            reDraw();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            paintShape(new Point(x1, y1));

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            //count the diff
            int dx = (int)(x2 - x1);
            int dy = (int)(y2 - y1);
            if (mode)
            {    shapes[selectecShapeIndex].moveShape(dx, dy);
                reDraw();
                mode = false;
            }

            else
            {
                Shape shape;

                if (e.Button == MouseButtons.Left)
                {
                    shape = new Shape(x1, y1, x2, y2, ShapeType.Rectangel);

                }
                else
                {
                    shape = new Shape(x1, y1, x2, y2, ShapeType.Polygon);

                }
                shape.drawTheShape(pen, graphics);
                shapes.Add(shape);

            }

        }

        private void reDraw()
        {
            graphics.Clear(Color.White);
            foreach (Shape shape in shapes)
            {
                shape.drawTheShape(pen, graphics);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reDraw();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paintShape(Point p)
        {
            for(int i=0;i<shapes.Count;i++) {
                if (p.X > shapes[i].TopLeftCorner.X && p.X < shapes[i].DownRightCorner.X && p.Y < shapes[i].DownRightCorner.Y && p.Y > shapes[i].TopLeftCorner.Y)
                {
                    shapes[i].fillShape(graphics);
                    selectecShapeIndex = i;
                    mode = true;
                   }
            }
           
        }
    }
}
