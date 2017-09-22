using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1033304_week12_EX1
{
    public partial class Form3 : Form
    {
        private float R, G, B, A;
        public Form3()
        {
            InitializeComponent();
            R = G = B = A = 1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = (float)trackBar1.Value / 10;
            label5.Text = R.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = (float)trackBar2.Value / 10;
            label6.Text = G.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = (float)trackBar3.Value / 10;
            label7.Text = B.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            A = (float)trackBar4.Value / 10;
            label8.Text = A.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R = (float)trackBar1.Value / 10;
            G = (float)trackBar2.Value / 10;
            B = (float)trackBar3.Value / 10;
            A = (float)trackBar4.Value / 10;
            this.Close();
        }

        public float getR()
        {
            return R;
        }
        public float getG()
        {
            return G;
        }
        public float getB()
        {
            return B;
        }
        public float getA()
        {
            return A;
        }
    }
}
