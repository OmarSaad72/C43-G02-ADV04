using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ConditionFun
    {
        public static bool CheckOdd(int Num)
        {
            return Num % 2 == 1;
        }
        public static bool CheckEven(int Num)
        {
            return Num % 2 == 0;
        }
    }
}
