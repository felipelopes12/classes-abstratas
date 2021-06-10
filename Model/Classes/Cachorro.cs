﻿using System;

namespace Model.Classes
{
    public class Cachorro : Canino
    {
        
        public override void fazBarulho()
        {
            Console.WriteLine("Cachorro fazendo barulho.");
        }

        public override void Comer()
        {
            Console.WriteLine("Cachorro esta comendo.");
        }
    }
}