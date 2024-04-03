﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp.Figures
{
    public class Triangle : Figure
    {
        public Triangle(Color c, Point l, float l1) : base(c, l, l1)
        {
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(this.Color);
            Point[] points = new Point[]
            {
                new Point(Location.X, Location.Y),
                new Point(Location.X + (int)l1/2, Location.Y + (int)Math.Sqrt(l1*l1 - l1*l1/4)),
                new Point( Location.X + (int)l1, Location.Y)
            };
            g.DrawPolygon(pen, points);
        }
    }
}
