using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main()
        {
            Worker worker = new Worker("Ben", new DateTime(2001, 02, 15), 100m, 12);
            Worker worker1 = new Worker("Sam", new DateTime(2012, 10, 11), 120m, 10);

            Manager manager = new Manager("John", new DateTime(2010, 12, 03), 50m, 15, 120000m);
            Manager manager1 = new Manager("Kate", new DateTime(2010, 12, 03), 50m, 8, 230000m);

            Accountant accountant = new Accountant("Marta", new DateTime(1999, 06, 12), 10.6m, 80);
            Accountant accountant1 = new Accountant("Alice", new DateTime(2009, 08, 22), 14.2m, 68);

            Clerk clerk = new Clerk("Clark", new DateTime(2002, 12, 05), 45m);
            Clerk clerk1 = new Clerk("David", new DateTime(2012, 12, 21), 54.9m);            
            
            Employer[] employers = new Employer[] { worker, worker1, manager, manager1, accountant, accountant1, clerk, clerk1 };

            foreach (var item in employers)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
