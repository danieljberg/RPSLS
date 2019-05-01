﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (HAS A)
        public int roundsWon;

        //constructor(SPAWNER)
        public Player()
        {

        }

        //member mathods (HAS TO)
        public abstract void PickGesture();
    }
}