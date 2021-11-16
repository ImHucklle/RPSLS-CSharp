using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human: Player
    {
        public Human(string name, int score, string choice, string gesture)
        {
            this.name = name;
            this.score = score;
            this.choice = choice;
            this.gesture = gesture;
        }

        public string chooseGesture()
        {
            Console.WriteLine("Choose a number\n 0 for rock\n 1 for paper\n 2 for scissors\n 3 for lizard\n 4 for spock\n");
            string userInput = Console.ReadLine();
            if (userInput = "0")
            {
                return "rock";
            }
            else if (userInput = "1")
            {
                return "paper";
            }
            else if (userInput = "2")
            {
                return "scissors";
            }
            else if (userInput = "3")
            {
                return "lizard";
            }
            else if (userInput = "4")
            {
                return "spock";
            }
            else
            {
                return "choose a number 0 - 4"
            }
        }
    }
}
