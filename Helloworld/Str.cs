using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Str
    {
        public void learnStr()
        {
            string str = "Bhavik";
            Console.WriteLine(str);
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.IndexOf("h"));
            Console.WriteLine(str.Substring(2));
            Console.WriteLine(str.Substring(2,4));
        }
    }
}
