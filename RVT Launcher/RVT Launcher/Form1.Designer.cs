namespace RVT_Launcher
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
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 650);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 164);
            button4.Name = "button4";
            button4.Size = new Size(223, 62);
            button4.TabIndex = 2;
            button4.Text = "RVTGaming: Create";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 84);
            button2.Name = "button2";
            button2.Size = new Size(223, 62);
            button2.TabIndex = 1;
            button2.Text = "RVTGaming Pack";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.BackgroundImage = Properties.Resources.th;
            panel2.Controls.Add(button3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 647);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = Properties.Resources.th;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FloralWhite;
            button3.Location = new Point(9, 9);
            button3.Name = "button3";
            button3.Size = new Size(223, 39);
            button3.TabIndex = 0;
            button3.Text = "Select a modpack!";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(576, 682);
            button1.Name = "button1";
            button1.Size = new Size(245, 63);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            BackgroundImage = Properties.Resources._507653;
            ClientSize = new Size(1334, 775);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "RVTGaming Launcher v0.0.1";
            TransparencyKey = Color.Transparent;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}