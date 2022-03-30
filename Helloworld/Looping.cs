using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Looping
    {
        public void learningLoops()
        {
            Console.WriteLine("----- Learning Loops -----");
            Console.WriteLine("----- while Loop -----");
            int i = 1;
            while(i <= 5)
            {
                Console.WriteLine("inside the while loop");
                i++;
            }

            Console.WriteLine("----- for Loop -----");
            for(int j=1;j<=5;j++)
            {
                Console.WriteLine("inside the for loop");
            }

            Console.WriteLine("----- do while Loop -----");
            i = 1;
            do
            {
                Console.WriteLine("inside the do while loop");
                i++;
            }while(i <= 5);

        }
    }
}
