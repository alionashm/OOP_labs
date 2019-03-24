using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Vehicle
    {
        public string Brand
        {
            get; set;
        }
        public string Model
        {
            get; set;
        }
        public int Year
        {
            get; set;
        }
        public Engine Engine
        {
            get; set;
        }
        public Vehicle(string br, string mod, int y, Engine someengine)
        {
            this.Brand = br;
            this.Model = mod;
            this.Year = y;
            this.Engine = someengine;
        }
    }
}
