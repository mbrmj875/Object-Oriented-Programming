using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class draw : Figure
    {
        private Rectangle Body { get; set; }

        static private int count = 0;

        public draw() { }
        public draw(int x, int y, int width, int height)
        {
            if (x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height)
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст!");
            }
            else
            {
                this.x = x; this.y = y; this.width = width; this.height = width;
                Create_all();
                FList.RobotsList.Add(this);
                FList.figureList.Add(this);
                number = count;
                count++;
            }
        }
        public draw(string name, int x, int y, int width)
        {
            if (x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height)
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст!");
            }
            else
            {
                this.x = x; this.y = y; this.width = width; this.height = width; this.name = name;
                Create_all();
                FList.RobotsList.Add(this);
                FList.figureList.Add(this);
                number = count;
                count++;
            }
        }

        private void Create_body()
        {
            Body = new Rectangle(x + width * 2 / 7, y + height * 3 / 7, width * 3 / 7, height * 3 / 7, false);
        }



        private void Create_all()
        {
            Create_body();

        }
        public override void Draw()
        {
            Body.Draw(false);

            DrawText("Robot ", number, x + width * 2 / 7, y + height * 3 / 10, width * 3 / 7, height * 1 / 2);
        }
        public void Draw_with_name()
        {
            Body.Draw(false);

            DrawText(name, x + width * 2 / 7, y + height * 3 / 10, width * 3 / 7, height * 1 / 2);
        }
        public override void MoveTo(int dx, int dy)
        {
            if (dx < 0 || dy < 0 || dx + width > pictureBox.Width || dy + height > pictureBox.Height)
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст!");
            }
            else
            {
                x = dx; y = dy;
                Create_all();
                DeleteF(this, false);
                Draw_with_name();
            }
        }


        public void change_all(int x, int y)
        {
            if (x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height)
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст!");
            }
            else
            {
                this.x = x; this.y = y;

                Create_all();
                DeleteF(this, false);
                Draw_with_name();
            }
        }
        public void DeleteF(draw figure, bool flag)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, x, y, width, height);
            FList.figureList.Remove(figure);
            ClearMap();
            foreach (draw f in FList.figureList)
            {
                f.Draw_with_name();
            }
            if (flag != true)
            {
                FList.figureList.Add(figure);
            }
            pictureBox.Image = bitmap;
        }
    }
}