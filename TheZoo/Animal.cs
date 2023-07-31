using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    public abstract class Animal
    {
        public string name;
        public int size;
        public abstract void Move();
        public abstract void Eat();
        public virtual void Sleep()
        {
            Console.WriteLine("How long does the animal sleep");
        }
    }
}
