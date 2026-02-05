using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;

namespace KHKopernicusUtilities
{
    public partial class UserControl_waveLengthCalc : UserControl
    {
        float Red = 0.3f;
        float Green = 0.3f;
        float Blue = 0.3f;

        float Augment = 0.1f;

        float RLinear = 0.5f;
        float GLinear = 0.5f;
        float BLinear = 0.5f;

        float X = 0.5f;
        float Y = 0.5f;
        float Z = 0.5f;
        public UserControl_waveLengthCalc()
        {
            InitializeComponent();
        }
        float Linearize(float C)
        {
            if (C < 0.04046)
            {
                return (float)(C / 12.92);
            }
            else
            {
                return (float)Math.Pow((C + 0.055) / 1.055, 2.4);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Red = (float)trackBar_Red.Value / 255;
            Green = (float)trackBar_Green.Value / 255;
            Blue = (float)trackBar_Blue.Value / 255;

            Augment = (float)trackBar_Augment.Value / 10;

            RLinear = Linearize(Red);
            GLinear = Linearize(Green);
            BLinear = Linearize(Blue);

            X = (float)(((0.4124 * RLinear) + (0.3576 * GLinear) + (0.1805 * BLinear)) * Augment);
            Y = (float)(((0.1216 * RLinear) + (0.7152 * GLinear) + (0.0722 * BLinear)) * Augment);
            Z = (float)(((0.0193 * RLinear) + (0.1192 * GLinear) + (0.9505 * BLinear)) * Augment);

            textBox_output.Text = "invWaveLength = " + X.ToString() + "," + Y.ToString() + "," + Z.ToString() + ",0.5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar_Red.Value = int.Parse(textBox_Red.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar_Green.Value = int.Parse(textBox_Green.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trackBar_Blue.Value = int.Parse(textBox_Blue.Text);
        }
    }
}
