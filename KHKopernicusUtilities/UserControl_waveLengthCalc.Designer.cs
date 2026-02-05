namespace KHKopernicusUtilities
{
    partial class UserControl_waveLengthCalc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            trackBar_Red = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            trackBar_Green = new TrackBar();
            label4 = new Label();
            trackBar_Blue = new TrackBar();
            label10 = new Label();
            textBox_output = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            trackBar_Augment = new TrackBar();
            textBox_Red = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox_Green = new TextBox();
            button3 = new Button();
            textBox_Blue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trackBar_Red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Augment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Roboto", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1132, 177);
            label1.TabIndex = 2;
            label1.Text = "waveLength Calculator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar_Red
            // 
            trackBar_Red.AutoSize = false;
            trackBar_Red.Location = new Point(78, 238);
            trackBar_Red.Maximum = 255;
            trackBar_Red.Name = "trackBar_Red";
            trackBar_Red.Size = new Size(635, 90);
            trackBar_Red.TabIndex = 3;
            trackBar_Red.Value = 170;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 197);
            label2.Name = "label2";
            label2.Size = new Size(191, 38);
            label2.TabIndex = 4;
            label2.Text = "Red (0-255):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 336);
            label3.Name = "label3";
            label3.Size = new Size(221, 38);
            label3.TabIndex = 6;
            label3.Text = "Green (0-255):";
            // 
            // trackBar_Green
            // 
            trackBar_Green.AutoSize = false;
            trackBar_Green.Location = new Point(78, 377);
            trackBar_Green.Maximum = 255;
            trackBar_Green.Name = "trackBar_Green";
            trackBar_Green.Size = new Size(635, 90);
            trackBar_Green.TabIndex = 5;
            trackBar_Green.Value = 160;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 475);
            label4.Name = "label4";
            label4.Size = new Size(199, 38);
            label4.TabIndex = 8;
            label4.Text = "Blue (0-255):";
            // 
            // trackBar_Blue
            // 
            trackBar_Blue.AutoSize = false;
            trackBar_Blue.Location = new Point(78, 516);
            trackBar_Blue.Maximum = 255;
            trackBar_Blue.Name = "trackBar_Blue";
            trackBar_Blue.Size = new Size(635, 90);
            trackBar_Blue.TabIndex = 7;
            trackBar_Blue.Value = 150;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(52, 776);
            label10.Name = "label10";
            label10.Size = new Size(91, 29);
            label10.TabIndex = 21;
            label10.Text = "Output:";
            // 
            // textBox_output
            // 
            textBox_output.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_output.Location = new Point(52, 808);
            textBox_output.Multiline = true;
            textBox_output.Name = "textBox_output";
            textBox_output.ReadOnly = true;
            textBox_output.Size = new Size(1017, 171);
            textBox_output.TabIndex = 20;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 609);
            label5.Name = "label5";
            label5.Size = new Size(155, 38);
            label5.TabIndex = 23;
            label5.Text = "Augment:";
            // 
            // trackBar_Augment
            // 
            trackBar_Augment.AutoSize = false;
            trackBar_Augment.Location = new Point(78, 650);
            trackBar_Augment.Maximum = 100;
            trackBar_Augment.Name = "trackBar_Augment";
            trackBar_Augment.Size = new Size(635, 90);
            trackBar_Augment.TabIndex = 22;
            trackBar_Augment.Value = 50;
            // 
            // textBox_Red
            // 
            textBox_Red.Font = new Font("Roboto", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Red.Location = new Point(719, 238);
            textBox_Red.Name = "textBox_Red";
            textBox_Red.Size = new Size(159, 52);
            textBox_Red.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 40, 45);
            button1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(893, 238);
            button1.Name = "button1";
            button1.Size = new Size(150, 52);
            button1.TabIndex = 25;
            button1.Text = "Set Red";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 40, 45);
            button2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(893, 377);
            button2.Name = "button2";
            button2.Size = new Size(150, 52);
            button2.TabIndex = 27;
            button2.Text = "Set Green";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox_Green
            // 
            textBox_Green.Font = new Font("Roboto", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Green.Location = new Point(719, 377);
            textBox_Green.Name = "textBox_Green";
            textBox_Green.Size = new Size(159, 52);
            textBox_Green.TabIndex = 26;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 40, 45);
            button3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(893, 516);
            button3.Name = "button3";
            button3.Size = new Size(150, 52);
            button3.TabIndex = 29;
            button3.Text = "Set Blue";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox_Blue
            // 
            textBox_Blue.Font = new Font("Roboto", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Blue.Location = new Point(719, 516);
            textBox_Blue.Name = "textBox_Blue";
            textBox_Blue.Size = new Size(159, 52);
            textBox_Blue.TabIndex = 28;
            // 
            // UserControl_waveLengthCalc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button3);
            Controls.Add(textBox_Blue);
            Controls.Add(button2);
            Controls.Add(textBox_Green);
            Controls.Add(button1);
            Controls.Add(textBox_Red);
            Controls.Add(label5);
            Controls.Add(trackBar_Augment);
            Controls.Add(label10);
            Controls.Add(textBox_output);
            Controls.Add(label4);
            Controls.Add(trackBar_Blue);
            Controls.Add(label3);
            Controls.Add(trackBar_Green);
            Controls.Add(label2);
            Controls.Add(trackBar_Red);
            Controls.Add(label1);
            Name = "UserControl_waveLengthCalc";
            Size = new Size(1132, 1038);
            ((System.ComponentModel.ISupportInitialize)trackBar_Red).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Green).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Augment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TrackBar trackBar_Red;
        private Label label2;
        private Label label3;
        private TrackBar trackBar_Green;
        private Label label4;
        private TrackBar trackBar_Blue;
        private Label label10;
        private TextBox textBox_output;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private TrackBar trackBar_Augment;
        private TextBox textBox_Red;
        private Button button1;
        private Button button2;
        private TextBox textBox_Green;
        private Button button3;
        private TextBox textBox_Blue;
    }
}
