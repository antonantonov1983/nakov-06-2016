using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv =Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (masiv.Length == 1)
            {
                Console.WriteLine(masiv[0]);
            }
            else if (masiv.Length % 2 == 0)
            {
                Console.WriteLine(masiv[(masiv.Length / 2) - 1]);
                Console.WriteLine(masiv[(masiv.Length / 2) ]);
            }
            else
            {
                Console.WriteLine(masiv[(masiv.Length / 2) - 1]);
                Console.WriteLine(masiv[(masiv.Length / 2) ]);
                Console.WriteLine(masiv[(masiv.Length / 2) + 1]);

            }
        }
    }
}
