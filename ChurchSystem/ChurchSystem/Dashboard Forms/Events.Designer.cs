namespace ChurchSystem.Dashboard_Forms
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            btnnext = new Button();
            btnprevious = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F);
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 1;
            label2.Text = "Sunday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F);
            label3.Location = new Point(147, 80);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 2;
            label3.Text = "Monday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F);
            label4.Location = new Point(278, 80);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 3;
            label4.Text = "Tuesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F);
            label5.Location = new Point(676, 80);
            label5.Name = "label5";
            label5.Size = new Size(68, 24);
            label5.TabIndex = 4;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F);
            label6.Location = new Point(395, 80);
            label6.Name = "label6";
            label6.Size = new Size(131, 24);
            label6.TabIndex = 4;
            label6.Text = "Wednesday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F);
            label7.Location = new Point(540, 80);
            label7.Name = "label7";
            label7.Size = new Size(97, 24);
            label7.TabIndex = 5;
            label7.Text = "Thursday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F);
            label8.Location = new Point(791, 80);
            label8.Name = "label8";
            label8.Size = new Size(99, 24);
            label8.TabIndex = 6;
            label8.Text = "Saturday";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(0, 116);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(925, 733);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(124, 90);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            btnnext.BackgroundImage = (Image)resources.GetObject("btnnext.BackgroundImage");
            btnnext.BackgroundImageLayout = ImageLayout.Zoom;
            btnnext.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnext.Location = new Point(708, 13);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(74, 43);
            btnnext.TabIndex = 8;
            btnnext.UseVisualStyleBackColor = true;
            // 
            // btnprevious
            // 
            btnprevious.BackgroundImage = (Image)resources.GetObject("btnprevious.BackgroundImage");
            btnprevious.BackgroundImageLayout = ImageLayout.Zoom;
            btnprevious.Location = new Point(143, 13);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(74, 43);
            btnprevious.TabIndex = 10;
            btnprevious.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(218, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(488, 43);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(909, 694);
            Controls.Add(textBox1);
            Controls.Add(btnprevious);
            Controls.Add(btnnext);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Events";
            Text = "Events";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnnext;
        private Button btnprevious;
        private TextBox textBox1;
        private Button button1;
    }
}