using System;

namespace Model.Classes
{
    public class Gato : Felino
    {
        public override void fazBarulho()
        {
            Console.WriteLine("Gato fazendo barulho.");
        }

        public override void Comer()
        {
            Console.WriteLine("Gato esta comendo.");
        }
    }
}