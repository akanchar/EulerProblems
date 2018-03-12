using System.Collections;
using static System.Console;
/// <summary>
/// The prime factors of 13195 are 5, 7, 13 and 29.
/// What is the largest prime factor of the number 600851475143 ?
/// </summary>
namespace EulerProblems
{
    class Euler_003
    {
        const long Number = 600851475143;
        ArrayList primeFactors = new ArrayList();
        internal void start()
        {
            for (long i = 2; i < Number; i++)
            {
                bool isPrimeFactor = true;
                if (Number % i == 0)
                {
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            isPrimeFactor = false;
                    }
                    if (isPrimeFactor)
                        primeFactors.Add(i);
                }
            }
            if (primeFactors.Count >= 1)
                WriteLine ("The largest of the prime factors of " + Number + " is " + primeFactors[primeFactors.Count - 1] + ".");
            else if (primeFactors.Count == 0)
                WriteLine("There are no prime factors for the " + Number + ".");

        }
    }
}
