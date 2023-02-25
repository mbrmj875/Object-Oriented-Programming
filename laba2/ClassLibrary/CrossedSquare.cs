using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CrossedSquare
    {
        private Square square;
        private Line firstCrossingLine;
        private Line secondCrossingLine;

        public CrossedSquare(int x, int y, int sideLenght)
        {
            this.square = new Square(x, y, sideLenght);
            this.firstCrossingLine = new Line(this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
            this.secondCrossingLine = new Line(this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
        }

        public CrossedSquare(Point point, int sideLenght)
        {
            this.square = new Square(point, sideLenght);
            this.firstCrossingLine = new Line(this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
            this.secondCrossingLine = new Line(this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
        }

        public CrossedSquare()
        {
            this.square = new Square();
            this.firstCrossingLine = new Line(this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
            this.secondCrossingLine = new Line(this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
        }

        public void Show(Graphics gc, Color color)
        {
            this.square.Show(gc, color);
            this.firstCrossingLine = new Line(this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
            this.secondCrossingLine = new Line(this.square.GetCenterPoint().GetX() + (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetX() - (this.square.GetSideLenght() / 2), this.square.GetCenterPoint().GetY() + (this.square.GetSideLenght() / 2));
            this.firstCrossingLine.Show(gc, color);
            this.secondCrossingLine.Show(gc, color);
        }

        public void MoveTo(int x, int y)
        {
            this.square.MoveTo(x, y);
            this.firstCrossingLine.MoveTo(x, y);
            this.secondCrossingLine.MoveTo(x, y);
        }

        public Point GetCenterPoint()
        {
            return this.square.GetCenterPoint();
        }
    }
}
