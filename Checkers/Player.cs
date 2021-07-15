using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Player
    {
        public string name;
        public string team;
        int x1, y1, x2, y2;
        internal bool MakeMove(ref CheckersBoard board)
        {
            Console.WriteLine("Игрок {0} из команды {1} - твой ход",name,team);
            Console.WriteLine("Введите имя выбранной шашки");
            name = Console.ReadLine();

            if (CheckName(name) == true)
                Console.WriteLine("URA!");
            else
                Console.WriteLine("Cringe");



           /* if (board.AvailableToMove() != true)
            {
                Console.WriteLine("Выбранная шашка не может ходить/есть");
                return false;
            } */











            return true;
        }


     /*   private int GetXNumber(char letter)
        {
            int X;
            switch (letter)
            {
                case "a":
                    X = 1;
                    return X;
                case "b":
                    X = 2;
                    return X;
                case "c":
                    X = 3;
                    return X;
                case "d":
                    X = 4;
                    return X;
                case "e":
                    X = 5;
                    return X;
                case "f":
                    X = 6;
                    return X;
                case "g":
                    X = 7;
                    return X;
                case "h":
                    X = 8;
                    return X;
                default:
                    X = 0;
                    return X;
            }

            


        }*/
    }
}
