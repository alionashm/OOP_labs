using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    [Serializable]
    public class Car:Vehicle
    {
        public int NumOfSeats
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public string Category
        {
            get; set;
        }
        public Car() { }
        public Car(string brand, string model,int year, Engine engine, int seat, string bodytype, string cat) : base(brand, model, year, engine)
        {
            this.NumOfSeats = seat;
            this.Type = bodytype;
            this.Category = cat;
        }
    }
}
