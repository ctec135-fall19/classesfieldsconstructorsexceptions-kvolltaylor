using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize some variables in calling method
            // showing both a reference type and a value type
            string[] strArray = new string[] { "one", "two", "three" };
            int someInt = 42;

            //print out values
            Console.WriteLine("values before method call");
            Console.WriteLine("someInt: {0}", someInt);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // call method
            myMethod(someInt, strArray);
            Console.ReadLine();

            //print out values
            // because someInt is passed by value it will remain the same after the method call, 42
            // the postion in the array for "two" is changed to "twenty-two" becaue it is passed by reference
            // passing by reference allows you to change the values
            Console.WriteLine("values before method call");
            Console.WriteLine("someInt: {0}", someInt);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //demo overloading
            myMethod(strArray);

            //print out values
            Console.WriteLine("values before method call");
            Console.WriteLine("someInt: {0}", someInt);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

        }

        // method that demonstrates call by value and call by reference
        static void myMethod(int arg1, string[] arg2)
        {
            arg1 = 99;
            arg2[1] = "twenty-two";
        }

        //creating a second method by the name of myMethod
        // this gets called because it was given a different argument 
        // this implementation has different types of arguments it calls for
        // this myMethod gets called based on the parameter
        static void myMethod(string[] arg2)
        {
            arg2[0] = "seven";
        }

    }
}
