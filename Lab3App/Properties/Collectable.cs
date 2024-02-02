using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        protected CollectionBoard cBoard;
        protected string description;

        // field of type CollectionBoard
        public CollectionBoard Board {
            get { return cBoard; }
            set { cBoard = value; }
        }

        public Collectable(string description) 
        { 
            this.description = description; 
        } 

        // adding desired item to collectables list
        public virtual void AddMe (List<Collectable> collectables)
        {
            collectables.Add (this);
            Console.WriteLine( description +  " Collected, Congrats!!!");
        }

        public abstract void Display(); 
    }
}
