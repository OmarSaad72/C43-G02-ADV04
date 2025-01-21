using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SomeFun
    {
        public static bool Test(int Num) { return (Num > 0); }
        public static string Cast(int Num) { return Num.ToString(); }
        public static void Print(string Name) { Console.WriteLine($"Hello{Name}"); }
    }
}
