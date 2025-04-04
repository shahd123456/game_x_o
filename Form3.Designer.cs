namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            CPU = new Button();
            SINGLE = new Button();
            SuspendLayout();
            // 
            // CPU
            // 
            CPU.BackColor = Color.Gold;
            CPU.Location = new Point(81, 447);
            CPU.Name = "CPU";
            CPU.Size = new Size(168, 54);
            CPU.TabIndex = 0;
            CPU.Text = "CPU";
            CPU.UseVisualStyleBackColor = false;
            CPU.Click += CPU_Click;
            // 
            // SINGLE
            // 
            SINGLE.BackColor = Color.Gold;
            SINGLE.Location = new Point(352, 447);
            SINGLE.Name = "SINGLE";
            SINGLE.Size = new Size(184, 54);
            SINGLE.TabIndex = 1;
            SINGLE.Text = "SINGLE";
            SINGLE.UseVisualStyleBackColor = false;
            SINGLE.Click += CPU_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(680, 513);
            Controls.Add(SINGLE);
            Controls.Add(CPU);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CPU;
        private Button SINGLE;
    }
}