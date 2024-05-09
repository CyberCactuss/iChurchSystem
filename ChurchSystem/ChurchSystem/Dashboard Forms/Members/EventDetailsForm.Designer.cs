namespace ChurchSystem.Dashboard_Forms.Members
{
    partial class EventDetailsForm
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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(350, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 670);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label7.Location = new Point(22, 549);
            label7.Name = "label7";
            label7.Size = new Size(208, 28);
            label7.TabIndex = 5;
            label7.Text = "Event Host Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label6.Location = new Point(22, 457);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 4;
            label6.Text = "Venue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label5.Location = new Point(22, 270);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 3;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label4.Location = new Point(22, 358);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 2;
            label4.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label3.Location = new Point(3, 49);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 1;
            label3.Text = "Event Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(148, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 31);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(9, 308);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 370);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 47);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Upcoming Events";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(9, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 294);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 35);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Ongoing Events";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label8.Location = new Point(22, 604);
            label8.Name = "label8";
            label8.Size = new Size(142, 28);
            label8.TabIndex = 6;
            label8.Text = "Description\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label9.Location = new Point(3, 137);
            label9.Name = "label9";
            label9.Size = new Size(135, 28);
            label9.TabIndex = 7;
            label9.Text = "Event Type";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(396, 29);
            comboBox1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 255);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(546, 11);
            panel4.TabIndex = 9;
            // 
            // EventDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 694);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EventDetailsForm";
            Text = "EventDetailsForm";
            Load += EventDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Panel panel4;
        private ComboBox comboBox1;
    }
}