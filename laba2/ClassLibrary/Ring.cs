using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ring
    {
        private Circle firstCircle;
        private Circle secondCircle;

        public Ring(int x, int y, int r1, int r2)
        {
            this.firstCircle = new Circle(x, y, r1);
            this.secondCircle = new Circle(x, y, r2); 
        }

        public Ring(Point point, int r1, int r2)
        {
            this.firstCircle = new Circle(point, r1);
            this.secondCircle = new Circle(point, r2);
        }

        public Ring()
        {
            Random random = new Random();
            Point point = new Point();
            this.firstCircle = new Circle(point, random.Next(10, 150));
            this.secondCircle = new Circle(point, random.Next(10, 150));
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 5);
            firstCircle.Show(gc, color);
            secondCircle.Show(gc, color);
        }

        public void MoveTo(int x, int y)
        {
            firstCircle.MoveTo(x, y);
            secondCircle.MoveTo(x, y);
        }

        public Point GetCenterPoint()
        {
            return this.firstCircle.GetCenterPoint();
        }
    }
}
