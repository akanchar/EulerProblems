using System;
using static System.Console;
namespace EulerProblems
{
    public class Home
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            new Euler_005().start();
            WriteLine("Execution time - " + ((long)(DateTime.Now.Ticks) - (long)dateTime.Ticks)/10000 + " milliseconds.");
        }
    }
}
