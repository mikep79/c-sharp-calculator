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
            trialRun.IncrementNumber((trialRun.FirstNumber));

            var subtractTrial = new SubtractInt();
            subtractTrial.FirstNumber = 5;
            subtractTrial.SecondNumber = 7;
            subtractTrial.SubtractTwoNumbers();

            //Increment testNumb = new Increment();
            //testNumb.increm(10);
            Increment.increm(10);
            

        }
        
    }
    //public class Increment
    //{
    //    public void increm(int number)
    //    {
    //        Console.WriteLine(number);
    //    }
    //}
    public static class Increment
    {
        public static void increm(int number)
        {
            Console.WriteLine(number);
        }
    }
}
