using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Employee
    {

        // field
        private string empName;

        // properties
        // you get two default methods, get and set
        public string Name
        {
            get { return empName; }
            set
            {
                // perform validation
                if (value.Length > 15) { empName = value.Substring(0, 15); }
                else empName = value;
            }
        }

        // automatic properties
        public int ID { get; set; }
        public double Pay { get; set; }

        // constructors
        // master
        // no return type on master
        // use master to set all the parameters
        public Employee(string name, int id, double pay)
        {
            Name = name;
            ID = id;
            Pay = pay;
        }

        // if you create a master constructor you have to define your own default constructor
        public Employee() : this ("none",0, 0.0) { }

        // this constructor will use name as a parameter and then fill in the other values
        public Employee(string name) : this (name, 0, 0.0) { }

        public void PrintState()
        {
            //first two of below show 2 different ways to access the same field
            Console.WriteLine("Name:\t{0}", empName);
            Console.WriteLine("Name\t{0}", Name);
            Console.WriteLine("ID:\t{0}", ID);
            Console.WriteLine("Pay:\t{0}", Pay);
        }

    }
}
