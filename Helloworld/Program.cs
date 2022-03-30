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

            Looping looping = new Looping();
            looping.learningLoops();

            SwitchStatement switchStatement = new SwitchStatement();
            switchStatement.learnSwitchStatement();


            DecisionMaking decisionMaking = new DecisionMaking();
            decisionMaking.learnDecisionMaking(10, 20, 30);
            decisionMaking.learnDecisionMaking(20, 10, 5);
            decisionMaking.learnDecisionMaking(4, 10, 5);

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
