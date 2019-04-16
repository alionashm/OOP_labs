using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    [Serializable]
    public class Truck :Vehicle
    {
        public int LoadCapacity
        {
            get; set;
        }
        public int NumOfAxles
        {
            get; set;
        }
        public Truck() { }
        public Truck(string brand, string model, int year, Engine engine, int cap, int axle) : base(brand, model, year, engine)
        {
            this.LoadCapacity = cap;
            this.NumOfAxles = axle;
        }
    }
}
