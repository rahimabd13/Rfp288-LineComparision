using System;
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
           
            CheckEquality checkequality = new CheckEquality(5, 4, 6, 3, 4, 3, 6, 5);

            checkequality.LengthCalculate();

            Console.ReadLine();
        }
    }
}
