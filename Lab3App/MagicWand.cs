using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        private string description;

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");

        }

        public MagicWand(string description)
        {
            this.description = description;

        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {description} is used");
        }

        public override void AddMe(List<Collectable> collectables)
        {
            Console.WriteLine($"{description} Collected, Congrats!");
            collectables.Add(this);
            DoAction();

        }

    }
}