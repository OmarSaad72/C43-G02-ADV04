using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingTypes
    {
        public static bool CompareGrt(int x , int y) // Sorting ASC
        {
            return x > y;
        }
        public static bool CompareLess(int x , int y) // Sorting DEC
        {
            return x < y;
        }

        public static bool SortASC(string  x, string  y) { return x?.Length > y?.Length; }
        public static bool SortDEC(string  x, string  y) { return x?.Length < y?.Length; }
    }
}
