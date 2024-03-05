namespace Polymorphism_with_interfaces
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(153, 325);
            button1.Name = "button1";
            button1.Size = new Size(178, 77);
            button1.TabIndex = 0;
            button1.Text = "Chihuahua";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(503, 325);
            button2.Name = "button2";
            button2.Size = new Size(178, 77);
            button2.TabIndex = 1;
            button2.Text = "Bulldog";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 92);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 2;
            label1.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 158);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 3;
            label2.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 238);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 4;
            label3.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 92);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 5;
            label4.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 158);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 6;
            label5.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 238);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 7;
            label6.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 83);
            label7.Name = "label7";
            label7.Size = new Size(67, 31);
            label7.TabIndex = 8;
            label7.Text = "Bark";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 158);
            label8.Name = "label8";
            label8.Size = new Size(75, 31);
            label8.TabIndex = 9;
            label8.Text = "Sleep";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 238);
            label9.Name = "label9";
            label9.Size = new Size(50, 31);
            label9.TabIndex = 10;
            label9.Text = "Eat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
