using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables (HAS A)

                //public List<string> gestures;
        Player P1;
        Player P2;
        public string playerMove;
        public int howManyPlayers;
        public List<string> gestures;

        //constructor(SPAWNER) instantiates objects
        public Game()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }


        //member mathods (HAS TO)
        public int HowManyPlayers()
        {
            Console.WriteLine("Enter the number of players '1' or '2':");
            howManyPlayers = int.Parse(Console.ReadLine());
            if (howManyPlayers == 1 || howManyPlayers == 2)
            {
                return howManyPlayers;
            }
            else
            {
                Console.WriteLine("Please enter only '1' or '2'");
                return HowManyPlayers();
            }
        }

        public void WhoWonRound()
        {
            if ((P1.pickGesture == "scissors" && P2.pickGesture == "paper") || (P1.pickGesture == "paper" && P2.pickGesture == "rock") || (P1.pickGesture == "rock" && P2.pickGesture == "lizard") || (P1.pickGesture == "lizard" && P2.pickGesture == "spock") || (P1.pickGesture == "spock" && P2.pickGesture == "scissors") || (P1.pickGesture == "scissors" && P2.pickGesture == "lizard") || (P1.pickGesture == "lizard" && P2.pickGesture == "paper") || (P1.pickGesture == "paper" && P2.pickGesture == "spock") || (P1.pickGesture == "spock" && P2.pickGesture == "rock") || (P1.pickGesture == "rock" && P2.pickGesture == "scissors"))
            {
                P1.roundsWon++;
                Console.WriteLine($"{P1.name} won that round");
            }
            else if ((P1.pickGesture == "rock" && P2.pickGesture == "rock") || (P1.pickGesture == "scissors" && P2.pickGesture == "scissors") || (P1.pickGesture == "paper" && P2.pickGesture == "paper") || (P1.pickGesture == "lizard" && P2.pickGesture == "lizard") || (P1.pickGesture == "spock" && P2.pickGesture == "spock"))
            {
                Console.WriteLine($"{P1.name}'s score is " + P1.roundsWon + $"\n{P2.name}'s score is " + P2.roundsWon);
                PlayRound();
            }
            else
            {
                P2.roundsWon++;
                Console.WriteLine($"{P2.name} won that round");
            }
           
        }

        public void WhoWonGame()
        {
            if (P1.roundsWon == 2)
            {
                Console.WriteLine($"Congratulations {P1.name} won the game!");
            }
            if (P2.roundsWon == 2)
            {
                Console.WriteLine($"Congratulations {P2.name} won the game!");
            }
            Console.ReadLine();
        }

        public void PlayGame()
        {
            RulesOfGame();
            HowManyPlayers();
            CreatePlayer();
            while((P1.roundsWon < 2) && (P2.roundsWon < 2))
            {
                PlayRound();
                Console.WriteLine($"\n\n{P1.name}'s score is " + P1.roundsWon + $"\n{P2.name}'s score is " + P2.roundsWon);
            }
            WhoWonGame();
        }

        public void PlayRound()
        {
            P1.PickGesture(gestures);
            P2.PickGesture(gestures);
            WhoWonRound();
        }
        public void CreatePlayer()
        {
            P1 = new Human();
            if (howManyPlayers == 1)
            {
                P2 = new Computer();
            }
            else
            {
                P2 = new Human();
            }
        }
        public void RulesOfGame()
        {
            Console.WriteLine("This is a two player game where each player picks a gesture:\n'rock','paper','scissors','lizard' or 'spock'\nThis game is a best of three round series\n\nRules:\n\nScissors cuts Paper\nPaper covers Rock\nRock cruches Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nRock crushes Scissors\n\n");
        }
    }
}
