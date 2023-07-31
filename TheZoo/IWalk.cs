using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    public interface IWalk
    {
        public int legs { get; set; }
        public void Walk()
        {
            Console.WriteLine("Can walk");
        }

    }
}
