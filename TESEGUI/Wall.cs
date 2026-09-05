using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Wall
    {
        public string posX;
        public string posY;
        public string durability;
        public Wall(string posX, string posY, string durability)
        {
            this.posX = posX;
            this.posY = posY;
            this.durability = durability;
        }
    }
}
