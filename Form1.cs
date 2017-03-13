using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterpoladorLinear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            try {
                float xx0 = float.Parse(x0.Text.Replace(".", ","));
                float xx1 = float.Parse(x1.Text.Replace(".", ","));
                float yy0 = float.Parse(y0.Text.Replace(".", ","));
                float yy1 = float.Parse(y1.Text.Replace(".", ","));
                float xx = float.Parse(x.Text.Replace(".", ","));
                float yy = yy0 + (yy1 - yy0) * ((xx - xx0) / (xx1 - xx0));
                y.Text = yy.ToString();
            }
            catch(Exception ex){}
        }

        private void x1_TextChanged(object sender, EventArgs e)
        {
            try {
                float rangeY = float.Parse(y1.Text.Replace(".", ",")) - float.Parse(y0.Text.Replace(".", ","));
                float rangeX = float.Parse(x1.Text.Replace(".", ",")) - float.Parse(x0.Text.Replace(".", ","));
                float yy0 = float.Parse(y0.Text.Replace(".", ","));
                float xx0 = float.Parse(x0.Text.Replace(".", ","));
                string seq = "y = ";
                if (yy0 != 0) seq += yy0 + " + ";
                seq += rangeY + " * ( (float) ";
                if (xx0 > 0) seq += "(x - " + xx0 + ")/";
                else if (xx0 < 0) seq += "(x + " + (-xx0) + ")/";
                else seq += "x/";
                seq += rangeX + ")";
                eq.Text = seq;
            }
            catch(Exception){}
        }
    }
}
