using static System.Console;
/// <summary>
/// A palindromic number reads the same both ways. 
/// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
/// Find the largest palindrome made from the product of two 3-digit numbers.
/// </summary>
namespace EulerProblems
{
    class Euler_004
    {
        const int Number = 4024;
        internal void start()
        {
            bool isPalindrome = true;
            if (Number.ToString().Length <= 1)
            {
                WriteLine("Single digit number is a palindrome in itself.");
                return;
            }
            char[] charArray = Number.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length / 2; i++)
            {
                if (charArray[i] != charArray[charArray.Length - i - 1])
                    isPalindrome = false;
            }
            WriteLine("Number " + Number + " is " + ((isPalindrome == true)?"":"not ") + "a palindrome.");
        }
    }
}
