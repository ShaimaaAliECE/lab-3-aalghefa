using System;
using System.Collections.Generic;
namespace Lab3App
{
    internal class Coin : Treasure
    {
        private string description;
        private int score;
        private int value;


        public Coin(string description, int score, int value)
        {
            this.description = description;
            this.value = value;
            this.score = score;

        }

        public override void AddMe(List<Collectable> collectables)
        {
            Console.WriteLine($"{description} Collected, Congrats!");
            UpdateTotalScore();
            UpdateTotalValue();
            collectables.Add(this);
        }

        public void UpdateTotalValue()
        {
            CollectionBoard.TotalValue += value;
            Console.WriteLine($"Total value is updated to: {CollectionBoard.TotalValue}");

        }

        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += score;
            Console.WriteLine($"Total score is updated to: {CollectionBoard.TotalScore}");

        }

        public override void Display()
        {
            Console.WriteLine($"Coin {description} is displayed");

        }
    }
}

