using System.Collections;
using static System.Console;
/// <summary>
/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
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
                for (int j = 2; j <= finalFactor; j++)
                {
                    if (i % j != 0)
                        numberFound = false;
                }
                if (numberFound)
                {
                    WriteLine("The smallest number that can be divisble by each of the numbers from 1 to " + finalFactor +
                " is " + i);
                    break;
                }
                numberFound = true;
            }
        }
    }
}
