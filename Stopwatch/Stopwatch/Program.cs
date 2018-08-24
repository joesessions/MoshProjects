using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("This is a stopwatch. Enter \"b\" to Begin, \"s\" to Stop and \"q\" to quit");
            Timer timer = new Timer();
            var input = 'a';
            List<Split> currentSplits = new List<Split>();

            
            while (input != 'q')
            {

                input = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (input == 'b' || input == 's')
                {
                    currentSplits = timer.timer(input); // submit the keystroke and operate the timer.

                    if (timer.currentlyRunning)
                    {
                        Console.WriteLine("Stopwatch running.");
                    }
                    else
                    {
                        Console.WriteLine("This split time: " + currentSplits[currentSplits.Count - 1].timeSpan.ToString("c"));
                        Console.WriteLine("Total time: " + timer.totalTime);
                    }
                }

                else if (input == 'q')
                {
                    // Do nothing.
                }

                else
                {
                    Console.WriteLine("Sorry, that is not a valid input");
                }

            }

            Console.WriteLine("Press a key to exit");
            Console.ReadLine();


            

                

            
        

        }
    }
}
