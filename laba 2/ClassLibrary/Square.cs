using System;
using System.Drawing;

namespace ClassLibrary
{
    public class Square : TFigure
    {
        public int height { get; set; }

        public Square(int _x, int _y, int _height)
        {
            this.x = _x;
            this.y = _y;
            this.height = _height;
        }
        public Square()
        {
            Random random = new Random();
            this.x = random.Next(180, 250);
            this.y = random.Next(180, 250);
            this.height = random.Next(10, 150);
        }

        public override void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 5);
            gc.DrawRectangle(pen, this.x - (this.height / 2), this.y - (this.height / 2), this.height, this.height);
        }

        public void ChangeSideLenght(int _height)
        {
            this.height = _height;
        }
    }
}
