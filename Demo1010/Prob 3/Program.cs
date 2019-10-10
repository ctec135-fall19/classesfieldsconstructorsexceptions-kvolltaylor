using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region region 1
            for (int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                // if you don't want to be so verbose you could put something like:
                // cond 2 = red light is flashing
                // nested for loops that will count through sequentially all possible conditions
                // go through each condition's list of nos and yesses 
                for (int cond2 = 0; cond2 <= 1; cond2++)
                {
                    for (int k = 0; k <= 1; k++)
                    {
                        if (printerPrintsCondition == 0 && cond2 2 == 0 & k == 0){
                        // call action
                        //print out conditions
                        Console.WriteLine("Printer prints condition");
                        //printer jam
                        }
                        if (printerPrintsCondition == 0 && cond2 2 == 0 & k == 1){
                            // call action
                            //printer jam
                        }
                    }
                }

                #endregion
    #region region 2
    for (int i=0; i<=7; i++>){
        switch (i)
        {
            case 0:
                // print out conditions
                // call action methods for NO, no, NO
                break;
            case 1:

    }

#endregion 
        }

        //to create methods you want something on the same hierarchy as main
        public void CheckInk()
        {
            Console.WriteLine("Check ink and replace if empty");
            
        }
        // create 4 methods just as above
    }
}
