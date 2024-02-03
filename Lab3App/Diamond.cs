using System;
using System.Collections.Generic;
namespace Lab3App
{
    internal class Diamond : Treasure
    {
        private string description;
        private int score;

        public Diamond(string description, int score)
        {
           this.score = score;
            this.description = description;

        }

        public override void Display()
        {
            Console.WriteLine($"Diamond{description} is displayed");

        }

        public override void AddMe(List<Collectable> collectables)
        {
            Console.WriteLine($"{description} Collected, Congrats!");
            UpdateTotalScore();
            collectables.Add(this);

        }

        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += score;
            Console.WriteLine($"Total score is updated to: {CollectionBoard.TotalScore}");
        }
    }
}
