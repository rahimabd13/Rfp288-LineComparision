﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            LengthOfLine lengthofline = new LengthOfLine(5, 4, 6, 3);

            lengthofline.LengthCalculate();

            Console.ReadLine();
        }
    }
}
