using System;
using System.Collections.Generic;
using System.Text;

namespace num6
{
    class Movie : Media
    {
        protected string Title { get; set; }

        public int Year { get; set; }

        protected double Price { get; set; }

        protected int stock { get; set; }

        public int InStock()
        {
            return 0;
        }

        public void Sell (int qty)
        {

        }
    }
}
