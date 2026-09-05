using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Rock
    {
        public string posX;
        public string posY;
        public string durability;
        public Rock(string posX, string posY, string durability)
        {
            this.posX = posX;
            this.posY = posY;
            this.durability = durability;
        }
    }
}
