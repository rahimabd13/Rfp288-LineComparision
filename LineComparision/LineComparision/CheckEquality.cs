using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class CheckEquality
    {
        int x1, x2, y1, y2;
        int x3, x4, y3, y4;
        public CheckEquality(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.x3 = x3;
            this.x4 = x4;
            this.y3 = y3;
            this.y4 = y4;
          
        }

        public void LengthCalculate()
        {
            double lengthofaline1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Length is :" + lengthofaline1);

            double lengthofaline2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("The Length is :" + lengthofaline2);


            if (lengthofaline1 == lengthofaline2)
            {
                Console.WriteLine("Line1 And Line2 is Equal");
            }
            else
            {
                Console.WriteLine("Line1 And Line2 is Not Equal");
            }


        }


    }
    
}
