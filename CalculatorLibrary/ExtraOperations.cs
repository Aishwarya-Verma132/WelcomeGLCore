using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class ExtraOperations
    {
        public string Concat(string a, string b)
        {
            return a + b;
        }
        public int Sq(int a)
        {
            return (int)Math.Sqrt(a);
        }
        public int AddNum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
