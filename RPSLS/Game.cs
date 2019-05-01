using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables (HAS A)

        //public List<string> gestures;
        Player P1;
        Player P2;
        public string playerMove;
        public int howManyPlayers;

        //constructor(SPAWNER)
        public Game()
        {
            //List<string> gestures = new List<string>()
            //{

            //};

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
            howManyPlayers = Console.ReadLine();
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

        }

        public void WhoWonGame()
        {

        }

        public void PlayRound()
        {
            Console.WriteLine("Enter your move:\n'rock','paper','scissors','lazard' or 'spock'");
            return playerMove = Console.ReadLine();
        }
        public void FindWichGestureWins()
        {

        }
    }
}
