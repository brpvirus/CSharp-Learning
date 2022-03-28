using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Methods
    {
        static void demo(string name)
        {
            Console.WriteLine("----- Learning Functions -----");
            Console.WriteLine("function called : and my is : " + name);
        }

        static int square(int num)
        {
            int res = num * num;
            return res;
        }

        public void learnMethods()
        {
            demo("Bhavik");
            Console.WriteLine("Square of 4 is : " + square(4));
        }
    }
}
