using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
            e.PrintState();
            Console.WriteLine();

            Employee e2 = new Employee("Bill Baker");
            e2.PrintState();
            Console.WriteLine();

            Employee e3 = new Employee("Bill, 509509, 1234.5");

        }
    }
}
