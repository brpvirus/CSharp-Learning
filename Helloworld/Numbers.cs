using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Numbers
    {
        public void learnNumber()
        {
            Console.WriteLine("------Numbers------");
            Console.WriteLine("Minimum of (1,2) "+Math.Min(1,2));
            Console.WriteLine("Maximum of (1,2) "+Math.Max(1,2));
            Console.WriteLine("Absolute of (-1) "+Math.Abs(-1));
            Console.WriteLine("Power of (2,2) "+Math.Pow(2,2));
            Console.WriteLine("sqrt of (16) "+Math.Sqrt(16));
        }
    }
}
