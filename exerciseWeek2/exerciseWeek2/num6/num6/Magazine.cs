using System;
using System.Collections.Generic;
using System.Text;

namespace num6
{
    class Magazine : Media
    {
        protected string Title { get; set; }

        public string Issue { get; set; }

        protected double Price { get; set; }

        private protected int stock { get; set; }

        public int InStock()
        {
            return 0;
        }

        public void Sell(int qty)
        {

        }
    }
}
