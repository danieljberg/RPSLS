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
        public List<string> gestures;

        //constructor(SPAWNER) instantiates objects
        public Game()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }


        //member mathods (HAS TO)
        public void RulesOfGame()
        {
            Console.WriteLine("This is a two player game where each player picks a gesture:\n'rock','paper','scissors','lizard' or 'spock'\nThis game is a best of three round" +
                " series\n\nRules:\n\nScissors cuts Paper\nPaper covers Rock\nRock cruches Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nRock crushes Scissors\n\n");
        }
        public int HowManyPlayers()
        {
            Console.WriteLine("Enter the number of players '1' or '2':");
            int howManyPlayers = int.Parse(Console.ReadLine());
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
                P1.gamesWon++;
            }
            if (P2.roundsWon == 2)
            {
                Console.WriteLine($"Congratulations {P2.name} won the game!");
                P2.gamesWon++;
            }
        }

        public void PlayGame()
        {
            RulesOfGame();
            int numOfPlayers = HowManyPlayers();
            CreatePlayer(numOfPlayers);
            while((P1.roundsWon < 2) && (P2.roundsWon < 2))
            {
                PlayRound();                
                Console.WriteLine($"\n\n{P1.name}'s score is " + P1.roundsWon + $"\n{P2.name}'s score is " + P2.roundsWon);
            }
            WhoWonGame();
            PlayAgain();
        }
        public void PlayAnotherGame()
        {
            P1.roundsWon = 0;
            P2.roundsWon = 0;
            while ((P1.roundsWon < 2) && (P2.roundsWon < 2))
            {
                Console.WriteLine($"\n{P1.name} won " + P1.gamesWon + $" games\n{P2.name} won " + P2.gamesWon + " games");
                PlayRound();
                //WhoWonRound();
                Console.WriteLine($"\n\n{P1.name}'s score is " + P1.roundsWon + $"\n{P2.name}'s score is " + P2.roundsWon);
            }
            WhoWonGame();
            PlayAgain();
        }
        public void PlayRound()
        {
            P1.PickGesture(gestures);
            P2.PickGesture(gestures);
            WhoWonRound();
        }
        public void CreatePlayer(int howManyPlayers)
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
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play another game (yes or no)");
            string playAgain = Console.ReadLine();
            if (playAgain == "yes")
            {
                PlayAnotherGame();
            }
            else if (playAgain == "no")
            {
                Console.WriteLine("Thank you for playing");
                Console.WriteLine($"\n{P1.name} won " + P1.gamesWon + $" games\n{P2.name} won " + P2.gamesWon + " games");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nENTER 'YES' OR 'NO'\n");
                PlayAgain();
            }
        }
    }
}
