using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }
    }
}
