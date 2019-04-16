using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    [Serializable]
    public class Engine
    {
        public int NumOfCylind
        {
            get; set;
        }
        public int Power
        {
            get; set;
        }
        public Engine() { }
        public Engine(int numcyl, int pow)
        {
            this.NumOfCylind = numcyl;
            this.Power = pow;
        }
    }
}
