namespace KHKopernicusUtilities
{
    partial class UserControl_PQSCityPlacer
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
            textBox_Latitude = new TextBox();
            textBox_Longitude = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox_output = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Roboto", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1132, 177);
            label1.TabIndex = 1;
            label1.Text = "PQS City Placer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Latitude
            // 
            textBox_Latitude.Font = new Font("Roboto", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Latitude.Location = new Point(56, 258);
            textBox_Latitude.Name = "textBox_Latitude";
            textBox_Latitude.Size = new Size(449, 52);
            textBox_Latitude.TabIndex = 2;
            // 
            // textBox_Longitude
            // 
            textBox_Longitude.Font = new Font("Roboto", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Longitude.Location = new Point(56, 412);
            textBox_Longitude.Name = "textBox_Longitude";
            textBox_Longitude.Size = new Size(449, 52);
            textBox_Longitude.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 226);
            label2.Name = "label2";
            label2.Size = new Size(169, 29);
            label2.TabIndex = 5;
            label2.Text = "Enter Latitude:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 380);
            label3.Name = "label3";
            label3.Size = new Size(188, 29);
            label3.TabIndex = 6;
            label3.Text = "Enter Longitude:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 40, 45);
            button1.Font = new Font("Roboto", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(56, 688);
            button1.Name = "button1";
            button1.Size = new Size(449, 77);
            button1.TabIndex = 8;
            button1.Text = "Convert!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox_output
            // 
            textBox_output.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_output.Location = new Point(56, 847);
            textBox_output.Name = "textBox_output";
            textBox_output.ReadOnly = true;
            textBox_output.Size = new Size(1017, 65);
            textBox_output.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 815);
            label5.Name = "label5";
            label5.Size = new Size(91, 29);
            label5.TabIndex = 10;
            label5.Text = "Output:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 40, 45);
            button2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(56, 931);
            button2.Name = "button2";
            button2.Size = new Size(449, 55);
            button2.TabIndex = 11;
            button2.Text = "Copy to Clipboard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UserControl_PQSCityPlacer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox_output);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Longitude);
            Controls.Add(textBox_Latitude);
            Controls.Add(label1);
            Name = "UserControl_PQSCityPlacer";
            Size = new Size(1132, 1038);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Latitude;
        private TextBox textBox_Longitude;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox_output;
        private Label label5;
        private Button button2;
    }
}
