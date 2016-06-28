using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] masiv2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int broqch = Math.Max(masiv1.Length, masiv2.Length);
            long sum = 0;
            for (int i = 0; i < broqch; i++)
            {
                sum = masiv1[i % (masiv1.Length )] + masiv2[i % (masiv2.Length)];
                Console.Write("{0} ",sum);
            }
            Console.WriteLine();
            
        }
    }
}
