using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            Random random = new Random();
            this.x = random.Next(0, 760);
            this.y = random.Next(0, 567);
        }

        public void Show(Graphics gc, Color color)
        {
            //Так как точка на рисунке будет представлять собой очень маленький круг,
            //создадим локальную переменную r
            int r = 5;
            Pen pen = new Pen(color, 5);
            gc.DrawEllipse(pen, this.x - r, this.y - r, 2 * r, 2 * r);
        }

        public void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
