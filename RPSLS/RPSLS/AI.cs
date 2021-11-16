using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI: Player
    {
        public AI(string name, int score, string choice)
        {
            this.name = name;
            this.score = score;
            this.choice = choice;
        }

        public void gestureSelect()
        {
            this.choice = Random.choice(this.gesture);
            if (this.choice == "rock")
                Console.WriteLine("Player 2 selects" this.choice);
            else if (this.choice == "paper")
                Console.WriteLine("Player 2 selects" this.choice);
            else if (this.choice == "scissors")
                Console.WriteLine("Player 2 selects" this.choice);
            else if (this.choice == "lizard")
                Console.WriteLine("Player 2 selects" this.choice);
            else if (this.choice == "spock")
                Console.WriteLine("Player 2 selects" this.choice);
        }

    }
}
