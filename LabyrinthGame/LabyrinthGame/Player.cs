using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LabyrinthGame
{
    class Player
    {
        public int x;
        public int y;
        int rowLength = Field.array.GetLength(0);
        int colLength = Field.array.GetLength(1); 


        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        Cell person = new Cell("person", "o");
        Cell empty = new Cell("empty", " ");
      
        public void MoveRight()
        {
           if (y == colLength - 2)
            {
                Program.Finish();
                Program.exit = true;
                return;
            }
            if (Field.array[x, y + 1].Type == "finish")
            {
                y++;
                Field.array[x, y] = person;
                Field.array[x, y - 1] = empty;
                
            }
            if (Field.array[x, y + 1].Type == "key")
            {
                string key = Field.array[x, y + 1].Shape;

                keySound();
                y++;
                Field.array[x, y] = person;
                Field.array[x, y - 1] = empty;
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (Field.array[i, j] is Door element && element.Key == key)
                        {
                            Field.array[i, j] = empty;
                        }
                    }
                }
            }
            if (Field.array[x, y + 1].Type != "wall" && Field.array[x, y + 1].Type != "door" )
            {
                y++;
                Field.array[x, y] = person;
                Field.array[x, y - 1] = empty;
            }
            

        }
        public void MoveLeft()
        {
            if (Field.array[x, y - 1].Type == "key")
            {
                string key = Field.array[x, y - 1].Shape;

                keySound();
                y--;
                Field.array[x, y] = person;
                Field.array[x, y + 1] = empty;
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (Field.array[i, j] is Door element && element.Key == key)
                        {
                            Field.array[i, j] = empty;
                        }
                    }
                }
            }

            if (Field.array[x, y - 1].Type != "wall" && Field.array[x, y - 1].Type != "door")
            {
                y--;
                Field.array[x, y] = person;
                Field.array[x, y + 1] = empty;
            }
            

        }
        public void MoveDown()
        {
            if (Field.array[x + 1, y].Type == "key")
            {
                string key = Field.array[x + 1, y].Shape;

                keySound();
                x++;
                Field.array[x, y] = person;
                Field.array[x - 1, y] = empty;
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (Field.array[i, j] is Door element && element.Key == key)
                        {
                            Field.array[i, j] = empty;
                        }
                    }
                }
            }

            if (Field.array[x + 1, y ].Type != "wall" && Field.array[x + 1, y ].Type != "door") { 
                x++;
            Field.array[x, y] = person;
            Field.array[x - 1, y] = empty;
            }
           

        }
        public void MoveUp()
        {

            if (Field.array[x - 1, y].Type == "key")
            {
                string key = Field.array[x - 1, y].Shape;

                keySound();
                x--;
                Field.array[x, y] = person;
                Field.array[x + 1, y] = empty;
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (Field.array[i, j] is Door element && element.Key == key)
                        {
                            Field.array[i, j] = empty;
                        }
                    }
                }
            }

            if (Field.array[x - 1, y].Type != "wall" && Field.array[x - 1, y ].Type != "door")
            {

                x--;
                Field.array[x, y] = person;
                Field.array[x + 1, y] = empty;
            }
           

        }

        public void keySound()
        {
            //Console.Beep(659, 60);
            //Console.Beep(659, 60);
            //Thread.Sleep(60);
            //Console.Beep(659, 60);
            //Thread.Sleep(167);
            //Console.Beep(523, 60);
            //Console.Beep(659, 60);
            //Thread.Sleep(60);
            //Console.Beep(784, 60);
        }
    }
}
