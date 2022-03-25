using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class TakingUserInput
    {
        public void userInput()
        {
            Console.WriteLine("-----TakingUserInput-----");
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}
