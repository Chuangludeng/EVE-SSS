using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_SSS
{
    public class EVEItem
    {
        public int typeID;
        public string name;
        public int number;
        public int price;
        public int request_quantity;
    }

    public class Blueprint
    {
        public int typeID;
        public int targetID;
        public string targetName;
        public int targetQuantity;
    }
}
