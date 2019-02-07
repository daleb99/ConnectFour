using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class Form1 : Form
    {
        Button[] selection = new Button[7]; // Stores the buttons used to select player turn
        Button[,] gameGrid = new Button[7, 6]; // Stores the buttons used to represent the grid
        int currPlayer = 0;
        public Form1()
        {
            InitializeComponent();
            playGame();
        }

        /*
         * Method to create the game board for Connnect Four
         * 
         * Consists of 7 buttons along the top for players to select where to 
         * place their disk. There is then a 7 x 6 grid where the game is played.
         * 
         */
        private void createBoard()
        {
            // Add the buttons to take a turn
            for (int x = 0; x < selection.Length; x++)
            {
                // Set button properties for selection
                selection[x] = new Button();
                selection[x].SetBounds(60 + 60 * x, 60 + selection.Length, 45, 45);
                selection[x].BackColor = Color.Gray;
                selection[x].Text = Convert.ToString(x + 1);

                // Add Event Handler to the button
                selection[x].Click += new EventHandler(this.btnEvent_Click);

                // Add button to the GUI
                Controls.Add(selection[x]);
            }

            // Add the buttons that will be used as the grid for the game
            // No Event Handler is required as buttons are for graphical
            // requirements.
            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    // Set button properties for board
                    gameGrid[i, j] = new Button();
                    gameGrid[i, j].SetBounds(60 + 60 * i, 120 + 60 * j, 45, 45);
                    gameGrid[i, j].BackColor = Color.White;

                    // Add buttons to the GUI
                    Controls.Add(gameGrid[i, j]);
                }
            }
        }

        /*
         * Event Handler for the control buttons at the top to add the players
         * selected column to play their shot.
         * 
         * The event handler then simulates a dropping motion by changing the color
         * of the tiles as the disk falls.
         */
        void btnEvent_Click(object sender, EventArgs e) //Event Handler for buttons
        {
            int column = Convert.ToInt32(((Button)sender).Text) - 1;
            int row = 0;
            bool won = false;
            int winner = 0;
        

                while (row < gameGrid.GetLength(1) && gameGrid[column, row].BackColor == Color.White)
                {
                    if (currPlayer == 1)
                    {
                        gameGrid[column, row].BackColor = Color.Orange;
                    }
                    else
                    {
                        gameGrid[column, row].BackColor = Color.Red;
                    }
                    wait(100);
                    gameGrid[column, row].BackColor = Color.White;
                    row++;
                }
            if (row != 0)
            {
                if (currPlayer == 1)
                {
                    //MessageBox.Show("Player 1's Turn!", "Connect Four", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gameGrid[column, row - 1].BackColor = Color.Orange;
                    LblCurrentPlayer.Text = "Current Player: 1";
                    currPlayer = 2;
                }
                else
                {
                    //MessageBox.Show("Player 2's Turn!", "Connect Four", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gameGrid[column, row - 1].BackColor = Color.Red;
                    LblCurrentPlayer.Text = "Current Player: 2";
                    currPlayer = 1;
                }
            }

            //check for horizontal win
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x + 1, y].BackColor == Color.Orange &&
                        gameGrid[x + 2, y].BackColor == Color.Orange &&
                        gameGrid[x + 3, y].BackColor == Color.Orange)
                    {
                        won = true;
                        winner = 1;
                        MessageBox.Show("you won", "winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            //check for vertical win
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x, y + 1].BackColor == Color.Orange &&
                        gameGrid[x, y + 2].BackColor == Color.Orange &&
                        gameGrid[x, y + 3].BackColor == Color.Orange)
                    {
                        won = true;
                        winner = 1;
                        MessageBox.Show("you won", "winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            //check for diagonal descending win
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x + 1, y + 1].BackColor == Color.Orange &&
                        gameGrid[x + 2, y + 2].BackColor == Color.Orange &&
                        gameGrid[x + 3, y + 3].BackColor == Color.Orange)
                    {
                        won = true;
                        winner = 1;
                        MessageBox.Show("you won", "winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            //check for diagonal ascending win
            for (int x = 0; x < 4; x++)
            {
                for (int y = 5; y > 2; y--)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x + 1, y - 1].BackColor == Color.Orange &&
                        gameGrid[x + 2, y - 2].BackColor == Color.Orange &&
                        gameGrid[x + 3, y - 3].BackColor == Color.Orange)
                    {
                        won = true;
                        winner = 1;
                        MessageBox.Show("you won", "winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

            
            }
        


        /*
         * Function to calculate whether there is a winner yet.
         */
        private bool playGame()
        {
            createBoard();

            bool won = false;
            //MessageBox.Show("Welcome to Connect Four - Click OK to begin!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LblCurrentPlayer.Text = "Current Player: 1";
            currPlayer = 1;

            if (gameGrid[0, 5].BackColor == Color.Red)
            {
                MessageBox.Show("The element at X = 1 and Y = 7 is RED", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (gameGrid[0, 5].BackColor == Color.Orange)
            {
                MessageBox.Show("The element at X = 1 and Y = 7 is ORANGE", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return won;
        }


        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connect4 Game", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Timer function  https://stackoverflow.com/questions/10458118/wait-one-second-in-running-program
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
