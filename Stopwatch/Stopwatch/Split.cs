using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Split
    {
        public int Id { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public TimeSpan timeSpan = new TimeSpan();


        public Split(int id)
        {
            this.Id = id;
            this.startTime = DateTime.Now;

        }

        public void Stop()
        {
            this.endTime = DateTime.Now;
            this.timeSpan = endTime - startTime;

            return;
        }


    
    }
}
