using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Desk
    {
        public string posX;
        public string posY;
        public string objectID;
        public List<Item> inventory;
        public Desk(string posX, string posY, string objectID, List<Item> inventory)
        {
            this.posX = posX;
            this.posY = posY;
            this.objectID = objectID;
            this.inventory = inventory;
        }
    }
}
