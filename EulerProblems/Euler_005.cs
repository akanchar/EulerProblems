using System.Collections;
using static System.Console;
/// <summary>
/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
/// Runs faster because the prime numbers are listed first in the 'if' condition, which short cirtcuits 
/// the 'if' loop faster if not the right number.
/// </summary>
namespace EulerProblems
{
    class Euler_005
    {
        const int finalFactor = 20;
        internal void start()
        {
            bool numberFound = true;
            ArrayList uniqueNumbers = new ArrayList();
            for (int i = finalFactor; numberFound; i++)
            {
                if (i % 19 == 0 && i % 17 == 0 &&
                i % 13 == 0 && i % 11 == 0 &&
                i % 20 == 0 && i % 18 == 0 &&
                i % 16 == 0 && i % 15 == 0 &&
                i % 14 == 0 && i % 20 == 0)
                {
                    WriteLine("The smallest number that can be divisble by each of the numbers from 1 to " + finalFactor +
                " is " + i);
                    break;
                }
            }
        }
    }
}
