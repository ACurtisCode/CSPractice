using System;
using static System.Console;

namespace Section_2_Excercise_1
{
    internal class StopWatch
    {
        public TimeSpan ts = new TimeSpan();
        
        public DateTime dateTime = DateTime.Now;

        public void Start()
        {
            WriteLine("Press any key to Start");
            ReadKey(true);
            dateTime = DateTime.Now;
        }  

        public int Stop()
        {
            WriteLine("Press any key to Stop");
            ReadKey(true);
            ts = DateTime.Now.Subtract(dateTime);
            return ts.Seconds;
        }
    }
}