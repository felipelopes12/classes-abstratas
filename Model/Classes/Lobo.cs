using System;

namespace Model.Classes
{
    public class Lobo : Canino
    {
        public override void fazBarulho()
        {
            Console.WriteLine("Lobo fazendo Barulho...");
        }

        public override void Comer()
        {
            Console.WriteLine("Lobo esta Comendo...");
        }
    }
}