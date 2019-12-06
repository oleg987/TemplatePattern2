using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Clerk : Employer
    {
        public Clerk(string name, DateTime startDate, decimal rate) : base(name, startDate, rate)
        {
            
        }

        protected override decimal Base()
        {
            return base.Base() + 1500m;
        }
    }
}
