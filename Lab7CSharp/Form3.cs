using Lab7CSharp.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        Random r = new Random();
        List<Figure> figures = new List<Figure>();
        public Form3()
        {
            InitializeComponent();
            pictureBox2.BackColor = Color.Red;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            foreach (Figure f in figures)
            {
                f.Draw(g);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                pictureBox2.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Figure f;
            int maxPosX = pictureBox1.Width - (int)numericUpDown1.Value;
            int maxPosY = pictureBox1.Height - (int)numericUpDown1.Value;
            if (radioButton1.Checked)
            {
                f = new Circle(pictureBox2.BackColor, new Point(r.Next(0, maxPosX), r.Next(0, maxPosY)), (int)numericUpDown1.Value);
            }
            else if (radioButton2.Checked)
            {
                f = new Triangle(pictureBox2.BackColor, new Point(r.Next(0, maxPosX), r.Next(0, maxPosY)), (int)numericUpDown1.Value);
            }
            else if (radioButton3.Checked)
            {
                f = new Square(pictureBox2.BackColor, new Point(r.Next(0, maxPosX), r.Next(0, maxPosY)), (int)numericUpDown1.Value);
            }
            else
            {
                f = new Star(pictureBox2.BackColor, new Point(r.Next(0, maxPosX), r.Next(0, maxPosY)), (int)numericUpDown1.Value);
            }
            figures.Add(f);
            numericUpDown2.Value = figures.Count;
        }
    }
}
