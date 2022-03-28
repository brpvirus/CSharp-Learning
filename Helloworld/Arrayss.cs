using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Arrayss
    {
        public void learnArray()
        {
            Console.WriteLine("-----Arrays-----");

            /* Creating array with new keyword */
            int[] ii = new int[2];
            ii[0] = 1;
            ii[1] = 2;

            Console.WriteLine(ii[0]);

            /* First way to declare the array with elements */
            string[] arrStr = { "Bhavik", "Jaydeep", "Hemang", "Yash", "Vaibhavi", "Vrutika", "Parth" };
            Console.WriteLine("Array Element : "+arrStr[0]);

            arrStr[1] = "Brp Virus";
            Console.WriteLine(arrStr[1]);
        }
    }
}
