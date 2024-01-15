using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form2 f2;
        public Form3 f3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(textBox1.Text);
            int ok=1;
            while (nr > 9)
            {
                if (nr % 10 > nr / 10 % 10) ok = 0;
                nr /= 10;
            }
            if (ok == 1) f2.ShowDialog();
            else f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2 = new Form2();
            f3 = new Form3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
