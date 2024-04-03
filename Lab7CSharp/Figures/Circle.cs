using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp.Figures
{
    public class Circle : Figure
    {
        public Circle(Color c, Point l, float l1) : base(c, l, l1)
        {
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(this.Color);
            g.DrawEllipse(pen, Location.X, Location.Y, l1, l1);
        }
    }
}
