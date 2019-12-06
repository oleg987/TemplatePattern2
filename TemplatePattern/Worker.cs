using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Worker : Employer
    {
        public int Turns { get; set; }

        public Worker(string name, DateTime startDate, decimal rate, int turns) : base(name, startDate, rate)
        {            
            Turns = turns;
        }

        protected override decimal Base()
        {
            return Rate * Turns;
        }

        protected override decimal Bonus()
        {
            if (Turns >= 12)
            {
                return 1000m;
            }
            return 0;
        }

    }
}
