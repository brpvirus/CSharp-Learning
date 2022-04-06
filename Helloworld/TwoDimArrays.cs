using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class TwoDimArrays
    {
        public void learnTwoDimensionalArray()
        {
            Console.WriteLine("----- Learning Two Dimensional Array -----");

            int[,] vs =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine(vs[0,1]);

        }
    }
}
