using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    
    class CheckersBoard
    {
        Cell[] cells = new Cell[32];
        Cell[] GoldWay=new Cell[8];
        Cell[] DoubleWay_b1h7 = new Cell[7];
        Cell[] DoubleWay_a2g8 = new Cell[7];
        Cell[] TripleWay_f1h3 = new Cell[3];
        Cell[] TripleWay_a6c8 = new Cell[3];
        Cell[] TripleWay_f1a6 = new Cell[6];
        Cell[] TripleWay_h3c8 = new Cell[6];
        Cell[] UltraWay_d1h5 = new Cell[5];
        Cell[] UltraWay_a4e8 = new Cell[5];
        Cell[] UltraWay_d1a4 = new Cell[5];
        Cell[] UltraWay_h5e8 = new Cell[5];


        public CheckersBoard()
        {
            CreateCells();
            CreateWays();
            ShowBoard();
            

        }


        



        void CreateCells()
        {
            int k = 0;//счётчик для клеток
            for (int i = 0; i < 32; i++)
            {
                cells[i] = new Cell();
            }

            for (int y = 8; y >0; y--)
            {
                for (int x = 8; x > 0; x--)
                {
                    if ((y == 1 || y == 3) && (x == 2 || x == 4 || x == 6 || x == 8))
                    {
                        cells[k].Color = "white";
                        cells[k].Name = GetXLetter(x) + y;
                        cells[k].x = x;
                        cells[k].y = y;
                        
                        Console.Write(k +"_"+ cells[k].Name + " ");
                        k++;
                    }
                    if (y == 2 && (x == 1 || x == 3 || x == 5 || x == 7))
                    {
                        cells[k].Color = "white";
                        cells[k].Name = GetXLetter(x) + y;
                        cells[k].x = x;
                        cells[k].y = y;

                        Console.Write(k + "_" + cells[k].Name + " ");
                        k++;
                    }
                    if (y == 4 && (x == 1 || x == 3 || x == 5 || x == 7))
                    {
                        cells[k].Color = "empty";
                        cells[k].Name = GetXLetter(x) + y;
                        cells[k].x = x;
                        cells[k].y = y;

                        Console.Write(k + "_" + cells[k].Name + " ");
                        k++;
                    }
                    if (y == 5 && (x == 2 || x == 4 || x == 6 || x == 8))
                    {
                        cells[k].Color = "empty";
                        cells[k].Name = GetXLetter(x) + y;
                        cells[k].x = x;
                        cells[k].y = y;

                        Console.Write(k + "_" + cells[k].Name + " ");
                        k++;
                    }
                    if ((y == 6 || y == 8) && (x == 1 || x == 3 || x == 5 || x == 7))
                    {
                        cells[k].Color = "black";
                        cells[k].Name = GetXLetter(x) + y;
                        cells[k].x = x;
                        cells[k].y = y;

                        Console.Write(k + "_" + cells[k].Name + " ");
                        k++;
                    }
                    if (y == 7 && (x == 2 || x == 4 || x == 6 || x == 8))
                    {
                        cells[k].Color = "black";
                        cells[k].Name = GetXLetter(x) + y;
                        cells[k].x = x;
                        cells[k].y = y;

                        Console.Write(k + "_" + cells[k].Name + " ");
                        k++;
                    }
                    
                }
                Console.WriteLine("\n");
            }
           

          
            
        }
        string GetXLetter(int x)
        {
            string letter;
            switch (x)
            {
                case 1:
                    letter = "a";
                    break;
                case 2:
                    letter = "b";
                    break;
                case 3:
                    letter = "c";
                    break;
                case 4:
                    letter = "d";
                    break;
                case 5:
                    letter = "e";
                    break;
                case 6:
                    letter = "f";
                    break;
                case 7:
                    letter = "g";
                    break;
                case 8:
                    letter = "h";
                    break;
                default:
                    letter = "cringe";
                    break;
            }
            
            return letter;
        }
        public void ShowBoard()
        {
            Console.WriteLine("\n"+GetStringBoard());

        }

        string GetStringBoard()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" ");

            for (int x = 8; x > 0; x--)
            {
                builder.Append(GetXLetter(x));
            }

            builder.Append("\n");

            for (int y = 8; y > 0; y--)
            {
                builder.Append(y);
                for (int x = 8; x > 0; x--)
                {
                    
                    bool found = false;
                    foreach (Cell cell in cells)
                    {
                        if (cell.x == x && cell.y == y)
                        {
                            if (cell.Color == "white")
                            {
                                builder.Append("W");
                                
                                found = true;
                                
                            }
                            if (cell.Color == "black")
                            {
                                builder.Append("B");

                                found = true;
                                
                            }
                            if (cell.Color == "empty")//?????
                            {
                                
                                builder.Append('_');
                                found = true;
                                
                            }
                            
                        }
                       
                    }
                    if (found == false)
                    {
                        builder.Append('\u25A0');
                        
                    }



                }
                builder.Append("\n");
            } 
            return builder.ToString();
        }

        private void CreateWays()
        {
            GoldWay        = new Cell[] { cells[28],cells[24],cells[21],cells[17],cells[14],cells[10],cells[7],cells[3]}; //h1a8
            DoubleWay_b1h7 = new Cell[] { cells[31],cells[26],cells[22],cells[17],cells[13],cells[8],cells[4] };
            DoubleWay_a2g8 = new Cell[] { cells[27], cells[23], cells[18], cells[14], cells[9], cells[5], cells[0] };
            TripleWay_f1h3 = new Cell[] { cells[29], cells[24], cells[20] };
            TripleWay_a6c8 = new Cell[] { cells[11], cells[7], cells[2] };
            TripleWay_f1a6 = new Cell[] { cells[29], cells[25], cells[22], cells[18], cells[15], cells[11] };
            TripleWay_h3c8 = new Cell[] { cells[20], cells[16], cells[13], cells[9], cells[6], cells[2] };
            UltraWay_d1h5  = new Cell[] { cells[30], cells[25], cells[21], cells[16], cells[12] };
            UltraWay_a4e8  = new Cell[] { cells[19], cells[15], cells[10], cells[6], cells[1] };
            UltraWay_d1a4  = new Cell[] { cells[30], cells[26], cells[23], cells[19] };
            UltraWay_h5e8  = new Cell[] { cells[12], cells[8], cells[5], cells[1] };

            for (int i = 0;i<GoldWay.Length;i++)
            {
                GoldWay[i].IsGoldWay = true;
            }
            for (int i=0;i<DoubleWay_b1h7.Length;i++)
            {
                DoubleWay_b1h7[i].IsDoubleWay_b1h7 = true;
            }
            for (int i = 0; i < DoubleWay_a2g8.Length; i++)
            {
                DoubleWay_a2g8[i].IsDoubleWay_a2g8 = true;
            }
            for (int i=0;i<TripleWay_f1h3.Length;i++)
            {
                TripleWay_f1h3[i].IsTripleWay_f1h3 = true;
            }
            for (int i = 0; i < TripleWay_a6c8.Length; i++)
            {
                TripleWay_a6c8[i].IsTripleWay_a6c8 = true;
            }
            for (int i = 0; i < TripleWay_f1a6.Length; i++)
            {
                TripleWay_f1a6[i].IsTripleWay_f1a6 = true;
            }
            for (int i = 0; i < TripleWay_h3c8.Length; i++)
            {
                TripleWay_h3c8[i].IsTripleWay_h3c8 = true;
            }
            for (int i=0;i<UltraWay_d1h5.Length;i++)
            {
                UltraWay_d1h5[i].IsUltraWay_d1h5 = true;
            }
            for (int i = 0; i < UltraWay_a4e8.Length; i++)
            {
                UltraWay_a4e8[i].IsUltraWay_a4e8 = true;
            }
            for (int i = 0; i < UltraWay_d1a4.Length; i++)
            {
                UltraWay_d1a4[i].IsUltraWay_d1a4 = true;
            }
            for (int i = 0; i < UltraWay_h5e8.Length; i++)
            {
                UltraWay_h5e8[i].IsUltraWay_h5e8 = true;
            }

        }



    }
}
