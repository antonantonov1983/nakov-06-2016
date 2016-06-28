using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int broqch = masiv.Length-1;
            for (int i = 0; i < broqch; i++)
            {
               //Console.WriteLine(masiv[0]);
                for (int j = 0; j < broqch ;j++ )
                {

                    masiv[j] = masiv[j] + masiv[j + 1];
                    //Console.Write(" {0} ", masiv[j]);
                }
                //Console.WriteLine();
            }
            Console.WriteLine(masiv[0]);
            
        }
    }
}
