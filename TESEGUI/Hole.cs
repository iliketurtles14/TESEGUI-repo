using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Hole
    {
        public string posX;
        public string posY;
        public string percentOpen;
        public Hole(string posX, string posY, string percentOpen)
        {
            this.posX = posX;
            this.posY = posY;
            this.percentOpen = percentOpen;
        }
    }
}
