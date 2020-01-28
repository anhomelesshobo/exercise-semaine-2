using System;
using System.Collections.Generic;
using System.Text;

namespace num6
{
    class Magazine
    {
        public string Title { get; set; }

        public string Issue { get; set; }

        public double Price { get; set; }

        private int stock { get; set; }

        public int InStock()
        {
            return 0;
        }

        public void Sell(int qty)
        {

        }
    }
}
