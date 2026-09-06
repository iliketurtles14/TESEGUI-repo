using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Guard
    {
        public string name;
        public string strength;
        public string speed;
        public string intellect;
        public string opinion;
        public List<string> patrol;
        public bool flag2001;
        public List<Item> inventory;
        public Guard(string name, string strength, string speed, string intellect, string opinion, List<string> patrol, bool flag2001, List<Item> inventory)
        {
            this.name = name;
            this.strength = strength;
            this.speed = speed;
            this.intellect = intellect;
            this.opinion = opinion;
            this.patrol = patrol;
            this.flag2001 = flag2001;
            this.inventory = inventory;
        }
    }
}
