﻿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace calculator.Addition
{
    public class AddInt
    {
        public int FirstNumber;
        public int SecondNumber;
        public void AddTwoNumbers()
        {
            Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " + (FirstNumber + SecondNumber));
        }
        public void IncrementNumber(int number)
        {
            number++;
            Console.WriteLine( (number - 1) + " + 1 = " + number);
        }
    }
}
