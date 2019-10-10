using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Employee
    {

        // fields
        private string empName;
        private int empId;
        private double currPay;

        // accessor and mutator methods
        // have to go through a method to get/set fields becasue they are private

        // Get
        public string GetName() { return empName; }
        public int GetEmpId() { return empId; }
        public double GetCurrPay() { return currPay; }

        // Set
        public void SetName (string name)
        {
            // perform validation
            if (name.Length > 15) { empName = name.Substring(0, 15); }
            else empName = name;
        }

        public void SetEmpId(int id) { empId = id; }
        public void SetCurrPay(double pay) { currPay = pay; }

        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", empName);
            Console.WriteLine("ID:\t{0}", empId);
            Console.WriteLine("Pay:\t{0}", currPay);
        }

    }
}
