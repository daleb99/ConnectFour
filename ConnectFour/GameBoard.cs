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
    public partial class GameBoard : Form
    {
        Button[] selection = new Button[7]; // Stores the buttons used to select player turn
        Button[,] gameGrid = new Button[7, 6]; // Stores the buttons used to represent the grid
        Player p1, p2; // References to two players
        Player currentPlayer; // Object for current player who is playing their shot
        
        public GameBoard()
        {
            InitializeComponent();
        }

        // Construct the board and place players inside
        public GameBoard(Player player1, Player player2)
        {
            p1 = player1;
            p2 = player2;
            currentPlayer = p1;
            InitializeComponent();
        }

        /*
         * Method to create the game board for Connnect Four
         * 
         * Consists of 7 buttons along the top for players to select where to 
         * place their disk. There is then a 7 x 6 grid where the game is played.
         * 
         */
        public void createBoard()
        {
            if (currentPlayer == p1)
            {
                LblName.Text = p1.getPlayerName();
                LblName.ForeColor = Color.Orange;
            } else if (currentPlayer == p2)
            {
                LblName.Text = p2.getPlayerName();
                LblName.ForeColor = Color.Red;
            }
            
            // Add the buttons to take a turn
            for (int x = 0; x < selection.Length; x++)
            {
                // Set button properties for selection
                selection[x] = new Button();
                selection[x].SetBounds(60 + 60 * x, 120 + selection.Length, 45, 45);
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
                    gameGrid[i, j].SetBounds(60 + 60 * i, 180 + 60 * j, 45, 45);
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
            bool gameIsWon = false;
            Player winner = null;

            // Disable buttons for the time of animation
            for (int i = 0; i < selection.GetLength(0); i++)
            {
                selection[i].Enabled = false;
            }

            // Set the colour of the squares accordig to user choice
            while (row < gameGrid.GetLength(1) && gameGrid[column, row].BackColor == Color.White)
            {
                // Set player 1 color to Orange
                if (currentPlayer == p1)
                {
                    gameGrid[column, row].BackColor = Color.Orange;
                }
                // Set player 2 color to Red
                else if (currentPlayer == p2)
                {
                    gameGrid[column, row].BackColor = Color.Red;
                }
                wait(100);
                gameGrid[column, row].BackColor = Color.White;
                row++;
            }

            if (row != 0)
            {
                if (currentPlayer == p1)
                {
                    gameGrid[column, row - 1].BackColor = Color.Orange;
                    currentPlayer = p2;
                }
                else if (currentPlayer == p2)
                {
                    gameGrid[column, row - 1].BackColor = Color.Red;
                    currentPlayer = p1;
                }
            }

            // Check for horizontal win
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x + 1, y].BackColor == Color.Orange &&
                        gameGrid[x + 2, y].BackColor == Color.Orange &&
                        gameGrid[x + 3, y].BackColor == Color.Orange)
                    {
                        gameIsWon = true;
                        winner = p1;
                    }
                    else if (gameGrid[x, y].BackColor == Color.Red &&
                        gameGrid[x + 1, y].BackColor == Color.Red &&
                        gameGrid[x + 2, y].BackColor == Color.Red &&
                        gameGrid[x + 3, y].BackColor == Color.Red)
                    {
                        gameIsWon = true;
                        winner = p2;
                    }
                }
            }

            // Check for vertical win
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x, y + 1].BackColor == Color.Orange &&
                        gameGrid[x, y + 2].BackColor == Color.Orange &&
                        gameGrid[x, y + 3].BackColor == Color.Orange)
                    {
                        gameIsWon = true;
                        winner = p1;
                    }
                    else if (gameGrid[x, y].BackColor == Color.Red &&
                        gameGrid[x, y + 1].BackColor == Color.Red &&
                        gameGrid[x, y + 2].BackColor == Color.Red &&
                        gameGrid[x, y + 3].BackColor == Color.Red)
                    {
                        gameIsWon = true;
                        winner = p2;
                    }
                }
            }

            // Check for diagonal descending win
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x + 1, y + 1].BackColor == Color.Orange &&
                        gameGrid[x + 2, y + 2].BackColor == Color.Orange &&
                        gameGrid[x + 3, y + 3].BackColor == Color.Orange)
                    {
                        gameIsWon = true;
                        winner = p1;
                    }
                    else if (gameGrid[x, y].BackColor == Color.Red &&
                        gameGrid[x + 1, y + 1].BackColor == Color.Red &&
                        gameGrid[x + 2, y + 2].BackColor == Color.Red &&
                        gameGrid[x + 3, y + 3].BackColor == Color.Red)
                    {
                        gameIsWon = true;
                        winner = p2;
                    }
                }
            }

            // Check for diagonal ascending win
            for (int x = 0; x < 4; x++)
            {
                for (int y = 5; y > 2; y--)
                {
                    if (gameGrid[x, y].BackColor == Color.Orange &&
                        gameGrid[x + 1, y - 1].BackColor == Color.Orange &&
                        gameGrid[x + 2, y - 2].BackColor == Color.Orange &&
                        gameGrid[x + 3, y - 3].BackColor == Color.Orange)
                    {
                        gameIsWon = true;
                        winner = p1;
                    }
                    else if (gameGrid[x, y].BackColor == Color.Red &&
                        gameGrid[x + 1, y - 1].BackColor == Color.Red &&
                        gameGrid[x + 2, y - 2].BackColor == Color.Red &&
                        gameGrid[x + 3, y - 3].BackColor == Color.Red)
                    {
                        gameIsWon = true;
                        winner = p2;
                    }
                }
            }

            // Display end game
            if (gameIsWon)
            {
                MessageBox.Show(winner.getPlayerName() + " won!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                EndGame end = new EndGame();
                end.Show();
            }

            // Enable buttons after player's move
            for (int i = 0; i < selection.GetLength(0); i++)
            {
                selection[i].Enabled = true;
            }

            // Change the text for the Current Player
            changePlayerBoard();
        }

        public void changePlayerBoard()
        {
            if (currentPlayer == p1)
            {
                LblName.ForeColor = Color.Orange;
                LblName.Text = p1.getPlayerName();
            }
            else if (currentPlayer == p2)
            {
                LblName.ForeColor = Color.Red;
                LblName.Text = p2.getPlayerName();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**
         * Timer function  https://stackoverflow.com/questions/10458118/wait-one-second-in-running-program
        */
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
