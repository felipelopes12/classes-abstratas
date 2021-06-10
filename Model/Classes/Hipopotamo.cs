using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public abstract class Hipopotamo : Animal
    {
        public override void fazBarulho()
        {
            Console.WriteLine("Hipopotamo fazendo barulho.");
        }

        public override void Comer()
        {
            Console.WriteLine("Hipopotamo esta comendo.");
        }
    }
}
