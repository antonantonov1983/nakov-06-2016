using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
           string[]  masiv = Console.ReadLine().Split(' ').ToArray();
            int broqch = masiv.Length / 2;
            string temp="";
            for (int i = 0; i < broqch; i++)
            {
                temp=masiv[i];
                masiv[i] = masiv[masiv.Length - 1 - i];
                masiv[masiv.Length - 1 - i] = temp;
            }
            Console.WriteLine( string.Join(" ",masiv));
        }
    }
}
