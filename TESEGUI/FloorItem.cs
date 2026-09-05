using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class FloorItem
    {
        public string posX;
        public string posY;
        public string layer;
        public Item item;
        public FloorItem(string posX, string posY, string layer, Item item)
        {
            this.posX = posX;
            this.posY = posY;
            this.layer = layer;
            this.item = item;
        }
    }
}
