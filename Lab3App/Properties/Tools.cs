using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App.Properties
{
    internal abstract class Tools : Collectable
    {
        public Tools(string description) : base(description)
        {
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            doAction();
        }

        public abstract void doAction();
    }
}
