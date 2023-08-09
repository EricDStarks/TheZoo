using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    public class Jaguar : Feline, IWalk  // The jaguar class inherits from the Feline class and also implements the IWalk interface
    {
        public int teeth;  //An integer variable named teeth with public accessibility
        public string color; //A string variable named color with public accessibilty
        public string name; //A string variable named name with public accessibilty
        public int legs { get; set; } //A public property named legs with get and set accessors that allows external code to read and modify the value of legs as if it was a variable

        public Jaguar(string spotColor, int teethAmount, string name) //A public constructor for the Jaguar class that takes in 3 parameters
        {
            //Assigns value to spotColor and teethAmount to color and teeth parameters. This refers to the name property and assign value to the name parameter.
            color = spotColor;
            teeth = teethAmount;
            this.name = name;
        }

    }
}
