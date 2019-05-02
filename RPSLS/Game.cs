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

        //constructor(SPAWNER)
        public Game()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

            Player P1 = new Human();
            if (HowManyPlayers() == 1)
            {
                Player P2 = new Computer();
            }
            else
            {
                Player P2 = new Human();
            }


        }


        //member mathods (HAS TO)
        public int HowManyPlayers()
        {
            Console.WriteLine("Enter the number of players '1 or 2'");
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
            if ((P1.pickGesture == "scissors" && P2.pickGesture == "paper") || (P1.pickGesture == "paper" && P2.pickGesture == "rock"))
            {
                P1.roundsWon++;
            }
            else
            {
                P2.roundsWon++;
            }
        }

        public void WhoWonGame()
        {

        }

        public void PlayRound()
        {
            
        }
        public void FindWichGestureWins()
        {

        }
        public void rulesOfGame()
        {
            Console.WriteLine("Two players each pick a gesture:\n\n'rock','paper','scissors','lazard' or 'spock'\n\n\nWhat beats what:\nScissors cuts Paper\nPaper covers Rock\nRock cruches Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nRock crushes Scissors");
        }
    }
}
