using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class Leao : Felino
    {
        public override void fazBarulho()
        {
            Console.WriteLine("Leao fazendo Barulho...");
        }

        public override void Comer()
        {
            Console.WriteLine("Leao esta Comendo...");
        }
    }
}
