using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (HAS A)
        
        public string name;
        public string pickGesture;
        public int roundsWon;

        //constructor(SPAWNER)

        public Player()
        {
            roundsWon = 0;
        }

        //member mathods (HAS TO)

        public abstract string PickGesture(List<string> gestures);
    }
}
