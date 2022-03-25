using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Variables
    {
        public void learnVariable()
        {
            string personName = "Bhavik Prajapati";
            int personAge = 22;
            string companyName = "Infopercept";
            bool isMen = true;
            double salary = 25044.44;
            char alpha = 'B';

            Console.WriteLine("My Name is " + personName);
            Console.WriteLine("My Age is " + personAge);
            Console.WriteLine("Am working at "+ companyName + " pvt limited");
            Console.WriteLine(isMen);
            Console.WriteLine("My Salary is "+ salary);
            Console.WriteLine("My Name's First Character is "+ alpha);

            Console.ReadLine();
        }
    }
}
