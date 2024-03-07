﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Property
        private int CurrentValue; //Defines CurrentValue variable
        private static Random value = new Random(); //Creates a random instance that is accessed 3 times as opposed to making 3 random intances to avoid identical generations.

        //Method
        public int Roll()
        {
            CurrentValue = value.Next(1, 7); //Pseudo-random value between 1 (inclusive) and 7 (exclusive) aka 1-6.
            return CurrentValue;
         }
    }
}
