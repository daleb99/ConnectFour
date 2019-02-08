using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Player
    {
        private int playerID;
        private string playerName;
        private bool isWinner;

        public Player()
        {
            playerID = 0;
            playerName = "";
            isWinner = false;
        }

        public Player(string name)
        {
            playerID = 0;
            playerName = name;
            isWinner = false;
        }

        public int getPlayerID()
        {
            return playerID;
        }

        public void setPlayerID(int playerID)
        {
            this.playerID = playerID;
        }

        public string getPlayerName()
        {
            return playerName;
        }
        
        public void setPlayerName(string playerName)
        {
            this.playerName = playerName;
        }

        public bool getIsWinner()
        {
            return isWinner;
        }

        public void setIsWinner(bool isWinner)
        {
            this.isWinner = isWinner;
        }
    }
}
