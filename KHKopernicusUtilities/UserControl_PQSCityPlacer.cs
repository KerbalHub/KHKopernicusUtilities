using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KHKopernicusUtilities
{
    public partial class UserControl_PQSCityPlacer : UserControl
    {
        float Latitude = 0.1f;
        float Longitude = 0.1f;
        float Radius = 600000.0f;
        float ValueX = 0.0f;
        float ValueY = 0.0f;
        float ValueZ = 0.0f;
        public UserControl_PQSCityPlacer()
        {
            InitializeComponent();
        }

        void Calculate(float LatDegrees, float LongDegrees)
        {
            float LatRadians = (float)(LatDegrees * (Math.PI / 180));
            float LongRadians = (float)((LongDegrees - 90) * (Math.PI / 180));
            ValueX = (float)(Math.Cos(LatRadians) * Math.Sin(LongRadians));
            ValueY = (float)(Math.Sin(LatRadians));
            ValueZ = (float)(Math.Cos(LatRadians) * Math.Cos(LongRadians));
            textBox_output.Text = ValueX.ToString() + ", " + ValueY.ToString() + ", " + ValueZ.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Latitude = float.Parse(textBox_Latitude.Text);
            Longitude = float.Parse(textBox_Longitude.Text);
            //placeholder.Text = "Latitude is " + Latitude.ToString() + " and Longitude is " + Longitude.ToString();
            Calculate(Latitude, Longitude);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_output.Text);
        }
    }
}
