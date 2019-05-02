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
        public override string PickGesture()
        {
            Random num = new Random(4);
            pickGesture = gestures.ElementAt(num);
            return pickGesture;
        }
    }
}
