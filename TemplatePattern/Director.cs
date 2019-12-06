using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Director : Employer
    {
        public Director(string name, DateTime startDate, decimal rate) : base(name, startDate, rate)
        {
        }

        public override decimal Sallary()
        {
            return 1500000m;
        }
    }
}
