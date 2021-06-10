using System;

namespace Model.Classes
{
    public abstract class Canino : Animal
    {
       
        public override void Vaguear()
        {
            Console.WriteLine("Canino vaguenado.");
        }
    }
}