using System;
using System.Drawing;

namespace ClassLibrary
{
    public abstract class TFigure
    {
        public int x { get; set; }
        public int y { get; set; }

        public int x1 { get; set; }
        public int y1 { get; set; }
        public TFigure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public TFigure()
        {
            Random rnd = new Random();
            this.x = rnd.Next(0, 554);
            this.y = rnd.Next(0, 481);
        }
        public abstract void Show(Graphics gc, Color color);
        public void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
            this.x1 += x;
            this.y1 += y;
        }
    }
}
