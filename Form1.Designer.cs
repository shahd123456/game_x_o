namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            button10 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            cputimer = new System.Windows.Forms.Timer(components);
            button11 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 0;
            label1.Text = "player win : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(353, 18);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 1;
            label2.Text = "cpu win :";
            label2.Click += label2_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(71, 361);
            button10.Name = "button10";
            button10.Size = new Size(229, 58);
            button10.TabIndex = 11;
            button10.Text = "Resat Game ";
            button10.UseVisualStyleBackColor = false;
            button10.Click += Restgame;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(40, 64);
            button1.Name = "button1";
            button1.Size = new Size(127, 87);
            button1.TabIndex = 12;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerclickbutton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(173, 64);
            button2.Name = "button2";
            button2.Size = new Size(127, 87);
            button2.TabIndex = 13;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerclickbutton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(309, 64);
            button3.Name = "button3";
            button3.Size = new Size(127, 87);
            button3.TabIndex = 14;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerclickbutton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(309, 157);
            button4.Name = "button4";
            button4.Size = new Size(127, 87);
            button4.TabIndex = 17;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerclickbutton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(173, 157);
            button5.Name = "button5";
            button5.Size = new Size(127, 87);
            button5.TabIndex = 16;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerclickbutton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(40, 157);
            button6.Name = "button6";
            button6.Size = new Size(127, 87);
            button6.TabIndex = 15;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerclickbutton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(309, 250);
            button7.Name = "button7";
            button7.Size = new Size(127, 87);
            button7.TabIndex = 20;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerclickbutton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(173, 250);
            button8.Name = "button8";
            button8.Size = new Size(127, 87);
            button8.TabIndex = 19;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerclickbutton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(40, 250);
            button9.Name = "button9";
            button9.Size = new Size(127, 87);
            button9.TabIndex = 18;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerclickbutton;
            // 
            // cputimer
            // 
            cputimer.Interval = 1000;
            cputimer.Tick += cpumove;
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(326, 370);
            button11.Name = "button11";
            button11.Size = new Size(110, 49);
            button11.TabIndex = 21;
            button11.Text = "Back";
            button11.UseVisualStyleBackColor = false;
            button11.Click += NAV3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(182, 18);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 22;
            label3.Text = "High score :";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 453);
            Controls.Add(label3);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button10);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "x_o_game ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private System.Windows.Forms.Timer cputimer;
        private Button button11;
        private Label label3;
    }
}
