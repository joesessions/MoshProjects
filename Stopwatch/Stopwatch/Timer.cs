using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Timer
    {
        public List<Split> splits = new List<Split>();
        int i = 0;
        public bool currentlyRunning = false;
        public TimeSpan totalTime = TimeSpan.Zero;

        public List<Split> timer (char button)
        {


            if ((button == 'b' ) && !currentlyRunning)
            {
                var currentSplit = new Split(i);   //As this program keeps track of "splits" like fancy stopwatches do, a new split instantiates whenever the start button is pushed. 
                splits.Add(currentSplit);
                currentlyRunning = true;
                return splits;
            }

            else if ((button == 'b' ))
            {
                throw new InvalidOperationException();
            }

            else if ((button == 's' ) && !currentlyRunning)
            {
                throw new InvalidOperationException();
            }

            else if (button == 's' )
            {
                splits[i].Stop();
                totalTime += splits[i].timeSpan;
                i++;
                currentlyRunning = false;
                return splits;
            }



            return splits;
            
        }
    }

}