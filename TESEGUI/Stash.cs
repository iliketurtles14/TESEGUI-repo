using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Stash
    {
        public string posX;
        public string posY;
        public string layer;
        public Stash(string posX, string posY,  string layer)
        {
            this.posX = posX;
            this.posY = posY;
            this.layer = layer;
        }
    }
}
