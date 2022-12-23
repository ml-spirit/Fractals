using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawCircle(Graphics graphics, int x, int y, int radius, Color color)
        {
            graphics.DrawEllipse(new Pen(color), x, y, radius, radius);
            graphics.FillEllipse(new SolidBrush(color), x, y, radius, radius);
        }

        private void DrawRect(Graphics graphics, int x, int y, int width, int height, Color color)
        {
            graphics.DrawRectangle(new Pen(color), x, y, width, height);
            graphics.FillRectangle(new SolidBrush(color), x, y, width, height);
        }

        private void DrawTriangle(Graphics graphics, int x1, int y1, int x2, int y2, int x3, int y3,  Color color)
        {
            var context = new Point[3];
            context[0].X = x1;
            context[0].Y = y1;
            context[1].X = x2;
            context[1].Y = y2;
            context[2].X = x3;
            context[2].Y = y3;
            graphics.DrawPolygon(new Pen(color), context);
            graphics.FillPolygon(new SolidBrush(color), context);
        }

        private void DrawObject(Graphics graphics, int x, int y, int offsetX, int offsetY, int deltaX, int deltaY, int radius, Color color)
        {
            DrawCircle(graphics, x + offsetX * deltaX, y + offsetY * deltaY, radius, color);
            //DrawRect(graphics, x + offsetX * deltaX, y + offsetY * deltaY, radius, radius, color);
        }

        private void DrawObjects(Graphics graphics, int x, int y, int offsetX, int offsetY, Color color, int deep)
        {
            var radius = rand.Next(5, 30);
            {
                DrawObject(graphics, x, y, offsetX, offsetY, 1, 1, radius, color);
                DrawObject(graphics, x, y, offsetX, offsetY, 1, -1, radius, color);
                DrawObject(graphics, x, y, offsetX, offsetY, -1, 1, radius, color);
                DrawObject(graphics, x, y, offsetX, offsetY, -1, -1, radius, color);
            }
            if (deep < 10)
            {
                DrawObjects(
                    graphics,
                    x,
                    y,
                    offsetX + rand.Next(-10, 30),
                    offsetY + rand.Next(-10, 30),
                    color,
                    deep + 1);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var _offsetX = int.Parse(this.offsetX.Text);
            var _offsetY = int.Parse(this.offsetY.Text);
            {
                DrawObjects(e.Graphics, ClientSize.Width / 2, ClientSize.Height / 2, _offsetX, _offsetY, Color.FromArgb(70, 0, 0, rand.Next(0, 200)), 0);
                DrawObjects(e.Graphics, ClientSize.Width / 2, ClientSize.Height / 2, _offsetX, _offsetY, Color.FromArgb(70, 0, rand.Next(0, 200), 0), 0);
                DrawObjects(e.Graphics, ClientSize.Width / 2, ClientSize.Height / 2, _offsetX, _offsetY, Color.FromArgb(70, rand.Next(0, 200), 0, 0), 0);
                DrawObjects(e.Graphics, ClientSize.Width / 2, ClientSize.Height / 2, _offsetX, _offsetY, Color.FromArgb(70, rand.Next(0, 200), 0, 255), 0);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
