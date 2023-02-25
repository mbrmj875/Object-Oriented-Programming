﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Rectangle : Figure
    {
        public static int count = 0;
        public Rectangle() { }
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height)
        {
            if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                FList.RectanglesList.Add(this);
                FList.figureList.Add(this);
                number = count;
                count++;
            }
            else
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст");
            }
        }
        public Rectangle(int x, int y, int width, int height, bool f) : base(x, y, width, height)
        {
            if ((x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст");
            }
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawRectangle(pen, x, y, width, height);
            pictureBox.Image = bitmap;
            DrawText("Rect", number);
        }
        public void Draw(bool f)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawRectangle(pen, x, y, width, height);
            pictureBox.Image = bitmap;
        }

        public void ResizeRect(int width, int height)
        {
            if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                this.width = width; this.height = height;
                DeleteF(this, false);
                Draw();
            }
            else
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст");
            }
        }
    }
}

