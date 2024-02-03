using System;
using System.Collections.Generic;
namespace Lab3App
{
     abstract internal class Collectable : Displayable
    {
        //Adding fields
        private string description { get; set; }

        //Adding field of type CollectionBoard
      
        public CollectionBoard Board { get; set; }

        //Adding the current Collectable to a list
        public abstract void AddMe(List<Collectable> collectables);
        public abstract void Display();
    }
}
