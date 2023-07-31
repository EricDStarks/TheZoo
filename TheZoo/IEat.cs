using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    public interface IEat
    {
        public int meals { get; set; }

        public void Eat()
        {
            Console.WriteLine("Meals eaten per day");
        }
    }
}
