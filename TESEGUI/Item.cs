using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Item
    {
        public string id;
        public string durability;
        public Item(string id, string durability)
        {
            this.id = id;
            this.durability = durability;
        }
    }
}
