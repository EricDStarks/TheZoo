using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    public abstract class Feline : Animal
    {
        public int pawSize;
        public override void Move()
        {
            Console.WriteLine("Walk");
        }

        public override void Eat()
        {
            Console.WriteLine("Feline is carnivorous");
        }
        public string furColor;
        public string indigenousLand;
    }
}
