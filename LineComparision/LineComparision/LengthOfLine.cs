﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
   public class LengthOfLine
    {
        int x1, x2, y1, y2;
        public LengthOfLine(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;

        }

        public void LengthCalculate()
        {
            double lengthofaline = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Length is :" + lengthofaline);
        }
    }
}
