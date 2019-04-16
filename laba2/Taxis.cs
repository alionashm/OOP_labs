using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    [Serializable]
    public class Taxis :Bus
    {
        public int NumOfRoutes
        {
            get; set;
        }
        public Taxis() { }
        public Taxis(string brand, string model, int year, Engine engine, int len, string busapp, int numr) : base(brand,model,year, engine, len, busapp)
        {
            this.NumOfRoutes = numr;
        }
        public double Profit(int len)
        {
            double prof;
            prof = len * 0.42;
            return prof;
        }
    }
}
