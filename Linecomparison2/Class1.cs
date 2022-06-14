using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparison2
{
    internal class Class1
    {
        public  double  lengthofline(int x1,int x2,int y1,int y2)
        {

             double lengthofline=(double)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            return (double)lengthofline;
        }
    }
}
