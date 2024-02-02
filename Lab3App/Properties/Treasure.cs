using Lab3App.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        protected int score;

        public Treasure(string description, int score) : base(description)
        {
            this.score = score;
        }

        public void updateTotalScore() 
        {
            cBoard.TotalScore += this.score;
            Console.WriteLine("Total Score is updated to: " + cBoard.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalScore();
        }


    }
}
