using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime countdownEnd;
            TimeSpan countdownTime;
            Console.WriteLine("Enter countdown time in HH:MM:SS format:");

            string[] input = Console.ReadLine().Split(new char[] { ':' });
            while (input.Length == 3)
            {
                countdownTime = new TimeSpan(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]) + 1);
                countdownEnd = DateTime.Now.Add(countdownTime);

                Console.Clear();
                Console.WriteLine("STARTING COUNTDOWN!");
                Thread.Sleep(500);
                Console.Clear();

                while (DateTime.Now < countdownEnd)
                {
                    countdownTime = countdownEnd - DateTime.Now;
                    Console.WriteLine(countdownTime.ToString(@"hh\:mm\:ss"));
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                Console.Clear();
                Console.Beep();
                Console.WriteLine("***COUNTDOWN FINISHED!!!***\n\nEnter a new countdown time or 'quit'");
                input = Console.ReadLine().Split(new char[] { ':' });
            }
        }
    }
}
