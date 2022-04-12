using System;
using System.Collections.Generic;
using System.Text;

namespace homework_04._12.Models
{
    class Milk : Product
    {
        public double Volume { get; set; }
        public double Fatrate { get; set; }

        public Milk(string name) : base(name)
        {

        }
    }
}
