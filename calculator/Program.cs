using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//import classes
using calculator.Addition;
using calculator.Subtraction;

namespace calculator
{
   
    class Program
    {
        static void Main(string[] args)
        {
            AddInt trialRun = new AddInt();
            trialRun.FirstNumber = 5;
            trialRun.SecondNumber = 7;
            trialRun.AddTwoNumbers();

            var subtractTrial = new SubtractInt();
            subtractTrial.FirstNumber = 5;
            subtractTrial.SecondNumber = 7;
            subtractTrial.SubtractTwoNumbers();

        }
    }
}
