using System;
using System.Collections.Generic;
using System.Text;

namespace TESEGUI
{
    public class Alert
    {
        public string posX;
        public string posY;
        public string type;
        public string dValue;
        public Alert(string posX, string posY, string type, string dValue)
        {
            this.posX = posX;
            this.posY = posY;
            this.type = type;
            this.dValue = dValue;
        }
    }
}
