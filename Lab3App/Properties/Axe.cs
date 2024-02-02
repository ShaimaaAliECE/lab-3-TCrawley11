using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App.Properties
{
    internal class Axe : Tools
    {
        public Axe(string description) : base(description)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + description + " is displayed");
        }

        public override void doAction()
        {
            Console.WriteLine("Axe is used");
        }
    }
}
