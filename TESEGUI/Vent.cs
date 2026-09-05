using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Vent
    {
        public string posX;
        public string posY;
        public string durability;
        public bool isFake;
        public Vent(string posX, string posY, string durability, bool isFake)
        {
            this.posX = posX;
            this.posY = posY;
            this.durability = durability;
            this.isFake = isFake;
        }
    }
}
