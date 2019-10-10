using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiate the object
            Employee e = new Employee();

            // print default state
            e.PrintState();
            Console.WriteLine();

            e.SetName("William I. Baker");
            e.SetEmpId(509509);
            e.SetCurrPay(1234.50);

            e.PrintState();
            Console.WriteLine();
            Console.WriteLine("Name: {0}", e.GetName());

        }
    }
}
