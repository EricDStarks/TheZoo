using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    internal class Lion: Feline, IWalk
    {
        public int legs { get; set; }
    }
}
