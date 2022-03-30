using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class DecisionMaking
    {
        public void learnDecisionMaking(int a, int b,int c)
        {
            if(a>b && a>c)
            {
                Console.WriteLine("A is bigger than B & C " + a);
            }
            else if(b>c && b>a)
            {
                Console.WriteLine("B is bigger than A & C " + b);
            }
            else if(c>a && c>b)
            {
                Console.WriteLine("C is bigger than B & A "+ c);
            }
            else
            {
                Console.WriteLine("None Of the above");
            }


            if(a>b)
            {
                Console.WriteLine("A is Greater than B");
            }
            else 
            {
                Console.WriteLine("B is Greater than A");
            }
        }
    }
}
