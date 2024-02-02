using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App.Properties
{
    internal class Coin : Treasure
    {
        private int value;
        public Coin(string description, int value, int score) : base(description, score)
        {
            this.value = value; // set value for coin and also set score and description using parent
        }

        public void updateTotalValue()
        {
            cBoard.TotalValue += this.value;
            Console.WriteLine("Total Value is updated to: " + cBoard.TotalValue);
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + description + " is displayed");
        }

        public override void AddMe(List<Collectable> list) 
        { 
            base.AddMe(list);
            updateTotalValue();
        }
    }
}
