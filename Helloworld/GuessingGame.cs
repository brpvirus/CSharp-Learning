using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld  
{
    public class GuessingGame
    {
        public void playGame()
        {
            Console.WriteLine("----- Guessing Game -----");
            string actualWord = "Bhavik";
            string predictedWord = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool res = false;

            while(predictedWord != actualWord && !res)
            {
                if(guessCount < guessLimit)
                {
                    Console.WriteLine("Enter your Guess : ");
                    predictedWord = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    res = true;
                }
            }
            if(res)
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("You Won");
            }
        }
    }
}
