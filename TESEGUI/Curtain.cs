using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Curtain
    {
        public string posX;
        public string posY;
        public string type;
        public Curtain(string posX, string posY, string type)
        {
            this.posX = posX;
            this.posY = posY;
            this.type = type;
        }
    }
}
