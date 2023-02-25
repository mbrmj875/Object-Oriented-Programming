using System;
using System.Drawing;

namespace ClassLibrary
{
    public class Line : TFigure
    {
        public Line(int _x1, int _y1, int _x2, int _y2)
        {
            this.x = _x1;
            this.y = _y1;
            this.x1 = _x2;
            this.y1 = _y2;
        }

        public Line()
        {
            Random random = new Random();
            this.x = random.Next(1, 350);
            this.y = random.Next(1, 350);
            this.x1 = random.Next(1, 350);
            this.y1 = random.Next(1, 350);
        }
        public override void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 5);
            gc.DrawLine(pen, this.x, this.y, this.x1, this.y1);
        }

    }
}
