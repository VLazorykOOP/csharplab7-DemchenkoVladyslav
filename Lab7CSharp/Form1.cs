using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
          {
              for (; true;)
              {
                  button1.BackColor = Color.Red;
                  button2.BackColor = Color.Gray;
                  button3.BackColor = Color.Gray;
                  Thread.Sleep(1000 * (int)numericUpDown1.Value);
                  button2.BackColor = Color.Yellow;
                  button1.BackColor = Color.Gray;
                  button3.BackColor = Color.Gray;
                  Thread.Sleep(1000 * (int)numericUpDown1.Value);
                  button3.BackColor = Color.Green;
                  button2.BackColor = Color.Gray;
                  button1.BackColor = Color.Gray;
                  Thread.Sleep(1000 * (int)numericUpDown1.Value);
              }
          }
);
        }
    }
}
