using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPrograms
{
    internal class Factorial
    {
        public int Fact(int n)
        {
            int value = 1;
            while (n > 0)
            {
                value *= n--;
            }
            return value;
        }
    }
}
