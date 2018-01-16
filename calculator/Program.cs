using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace calculator
{
    public class AddInt
    {
        public int FirstNumber;
        public int SecondNumber;
        public void AddTwoNumbers()
        {
            Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " + (FirstNumber + SecondNumber));
        }
    }
    public class SubtractInt
    {
        public int FirstNumber;
        public int SecondNumber;
        public void SubtractTwoNumbers()
        {
            Console.WriteLine(FirstNumber + " - " + SecondNumber + " = " + (FirstNumber - SecondNumber));
        }
    }
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
