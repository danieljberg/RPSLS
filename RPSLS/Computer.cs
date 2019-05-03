using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player 
    {
        //member variables (HAS A)
        

        //constructor(SPAWNER)
        public Computer()
        {
            name = "Virtual Sheldon";

        }


        //member mathods (HAS TO)
        public override string PickGesture(List<string> gestures)
        {
            Random randomNumberGenerator = new Random();
            int indexNumber = randomNumberGenerator.Next(5);
            pickGesture = gestures.ElementAt(indexNumber);
            Console.WriteLine($"\n{name} picked " + pickGesture);
            return pickGesture;
        }
    }
}
