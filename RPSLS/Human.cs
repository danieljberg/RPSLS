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
            Console.WriteLine($"\n{name} please type your gesture:\nOptions:\n");
            for (int i = 0; i < gestures.Count; i++)
            {                
                Console.WriteLine(gestures[i]);                
            }
            Console.WriteLine("\n");
            pickGesture = Console.ReadLine();
            if (gestures.Contains(pickGesture))
            {
                return pickGesture;
            }            
            else
            {
                Console.WriteLine("\nYOU DID NOT ENTER A VALID OPTION\n");
                return PickGesture(gestures);
            }
        }
        public string GetName()
        {
            Console.WriteLine("Please enter player's name:");
            name = Console.ReadLine();
            return name;
        }
    }
}
