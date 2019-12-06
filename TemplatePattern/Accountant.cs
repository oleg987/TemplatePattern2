using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Accountant : Employer
    {
        public int Hours { get; set; }

        public Accountant(string name, DateTime startDate, decimal rate, int hours) : base(name, startDate, rate)
        {
            Hours = hours;
        }

        protected override decimal Base()
        {
            return Rate * Hours;
        }
    }
}
