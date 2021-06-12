using System;

namespace Model.Classes
{
    public class Gato : Felino
    {
        public override void fazBarulho()
        {
            Console.WriteLine("Gato fazendo Barulho...");
        }

        public override void Comer()
        {
            Console.WriteLine("Gato esta Comendo...");
        }
    }
}