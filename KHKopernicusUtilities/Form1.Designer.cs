namespace KHKopernicusUtilities
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            button_Menu = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            label1 = new Label();
            Timer_Sidebar = new System.Windows.Forms.Timer(components);
            Contents = new Panel();
            label2 = new Label();
            label3 = new Label();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)button_Menu).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(35, 40, 45);
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel5);
            Sidebar.Controls.Add(panel6);
            Sidebar.Controls.Add(label1);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(400, 1038);
            Sidebar.MinimumSize = new Size(150, 1038);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(400, 1038);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_Menu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 139);
            panel1.TabIndex = 0;
            // 
            // button_Menu
            // 
            button_Menu.Cursor = Cursors.Hand;
            button_Menu.Image = (Image)resources.GetObject("button_Menu.Image");
            button_Menu.Location = new Point(9, 9);
            button_Menu.Name = "button_Menu";
            button_Menu.Size = new Size(128, 128);
            button_Menu.SizeMode = PictureBoxSizeMode.AutoSize;
            button_Menu.TabIndex = 0;
            button_Menu.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 97);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(0, 23);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(397, 54);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(397, 97);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 23);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(397, 54);
            button2.TabIndex = 1;
            button2.Text = "Star System Placer";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(397, 97);
            panel4.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 23);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(397, 54);
            button3.TabIndex = 1;
            button3.Text = "PQS City Placer";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 457);
            panel5.Name = "panel5";
            panel5.Size = new Size(397, 97);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 23);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(397, 54);
            button4.TabIndex = 1;
            button4.Text = "Wavelength Calculator";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(3, 560);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 379);
            panel6.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Roboto Light", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 942);
            label1.Name = "label1";
            label1.Size = new Size(397, 74);
            label1.TabIndex = 0;
            label1.Text = "Copyright 2026 KH. GPL-3.0 License";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Contents
            // 
            Contents.BackgroundImage = (Image)resources.GetObject("Contents.BackgroundImage");
            Contents.BackgroundImageLayout = ImageLayout.Zoom;
            Contents.Dock = DockStyle.Fill;
            Contents.Location = new Point(400, 0);
            Contents.Name = "Contents";
            Contents.Size = new Size(1132, 1038);
            Contents.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 32);
            label2.Name = "label2";
            label2.Size = new Size(251, 38);
            label2.TabIndex = 1;
            label2.Text = "Kopernicus Utils";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(140, 70);
            label3.Name = "label3";
            label3.Size = new Size(76, 38);
            label3.TabIndex = 2;
            label3.Text = "v1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 1038);
            Controls.Add(Contents);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "KH's Kopernicus Utilities";
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)button_Menu).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private PictureBox button_Menu;
        private System.Windows.Forms.Timer Timer_Sidebar;
        private Panel Contents;
        private Panel panel6;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
