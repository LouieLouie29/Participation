using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }
        public Toy()
        {
            Name = "";
            Price = 0;
        }

        public string GetAisle()
        {
            return Aisle;
        }

        

    }
}
