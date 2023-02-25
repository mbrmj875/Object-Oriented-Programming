using System;
using System.Drawing;

namespace ClassLibrary
{
    public class Circle : TFigure
    {
        public int r { get; set; }
        public Circle(int _x, int _y, int _r)
        {
            this.x = _x;
            this.y = _y;
            this.r = _r;
        }
        public Circle()
        {
            Random random = new Random();
            this.x = random.Next(180, 250);
            this.y = random.Next(180, 250);
            this.r = random.Next(10, 100);
        }
        public override void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 5);
            gc.DrawEllipse(pen, this.x - this.r, this.y - this.r, 2 * this.r, 2 * this.r);
        }
        public void ChangeRadius(int _r)
        {
            this.r = _r;
        }

    }
}
