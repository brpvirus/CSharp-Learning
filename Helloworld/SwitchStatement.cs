using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class SwitchStatement
    {
        public void learnSwitchStatement()
        {
            Console.WriteLine("----- Switch Statement -----");

            Console.WriteLine("1) movie");
            Console.WriteLine("2) travelling");
            Console.WriteLine("3) coding");
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    Console.WriteLine("You are watching movie..");
                    break;
                case 2:
                    Console.WriteLine("you are doing travelling..");
                    break;
                case 3:
                    Console.WriteLine("you are doing coding..");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
