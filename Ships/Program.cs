using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;





namespace Ships
{
    class Program
    {

      
      

        static void Main(string[] args)
        {
            //List <List<char>> gameBoard = new List<List<char>>();

            List<Ship> allShips = new List<Ship>() { new Ship(1, 2, "DD"), new Ship(2, 3, "DD"), new Ship(3, 4, "DD") };

         

            int size = 10;

            char[,] gameBoard = new Char[size, size];


            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    gameBoard[j, i] = (char)OccupationType.Empty;
                }
            }


          


            bool run = true;

            while( run ) 
            {

                Console.Clear();

                generateGameBoard(gameBoard);

                Console.WriteLine("Zadej x,y,M,X - X JE HIT, M JE MISS");

                string souradnice = Console.ReadLine();

                string[] strela = souradnice.Split(',').ToArray();

                gameBoard[int.Parse(strela[0])-1 , int.Parse(strela[1])-1] = char.Parse(strela[2]);

            }






        }

        public enum OccupationType
        {
            Empty = '+',

            Battleship = 'B',

            Cruiser = 'C',

            Destroyer = 'D',

            Submarine = 'S',

            Carrier = 'A',

            Hit = 'X',

            Miss = 'M'
        }


        public static void generateGameBoard(char[,] gameBoard)
        {

            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = -1; i < gameBoard.GetLength(0); i++)
            {
              

                string rtn = (i > -1) ? alpha[i].ToString() + "|" : "_|";
                 
                for (int j = 1; j <= gameBoard.GetLength(1); j++)
                {

                    if (i > -1)
                    {
                        rtn = rtn + " " + gameBoard[i, j-1].ToString() + " ";
                    }else{
                        rtn = (i > 0) ? rtn + " " + gameBoard[i, j - 1].ToString() + " " : (j.ToString().Length>1) ? rtn + " " + j:  rtn + " " + j + " ";
                    }
                   


                }

                rtn = rtn + "|";

                Console.WriteLine(rtn);
            }
        }



    }
}
