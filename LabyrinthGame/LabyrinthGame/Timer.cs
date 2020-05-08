using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace LabyrinthGame
{
    class Timer
    {
         static Stopwatch stopWatch = new Stopwatch(); // секундомер
        
        public static void startTimer()
        {
            stopWatch.Start(); // запустить секундомер
           

            
        }
        public static void endTimer()
        {
            stopWatch.Stop(); // остановить секундомер
        }
        public static void printTimer()
        {
            TimeSpan ts = stopWatch.Elapsed; // структура для работы с временем
            Console.WriteLine($"Your time is: {ts.Seconds:00}.{ts.Milliseconds:00} seconds"); // вывод секунд и милисекунд

            Console.ReadKey();
        }

    }
}
