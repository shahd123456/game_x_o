using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CPU_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; 

            if (clickedButton == SINGLE)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else if (clickedButton == CPU)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
