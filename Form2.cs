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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();// Initialize components of the form
            resetgame();
            writeinfile();
            UpdateHighScore();
        }
        public enum player
        {
            X, O
        }
        player CURRENTPLAYER;
        int playerone = 0;
        int playertwo = 0;
        List<Button> buttons;

        private void CheckGame()
        {
            if (check_game(player.X))
            {
                MessageBox.Show("Player_X_win", "Dark_Warrior");
                playerone++;
                label1.Text = "Playerone Wins: " + playerone;
                resetgame();
                writeinfile();
                UpdateHighScore();

            }
            else if (check_game(player.O))
            {
                MessageBox.Show("Player_O_win", "Dark_Warrior");
                playertwo++;
                label2.Text = "Playertwo Wins: " + playertwo;
                resetgame();
                writeinfile();
                UpdateHighScore();

            }
            else if (buttons.Count == 0)
            {
                MessageBox.Show("It's a draw!", "Game Over");
                resetgame();
                writeinfile();
                UpdateHighScore();

            }
        }
        private bool check_game(player CURRENTPLAYER)
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
            button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
            button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
            button1.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
            button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
            button3.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
            button1.Text == "X" && button5.Text == "X" && button7.Text == "X" ||
            button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                return CURRENTPLAYER == player.X;
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text ==
           "O" ||
            button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
            button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
            button1.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
            button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
            button3.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
            button1.Text == "O" && button5.Text == "O" && button7.Text == "O" ||
            button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                return CURRENTPLAYER == player.O;
            }
            return false;
        }
        private void resetgame()
        {
            buttons = new List<Button>
         { button1, button2, button3 , button4, button5,button6, button7, button8, button9 }; // restart button 
            foreach (Button b in buttons)
            {
                b.Enabled = true; //enable button 
                b.Text = "X/O";
                b.BackColor = DefaultBackColor;
            }
        }

        private void resetgame(object sender, EventArgs e)
        {
            resetgame();
        }
        private void chooseone(object sender, EventArgs e)
        {
            var button = (Button)sender; // get button click 
            button.Enabled = false; // display button 
            if (CURRENTPLAYER == player.X) // player x now
            {
                button.Text = player.X.ToString(); // butten text to x
                button.BackColor = Color.Cyan;
            }
            else
            {// player o 
                button.Text = player.O.ToString(); // button text to o
                button.BackColor = Color.Pink;
            }
            buttons.Remove(button);
            CheckGame();
            SwitchPlayer();
        }
        private void SwitchPlayer()
        {
            CURRENTPLAYER = (CURRENTPLAYER == player.X) ? player.O : player.X; // player play x the onther player play o
        }
        private void Form2_Load(object sender, EventArgs e) // handeler for form2 
        {

        }
        private void nav4(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) // handler for PictureBox click
        {
        }
        private void writeinfile()
        {
            // define file 
            string path = "output.txt";
            //Calculate the high score
            int highScore = Math.Max(playerone, playertwo);
            // Use StreamWriter to write in file 
            using (StreamWriter writer = new StreamWriter(path))
            { // write in file this name 
                writer.WriteLine("Player one Wins: " + playerone);
                writer.WriteLine("Player two Wins: " + playertwo);
                writer.WriteLine("High Score: " + highScore); // Write the high score
            }// tell me the file is written done 
            MessageBox.Show("Wins and High Score have been written to " + path, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void UpdateHighScore()
        { // define file 
            string path = "output.txt";
            // Check if the file exists to avoid errors when trying to read it
            if (File.Exists(path))
            {
                try
                {// read all line in string arrary 
                    string[] lines = File.ReadAllLines(path);
                    foreach (string line in lines)  // Iterate through each line to find the high score
                    {
                        if (line.StartsWith("High Score:"))
                        {
                            // Extract the high score value from the line
                           // trim () removes all leading and trailing white-space characters from the current string object
                            string highScoreString = line.Substring("High Score:".Length).Trim();
                            // Attempt to parse the extracted value into an integer
                            if (int.TryParse(highScoreString, out int highScore))
                            {
                                // Update the label to display the high score
                                label3.Text = "High Score: " + highScore;
                                return; // Exit after finding the high score
                            }
                        }
                    }
                }
                // Display an error message if there is an issue reading the file
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            writeinfile();
            UpdateHighScore();
        }
    }
}
    
