﻿using System;

namespace Model.Classes
{
    public class Lobo : Canino
    {
        public override void fazBarulho()
        {
            Console.WriteLine("Lobo fazendo barulho.");
        }

        public override void Comer()
        {
            Console.WriteLine("Lobo esta comendo.");
        }
    }
}