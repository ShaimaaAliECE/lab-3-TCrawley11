using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App.Properties
{
    internal class MagicWand : Tools
    {
        public MagicWand(string description) : base(description)
        {
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + description + " is displayed");
        }

        public override void doAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}
