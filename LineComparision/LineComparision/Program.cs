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
           
            LineCompare linecompare = new LineCompare(5, 4, 6, 7, 4, 3, 6, 5);

            linecompare.LengthCalculate();

            Console.ReadLine();
        }
    }
}
