using System;
using System.Collections.Generic;
using System.Text;

namespace num6
{
    class Media 
    {
        public string Title { get; set; }

        public double Price { get; set; }

        public string ID { get; set; }

        public int Stock { get; set; }

        public bool InStock()
        {
            return true;
        }

        public void Sell(int qty)
        {

        }

       
    }
}
