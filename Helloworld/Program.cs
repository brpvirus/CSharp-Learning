using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------Main------");
            Console.WriteLine("Hello world");

            Methods methods = new Methods();
            methods.learnMethods();

            Arrayss arr = new Arrayss();
            arr.learnArray();

            TakingUserInput takingUserInput = new TakingUserInput();
            takingUserInput.userInput();

            Numbers numbers = new Numbers();
            numbers.learnNumber();

            Str ss = new Str();
            ss.learnStr();

            Variables variables = new Variables();
            variables.learnVariable();

            Console.ReadLine();
        }
    }
}
