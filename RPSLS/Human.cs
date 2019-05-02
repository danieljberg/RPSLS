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
        public override string PickGesture(List<string> gestures)
        {
            Console.WriteLine($"\n{name} please choose your gesture:");
            for(int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine("Option " + (i+1) + " " + gestures[i]);
            }


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
