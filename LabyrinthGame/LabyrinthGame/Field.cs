using System;
using System.Collections.Generic;
using System.Text;

namespace LabyrinthGame
{
    class Field
    {

        public static bool exit = false;


        public int rowLength = array.GetLength(0);
        public int colLength = array.GetLength(1);

       /* public void StartPrintField()
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(array[i, j].Shape);
                }
                Console.Write(Environment.NewLine);
            }
             for (int i = 0; i < rowLength; i++)
             {
                 for (int j = 0; j < colLength; j++)
                 {
                     if(i==1 && j == 1)
                     {
                         array[i, j] = person;
                         Console.Write(array[i, j].Shape);
                     }
                     else if(i== 0 || i == rowLength-1 || j == 0 || j == colLength-1)
                     {
                         array[i, j] = wall;
                         Console.Write(array[i, j].Shape);
                     }
                     else
                     {
                         array[i, j] = empty;
                         Console.Write(array[i, j].Shape);
                     }
                 }
                 Console.Write(Environment.NewLine);
             }
        }*/

        public void PrintField() { 
            
            for(int i = 0; i < rowLength; i++)
            {
                for(int j = 0; j < colLength; j++)
                {
                    Console.Write(array[i, j].Shape);
                }
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine("");
            Console.WriteLine("Press W to go up...............O - this is a player");
            Console.WriteLine("");
            Console.WriteLine("Press D to go right............# - this is a wall");
            Console.WriteLine("");
            Console.WriteLine("Press S to go down.............A - this is a door");
            Console.WriteLine("");
            Console.WriteLine("Press A to go Left.............a this is a key for a door");
            Console.WriteLine("");
            Console.WriteLine("Press esc to exit (YOU WILL LOSE!)");

        }

        static Cell w = new Cell("wall");
        static Cell d = new Cell("door");
        static Cell k = new Cell("key");
        static Cell p = new Cell("person");
        static Cell e = new Cell("empty");
        static Cell f = new Cell("finish");

        public static Cell[,] array = new Cell[10, 20]
       {
            {w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w},
            {w, p, e, e, e, e, e, e, e, w, e, e, e, e, e, e, w, e, w, w},
            {w, e, e, w, e, w, e, e, e, e, w, e, w, e, w, e, w, e, e, w},
            {w, e, e, w, w, w, w, e, w, e, e, w, e, e, e, e, w, w, w, w},
            {w, e, e, w, e, e, w, e, e, e, w, e, w, w, e, w, e, e, w, w},
            {w, w, e, w, w, e, e, e, e, e, e, e, e, d, e, w, e, w, e, w},
            {w, e, e, e, w, w, w, e, w, e, w, e, w, e, e, e, w, w, w, w},
            {w, e, w, w, w, e, e, e, w, e, w, w, w, w, e, w, e, w, e, w},
            {w, e, e, e, e, w, k, w, w, e, e, w, e, e, e, e, e, e, e, f},
            {w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w, w},
       };
    }
    struct Cell
    {
        public string Shape;
        public string Type;

        public Cell(string type)
        {
            this.Type = type;
            if (type == "wall") { this.Shape = "#"; }
            else if (type == "door") { this.Shape = "A"; }
            else if (type == "key") { this.Shape = "a"; }
            else if (type == "person") { this.Shape = "o"; }
            else if (type == "finish") { this.Shape = "=>"; }
            else this.Shape = " ";
        }


    }

}
