using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    static class Game
    {
        Player playerOne = new Human("");
        Player playerTwo;
    }

        public void Run()
        {
            displayWelcome();
            gameMode();
            //bool playAgain = true;
        }

        public string displayWelcome()
        {
            Console.WriteLine("Welcome to RPSLS (Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("RPSLS is just like Rock Paper Scissors, each player has to choose any one variable Rock, Paper, Scissors, Lizard or Spock.\n Once the each player has chosen there vaiable, the choicces will be revealed and compared and winner will be decleared.\n The winner will be decided by the chart below\n * Rock crushes Scissors  ---  Scissors cuts Paper --- Paper covers Rock --- Rock crushes Lizard --- Lizard poisons Spock \n Spock smashes Scissors --- Scissors decapitates Lizard --- Lizard eats Paper --- Paper disproves Spock --- Spock vaporizes Rock");

        }

        public void gameMode():
            gameMode 
    
}
