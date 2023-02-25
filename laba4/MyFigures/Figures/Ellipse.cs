﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Ellipse : Figure
    {
        public static int count = 0;
        public Ellipse() { }
        public Ellipse(int x, int y, int width, int height) : base(x, y, width, height) 
        {
            if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                FList.EllipsesList.Add(this);
                FList.figureList.Add(this);
                number = count;
                count++;
            }
            else
            {
               MessageBox.Show("Фигура должна полностью помещаться на холст");
            }
        }
        public Ellipse(int x, int y, int width, int height, bool f) : base(x, y, width, height)
        {
            if ((x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст");
            }
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(pen, x, y, width, height);
            pictureBox.Image = bitmap;
            DrawText("Ell", number);
        }
        public void Draw(bool f)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(pen, x, y, width, height);
            pictureBox.Image = bitmap;
        }
        public void ResizeEll(int width, int height)
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
