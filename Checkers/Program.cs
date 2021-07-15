using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckersManager manager=new CheckersManager();
            manager.Init();

            while (true)
            {
                manager.MakeMove();
            }





        }
    }
}
