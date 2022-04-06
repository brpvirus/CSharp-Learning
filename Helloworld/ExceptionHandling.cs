using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class ExceptionHandling
    {
        public void learningExcetionHandling()
        {
            try
            {
                Console.WriteLine("----- Learnign Exception Handling -----");
                Console.WriteLine("Enter Number 1 ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number 2 ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The Division is : " +num1/num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
        }
    }
}
