using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class C4Game
    {
        Player p1, p2;
        GameBoard board;

       public C4Game()
        {
            p1 = new Player();
            p2 = new Player();
            board = new GameBoard();
        }

        public C4Game(string p1name, string p2name)
        {
            p1 = new Player(p1name);
            p2 = new Player(p2name);
            board = new GameBoard(p1,p2);
        }

        public void init()
        {
            board.Show();
            board.createBoard();
        }

    }
}
