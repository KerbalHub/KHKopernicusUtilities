namespace KHKopernicusUtilities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            ShowUserControl(new UserControl_Home());
        }
        private void ShowUserControl(UserControl uc)
        {
            Contents.Controls.Clear(); // Remove existing content
            uc.Dock = DockStyle.Fill; // Fill the content panel
            Contents.Controls.Add(uc); // Add the new control
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UserControl_Home());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UserControl_PQSCityPlacer());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UserControl_StarSystemPlacer());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UserControl_waveLengthCalc());
        }
    }
}
