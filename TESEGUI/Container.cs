using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Container
    {
        public string posX;
        public string posY;
        public string objectDirection;
        public List<Item> inventory;
        public Container(string posX, string posY, string objectDirection, List<Item> inventory)
        {
            this.posX = posX;
            this.posY = posY;
            this.objectDirection = objectDirection;
            this.inventory = inventory;
        }
    }
}
