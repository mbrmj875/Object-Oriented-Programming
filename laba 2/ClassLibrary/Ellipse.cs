using System;
using System.Drawing;

namespace ClassLibrary
{
    public class Ellipse : Circle
    {
        public int axle { get; set; }
        public Ellipse(int _x, int _y, int _r, int _axle)
        {
            this.x = _x;
            this.y = _y;
            this.r = _r;
            this.axle = _axle;
        }

        public Ellipse()
        {
            Random random = new Random();
            this.x = random.Next(100, 250);
            this.y = random.Next(100, 250);
            this.r = random.Next(10, 100);
            this.axle = random.Next(10, 100);
        }

        public override void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 5);
            gc.DrawEllipse(pen, this.x - this.axle, this.y - this.r, 2 * this.axle, 2 * this.r);
        }

       
    }
}
