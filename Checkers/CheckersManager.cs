using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class CheckersManager
    {
        CheckersBoard board;
        Player player1 = new Player();
        Player player2 = new Player();
        Player currentPlayer;
        public void Init()
        {
            Console.WriteLine("Введите имя, игрок команды белых");
            player1.name = Console.ReadLine();
            player1.team = "white";
            Console.WriteLine("Введите имя, игрок команды черных");
            player2.name = Console.ReadLine();
            player2.team = "black";
            board = new CheckersBoard();
            currentPlayer = player1;
        }

        public void MakeMove()
        {
            while (!currentPlayer.MakeMove(ref board))
            {
                Console.WriteLine("try again");
                board.ShowBoard();
            }

            currentPlayer = (currentPlayer == player1) ? player2 : player1;

        }




    }
}
