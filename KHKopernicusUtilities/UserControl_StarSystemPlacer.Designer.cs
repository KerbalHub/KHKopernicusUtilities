namespace KHKopernicusUtilities
{
    partial class UserControl_StarSystemPlacer
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
            label1 = new Label();
            textBoxDec_Degrees = new TextBox();
            textBoxDec_Minutes = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDec_Seconds = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxRA_Seconds = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxRA_Minutes = new TextBox();
            textBoxRA_Degrees = new TextBox();
            label10 = new Label();
            textBox_output = new TextBox();
            button1 = new Button();
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
            label1.Text = "Star System Placer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDec_Degrees
            // 
            textBoxDec_Degrees.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDec_Degrees.Location = new Point(67, 294);
            textBoxDec_Degrees.Name = "textBoxDec_Degrees";
            textBoxDec_Degrees.Size = new Size(65, 59);
            textBoxDec_Degrees.TabIndex = 3;
            // 
            // textBoxDec_Minutes
            // 
            textBoxDec_Minutes.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDec_Minutes.Location = new Point(182, 294);
            textBoxDec_Minutes.Name = "textBoxDec_Minutes";
            textBoxDec_Minutes.Size = new Size(65, 59);
            textBoxDec_Minutes.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 294);
            label2.Name = "label2";
            label2.Size = new Size(38, 52);
            label2.TabIndex = 5;
            label2.Text = "°";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 297);
            label3.Name = "label3";
            label3.Size = new Size(30, 52);
            label3.TabIndex = 6;
            label3.Text = "'";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(586, 301);
            label4.Name = "label4";
            label4.Size = new Size(36, 52);
            label4.TabIndex = 8;
            label4.Text = "\"";
            // 
            // textBoxDec_Seconds
            // 
            textBoxDec_Seconds.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDec_Seconds.Location = new Point(289, 294);
            textBoxDec_Seconds.Name = "textBoxDec_Seconds";
            textBoxDec_Seconds.Size = new Size(291, 59);
            textBoxDec_Seconds.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 262);
            label5.Name = "label5";
            label5.Size = new Size(202, 29);
            label5.TabIndex = 9;
            label5.Text = "Enter Declination:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(67, 430);
            label6.Name = "label6";
            label6.Size = new Size(254, 29);
            label6.TabIndex = 16;
            label6.Text = "Enter Right Ascension:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(586, 469);
            label7.Name = "label7";
            label7.Size = new Size(36, 52);
            label7.TabIndex = 15;
            label7.Text = "\"";
            // 
            // textBoxRA_Seconds
            // 
            textBoxRA_Seconds.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRA_Seconds.Location = new Point(289, 462);
            textBoxRA_Seconds.Name = "textBoxRA_Seconds";
            textBoxRA_Seconds.Size = new Size(291, 59);
            textBoxRA_Seconds.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(253, 465);
            label8.Name = "label8";
            label8.Size = new Size(30, 52);
            label8.TabIndex = 13;
            label8.Text = "'";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(138, 462);
            label9.Name = "label9";
            label9.Size = new Size(38, 52);
            label9.TabIndex = 12;
            label9.Text = "°";
            // 
            // textBoxRA_Minutes
            // 
            textBoxRA_Minutes.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRA_Minutes.Location = new Point(182, 462);
            textBoxRA_Minutes.Name = "textBoxRA_Minutes";
            textBoxRA_Minutes.Size = new Size(65, 59);
            textBoxRA_Minutes.TabIndex = 11;
            // 
            // textBoxRA_Degrees
            // 
            textBoxRA_Degrees.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRA_Degrees.Location = new Point(67, 462);
            textBoxRA_Degrees.Name = "textBoxRA_Degrees";
            textBoxRA_Degrees.Size = new Size(65, 59);
            textBoxRA_Degrees.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(67, 806);
            label10.Name = "label10";
            label10.Size = new Size(91, 29);
            label10.TabIndex = 19;
            label10.Text = "Output:";
            // 
            // textBox_output
            // 
            textBox_output.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_output.Location = new Point(67, 838);
            textBox_output.Multiline = true;
            textBox_output.Name = "textBox_output";
            textBox_output.ReadOnly = true;
            textBox_output.Size = new Size(1017, 171);
            textBox_output.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 40, 45);
            button1.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(67, 679);
            button1.Name = "button1";
            button1.Size = new Size(449, 77);
            button1.TabIndex = 17;
            button1.Text = "Convert!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserControl_StarSystemPlacer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label10);
            Controls.Add(textBox_output);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBoxRA_Seconds);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBoxRA_Minutes);
            Controls.Add(textBoxRA_Degrees);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxDec_Seconds);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDec_Minutes);
            Controls.Add(textBoxDec_Degrees);
            Controls.Add(label1);
            Name = "UserControl_StarSystemPlacer";
            Size = new Size(1132, 1038);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDec_Degrees;
        private TextBox textBoxDec_Minutes;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDec_Seconds;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxRA_Seconds;
        private Label label8;
        private Label label9;
        private TextBox textBoxRA_Minutes;
        private TextBox textBoxRA_Degrees;
        private Label label10;
        private TextBox textBox_output;
        private Button button1;
    }
}
