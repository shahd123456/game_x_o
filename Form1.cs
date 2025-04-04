using System.Data.SqlTypes;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        public enum player
        {
            x, o // two  player o , x 
        }

        player currentplayer;
        Random Random = new Random();
        int cpuwincount = 0;
        int playerwincount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();// Initialize components of the form
            Restartgame();
            UpdateHighScore();
            writeinfile();

        }



        private void label1_Click(object sender, EventArgs e) // lable player handler event 
        {

        }

        private void label2_Click(object sender, EventArgs e) // lable cpu handler event 
        {

        }

        private void cpumove(object sender, EventArgs e)
        {
            if (buttons.Count > 0) // check availabe buttons
            {
                int index = Random.Next(buttons.Count); // select random
                Button selectedButton = buttons[index]; // gey the butoom from list 

                selectedButton.Enabled = false; // display button 
                currentplayer = player.o; // set cpu o 
                selectedButton.Text = currentplayer.ToString(); // set buuton to text o
                selectedButton.BackColor = Color.DarkSalmon; // changr background

                buttons.RemoveAt(index); // remaove select button form list 
                cheackgame(); // checkgame 
                cputimer.Stop(); // stop cpu move timer 
            }
        }

        private void playerclickbutton(object sender, EventArgs e)
        {
            var button = (Button)sender; //click button
            currentplayer = player.x; // set player x 
            button.Text = currentplayer.ToString(); // sey button text to x 
            button.Enabled = false; // display button 
            button.BackColor = Color.Cyan; // changr color 
            buttons.Remove(button); // remove button from list 
            cheackgame(); // check game 
            cputimer.Start(); // start cpu to think to play 
        }

        private void Restgame(object sender, EventArgs e) // event handler 
        {
            Restartgame();

        }

        private void cheackgame()
        {
            // Winning conditions for Player X
            if ((button1.Text == "x" && button2.Text == "x" && button3.Text == "x") ||
                (button4.Text == "x" && button5.Text == "x" && button6.Text == "x") ||
                (button7.Text == "x" && button8.Text == "x" && button9.Text == "x") ||
                (button1.Text == "x" && button6.Text == "x" && button9.Text == "x") ||
                (button2.Text == "x" && button5.Text == "x" && button8.Text == "x") ||
                (button3.Text == "x" && button4.Text == "x" && button7.Text == "x") ||
                (button1.Text == "x" && button5.Text == "x" && button7.Text == "x") ||
                (button3.Text == "x" && button5.Text == "x" && button9.Text == "x"))
            {
                cputimer.Stop(); // cpu stop timer to play 
                MessageBox.Show("Player Wins!", "Game Over"); // message when player x win 
                playerwincount++; //   increase count score win 
                label1.Text = "Player Wins: " + playerwincount; // edit on label player win 
                Restartgame(); // restart game 
                writeinfile();
                return;
            }

            // Winning conditions for CPU (Player O)
            if ((button1.Text == "o" && button2.Text == "o" && button3.Text == "o") ||
                (button4.Text == "o" && button5.Text == "o" && button6.Text == "o") ||
                (button7.Text == "o" && button8.Text == "o" && button9.Text == "o") ||
                (button1.Text == "o" && button6.Text == "o" && button9.Text == "o") ||
                (button2.Text == "o" && button5.Text == "o" && button8.Text == "o") ||
                (button3.Text == "o" && button4.Text == "o" && button7.Text == "o") ||
                (button1.Text == "o" && button5.Text == "o" && button7.Text == "o") ||
                (button3.Text == "o" && button5.Text == "o" && button9.Text == "o"))
            {
                cputimer.Stop();
                MessageBox.Show("CPU Wins!", "Game Over");
                cpuwincount++;
                label2.Text = "CPU Wins: " + cpuwincount;
                Restartgame();
                writeinfile();
                return;

            }

            // Check for a draw condition (all buttons are disabled)
            if (buttons.All(b => !b.Enabled))
            {
                cputimer.Stop(); // cpu timer stop to move 
                MessageBox.Show("It's a Draw!", "Game Over"); // message all button disable and no onw win 
                Restartgame();
            }
        }


        private void Restartgame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons) // Iterate over all buttons
            {
                x.Enabled = true; // enable buttons 
                x.Text = "X/O";   // Reset the button text
                x.BackColor = DefaultBackColor;
            }

            currentplayer = player.x; // Set the starting player to Player X
        }
        private void NAV3(object sender, EventArgs e) // Method to navigate to another form (Form3)
        {
            this.Hide(); // Hide the current form
            Form3 f3 = new Form3(); // Create a new instance of Form3
            f3.Show();// Show Form3
        }
        private void writeinfile()
        {
            // define file path 
            string path = "output.txt";
            // using stream write to write in file 
            using (StreamWriter writer = new StreamWriter(path))
            { // write in fike el scores 
                writer.WriteLine("Player Wins: " + playerwincount);
                writer.WriteLine("CPU Player Wins: " + cpuwincount);
            } // message box eno written in file 
            MessageBox.Show("Wins have been written to " + path, "Success",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // image of the back ground import 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void UpdateHighScore()
        {
            // define file path 
            string path = "output.txt";
            // Check if the file exists before attempting to read it
            if (File.Exists(path))
            {
                try
                {// read all line in string arrary 
                    string[] lines = File.ReadAllLines(path);
                    foreach (string line in lines) // Iterate through each line to find the player's win count
                    {
                        if (line.StartsWith("Player Wins :"))
                        {// Extract the win count value from the line
                            //The .Length property calculates the number of characters in the string
                            //The Substring() method extracts a portion of the string starting at the specified startIndex
                            // startIndex is the position (zero - based index) where the substring extraction begins.
                            string winsString = line.Substring("Player Wins:".Length);
                            // Attempt to parse the extracted value into an integer
                            if (int.TryParse(winsString, out int playerWins))
                            {
                                // Update the label to display the high score
                                label3.Text = "High Score: " + playerWins;
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                { // Display an error message if there is an issue reading the file
                    MessageBox.Show("Error reading file: " + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
         // label dislay high score 
        private void label3_Click(object sender, EventArgs e)
        {
            UpdateHighScore();
        }
    }
}

 