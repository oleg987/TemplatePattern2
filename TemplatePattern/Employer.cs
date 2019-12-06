using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class Employer
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Rate { get; set; }

        protected Employer(string name, DateTime startDate, decimal rate)
        {
            Name = name;
            StartDate = startDate;
            Rate = rate;
        }

        public virtual decimal Sallary()
        {
            return Base() + Bonus() + Expirience();
        }
        protected virtual decimal Base()
        {
            return Rate * 30;
        }
        protected virtual decimal Bonus()
        {
            return 0;
        }
        protected virtual decimal Expirience()
        {
            return Rate * (DateTime.Today - StartDate).Days / 30;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"StartDate: {StartDate.ToShortDateString()}\n" +
                $"Rate: {Rate}\n" +
                $"Sallary: {Sallary()}\n\n";
        }
    }
}
