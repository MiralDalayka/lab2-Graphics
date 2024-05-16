namespace lab89
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 128, 0);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.Crimson;
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1116, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(881, 11);
            button6.Name = "button6";
            button6.Size = new Size(150, 137);
            button6.TabIndex = 6;
            button6.Text = "Open Image";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(688, 11);
            button5.Name = "button5";
            button5.Size = new Size(150, 137);
            button5.TabIndex = 5;
            button5.Text = "Save IImage";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(500, 11);
            button4.Name = "button4";
            button4.Size = new Size(150, 137);
            button4.TabIndex = 4;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.tri;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(332, 11);
            button3.Name = "button3";
            button3.Size = new Size(150, 137);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.rac;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(176, 11);
            button2.Name = "button2";
            button2.Size = new Size(150, 137);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.cirlce;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(20, 11);
            button1.Name = "button1";
            button1.Size = new Size(150, 137);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 562);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            Paint += Form2_Paint;
            MouseClick += Form2_MouseClick;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button6;
    }
}