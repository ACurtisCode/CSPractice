using System;

using static System.Console;

namespace Section_2_Excercise_1
{
    class Program
    {

        static void Main(string[] args)
        {
            StopWatch calculator = new StopWatch();


            
            calculator.Start();
            while (true)
            {
                int ts = calculator.Stop();
                WriteLine(ts);
            }
        }
    }
}
