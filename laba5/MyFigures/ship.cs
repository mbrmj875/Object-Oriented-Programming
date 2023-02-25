using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class ship : Figure
    {
        private Rectangle flag { get; set; }

        private Line line_1 { get; set; }
        private Line line_2 { get; set; }
        private Line line_3 { get; set; }
        private Line line_4 { get; set; }
        private Line line_5 { get; set; }
        private Line line_6 { get; set; }
        private Line line_7 { get; set; }
        static private int count = 0;

        public ship() { }
        public ship(int x, int y, int width, int height)
        {
            if (x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height)
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст!");
            }
            else
            {
                this.x = x; this.y = y; this.width = width; this.height = width;
                Create_all();
                FList.shipsList.Add(this);
                FList.figureList.Add(this);
                number = count;
                count++;
            }
        }

        private void Create_flag()
        {
            flag = new Rectangle(x + width * 150 / 70, y + height * 20 / 70, width * 50 / 70, height * 25 / 70, false);
        }

        private void Create_line_1()
        {
            line_1 = new Line(x + width * 100 / 70, y + height * 100 / 70, x + width * 300 / 70, y + height * 100 / 70);
        }
        private void Create_line_2()
        {
            line_2 = new Line(x + width * 150 / 70, y + height * 150 / 70, x + width * 250 / 70, y + height * 150 / 70);
        }
        private void Create_line_3()
        {
            line_3 = new Line(x + width * 100 / 70, y + height * 100 / 70, x + width * 150 / 70, y + height * 150 / 70);
        }
        private void Create_line_4()
        {
            line_4 = new Line(x + width * 250 / 70, y + height * 150 / 70, x + width * 300 / 70, y + height * 100 / 70);
        }
        private void Create_line_5()
        {
            line_5 = new Line(x + width * 200 / 70, y + height * 100 / 70, x + width * 200 / 70, y + height * 20 / 70);
        }
        private void Create_line_6()
        {
            line_6 = new Line(x + width * 150 / 70, y + height * 100 / 70, x + width * 200 / 70, y + height * 40 / 70);
        }
        private void Create_line_7()
        {
            line_7 = new Line(x + width * 250 / 70, y + height * 100 / 70, x + width * 200 / 70, y + height * 20 / 70);
        }

        private void Create_all()
        {
            Create_flag();
            Create_line_1();
            Create_line_2();
            Create_line_3();
            Create_line_4();
            Create_line_5();
            Create_line_6();
            Create_line_7();
        }
        public override void Draw()
        {
            flag.Draw(false);
            line_1.Draw();
            line_2.Draw();
            line_3.Draw();
            line_4.Draw();
            line_5.Draw();
            line_6.Draw();
            line_7.Draw();

        }
        public override void MoveTo(int dx, int dy)
        {
            if (x + dx < 0 || y + dy < 0 || x + dx + width > pictureBox.Width || y + dy + height > pictureBox.Height)
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст!");
            }
            else
            {
                x += dx; y += dy;
                Create_all();
                DeleteF(this, false);
                Draw();
            }
        }

        public void Resizeship(int width, int height)
        {
            if (x < 0 || y < 0 || x > pictureBox.Width || y > pictureBox.Height)
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст!");
            }
            else
            {
                this.width = width; this.height = height;
                Create_all();
                DeleteF(this, false);
                Draw();
            }

        }
    }
}
