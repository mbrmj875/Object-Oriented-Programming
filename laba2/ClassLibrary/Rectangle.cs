using System;
using System.Drawing;

namespace ClassLibrary
{
    public class Rectangle : Square
    {
        public int width { get; set; }
        public Rectangle(int _x, int _y, int _width, int _height)
        {
            this.x = _x;
            this.y = _y;
            this.height = _height;
            this.width = _width;
        }
        public Rectangle()
        {
            Random random = new Random();
            this.x = random.Next(180, 250);
            this.y = random.Next(180, 250);
            this.height = random.Next(10, 150);
            this.width = random.Next(10, 150);
        }
        public override void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 5);
            gc.DrawRectangle(pen, this.x - (this.width / 2), this.y - (this.height / 2), this.width, this.height);
        }
    }
}
