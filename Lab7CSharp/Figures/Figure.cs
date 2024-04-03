using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp.Figures
{
    public abstract class Figure
    {
        public Color Color { get; set; }
        public Point Location { get; set; }
        public float l1 { get; set; }

        public abstract void Draw(Graphics g);
        public Figure (Color c, Point l, float l1)
        {
            this.Color = c;
            this.Location = l;
            this.l1 = l1;
        }
    }
}
