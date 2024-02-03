using System;
using System.Collections.Generic;
namespace Lab3App
{
    internal class Axe : Tool
    {
        public string description;

       public Axe(string description)
        {
            this.description = description;

        }

        public override void AddMe(List<Collectable> collectables)
        {
            Console.WriteLine($"{description} Collected, Congrats!");
            collectables.Add(this);
            DoAction();


        }

        public override void Display()
        {
            Console.WriteLine($"Axe {description} is displayed");

        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is used");

        }
    }
}