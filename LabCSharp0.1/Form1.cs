using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y - 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y + 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + 10, label1.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X - 10, label1.Location.Y);

        }
    }
}
