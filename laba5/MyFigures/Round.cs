﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Round : Ellipse
    {
        public static new int count = 0;
        public int diameter;
        public Round(int x, int y, int radius, bool f = true)
        {
            this.x = x;
            this.y = y;
            diameter = radius*2;
            if (!(x < 0 || y < 0 || x + diameter > pictureBox.Width || y + diameter > pictureBox.Height))
            {
                if (f)
                {
                    FList.RoundsList.Add(this);
                    FList.figureList.Add(this);
                    number = count;
                    count++;
                }

            }
            else
            {
                MessageBox.Show("Фигура должна полностью помещаться на холст");
            }
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(pen, x, y, diameter, diameter);
            pictureBox.Image = bitmap;
            DrawText("Ro", number, x, y, diameter, diameter);
        }
        public void Draw(Color color)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(new Pen(color, 6), x, y, diameter, diameter);
            pictureBox.Image = bitmap;
        }

        public override void MoveTo(int x, int y)
        {
            width = diameter; height = diameter;
            base.MoveTo(x, y);
        }

        public void ResizeRound(int radius)
        {
            if (!(x < 0 || y < 0 || x + radius * 2 > pictureBox.Width || y + radius * 2 > pictureBox.Height))
            {
                diameter = radius * 2;
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
