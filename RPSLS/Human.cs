using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables (HAS A)
        

        //constructor(SPAWNER)
        public Human()
        {
            name = GetName();
        }


        //member mathods (HAS TO)
        public override string PickGesture()
        {
            Console.WriteLine($"{name} please choose your gesture:\n'rock','paper','scissors','lazard' or 'spock'");
            pickGesture = Console.ReadLine();
            return pickGesture;
        }
        public string GetName()
        {
            Console.WriteLine("Please enter player's name:");
            name = Console.ReadLine();
            return name;
        }
    }
}
