namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            button11 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 72);
            button1.Name = "button1";
            button1.Size = new Size(94, 92);
            button1.TabIndex = 0;
            button1.Text = "X/O";
            button1.UseVisualStyleBackColor = true;
            button1.Click += chooseone;
            // 
            // button2
            // 
            button2.Location = new Point(188, 72);
            button2.Name = "button2";
            button2.Size = new Size(94, 92);
            button2.TabIndex = 1;
            button2.Text = "X/O";
            button2.UseVisualStyleBackColor = true;
            button2.Click += chooseone;
            // 
            // button3
            // 
            button3.Location = new Point(309, 72);
            button3.Name = "button3";
            button3.Size = new Size(94, 92);
            button3.TabIndex = 2;
            button3.Text = "X/O";
            button3.UseVisualStyleBackColor = true;
            button3.Click += chooseone;
            // 
            // button4
            // 
            button4.Location = new Point(309, 174);
            button4.Name = "button4";
            button4.Size = new Size(94, 92);
            button4.TabIndex = 5;
            button4.Text = "X/O";
            button4.UseVisualStyleBackColor = true;
            button4.Click += chooseone;
            // 
            // button5
            // 
            button5.Location = new Point(188, 170);
            button5.Name = "button5";
            button5.Size = new Size(94, 92);
            button5.TabIndex = 4;
            button5.Text = "X/O";
            button5.UseVisualStyleBackColor = true;
            button5.Click += chooseone;
            // 
            // button6
            // 
            button6.Location = new Point(68, 174);
            button6.Name = "button6";
            button6.Size = new Size(94, 92);
            button6.TabIndex = 3;
            button6.Text = "X/O";
            button6.UseVisualStyleBackColor = true;
            button6.Click += chooseone;
            // 
            // button7
            // 
            button7.Location = new Point(309, 281);
            button7.Name = "button7";
            button7.Size = new Size(94, 92);
            button7.TabIndex = 8;
            button7.Text = "X/O";
            button7.UseVisualStyleBackColor = true;
            button7.Click += chooseone;
            // 
            // button8
            // 
            button8.Location = new Point(188, 281);
            button8.Name = "button8";
            button8.Size = new Size(94, 92);
            button8.TabIndex = 7;
            button8.Text = "X/O";
            button8.UseVisualStyleBackColor = true;
            button8.Click += chooseone;
            // 
            // button9
            // 
            button9.Location = new Point(68, 281);
            button9.Name = "button9";
            button9.Size = new Size(94, 92);
            button9.TabIndex = 6;
            button9.Text = "X/O";
            button9.UseVisualStyleBackColor = true;
            button9.Click += chooseone;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.Location = new Point(145, 396);
            button10.Name = "button10";
            button10.Size = new Size(195, 45);
            button10.TabIndex = 9;
            button10.Text = "RestartGame";
            button10.UseVisualStyleBackColor = false;
            button10.Click += resetgame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 31);
            label1.TabIndex = 10;
            label1.Text = "player one :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(327, 20);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 11;
            label2.Text = "player two :";
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.Location = new Point(384, 403);
            button11.Name = "button11";
            button11.Size = new Size(132, 30);
            button11.TabIndex = 12;
            button11.Text = "Back";
            button11.UseVisualStyleBackColor = false;
            button11.Click += nav4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(418, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 31);
            label3.TabIndex = 13;
            label3.Text = "wins:";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(549, 453);
            Controls.Add(label3);
            Controls.Add(button11);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Label label2;
        private Button button11;
        private Label label3;
    }
}