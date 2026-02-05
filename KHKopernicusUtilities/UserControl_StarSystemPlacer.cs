using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KHKopernicusUtilities
{
    public partial class UserControl_StarSystemPlacer : UserControl
    {
        float Dec = 0.3f;
        float RA = 0.3f;
        float Inclination = 0.3f;
        float LAN = 0.3f;
        public UserControl_StarSystemPlacer()
        {
            InitializeComponent();
        }

        void Calculate(float Declination, float RightAscension)
        {
            Inclination = Math.Abs(Declination);
            if (Declination < 0)
            {
                LAN = RightAscension + 90;
            }
            else
            {
                LAN = RightAscension - 90;
            }
            textBox_output.Text = "inclination = " + Inclination.ToString() + Environment.NewLine + "longitudeOfAscendingNode = " + LAN.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dec = float.Parse(textBoxDec_Degrees.Text) + (float.Parse(textBoxDec_Minutes.Text) / 60) + (float.Parse(textBoxDec_Seconds.Text) / 3600);
            RA = float.Parse(textBoxRA_Degrees.Text) + (float.Parse(textBoxRA_Minutes.Text) / 60) + (float.Parse(textBoxRA_Seconds.Text) / 3600);
            Calculate(Dec, RA);
        }
    }
}
