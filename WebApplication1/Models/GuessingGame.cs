using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class GuessingGame
    {
        public int EnterredNumber { get; set; }
        public List<int> guesses = new List<int>();
        public string message { get; set; }

        public GuessingGame()
        {
            Random rand = new Random();
            EnterredNumber = rand.Next(1, 100);

        }
        public void AddGuessNumber(int num)
        {
            if (num > EnterredNumber)
            {
                message = "you´r number is to high ";

            }
            else if (num < EnterredNumber)
            {
                message = "you´r number is low";
            }

            else if (num == EnterredNumber)
            {
                message = "you´ number is correct );";
            }

            guesses.Add(num);

        }
       
    }
}
