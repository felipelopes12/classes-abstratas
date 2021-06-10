using System;

namespace Model.Classes
{
    public abstract class Felino : Animal
    {
        public override void Vaguear()
        {
            Console.WriteLine("Felino vagueando.");
        }
    }
}