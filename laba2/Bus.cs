using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    [Serializable]
    public class Bus :Vehicle
    {
        public int Length
        {
            get; set;
        }
        public string Appointment
        {
            get; set;
        }
        public Bus() { }
        public Bus(string brand, string model, int year, Engine engine, int len, string busapp) : base(brand, model, year, engine)
        {
            this.Appointment = busapp;
            this.Length = len;
        }
    }
}
