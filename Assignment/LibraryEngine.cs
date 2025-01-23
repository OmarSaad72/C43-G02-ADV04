using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string BookFuncDElegate(Book B);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist, BookFuncDElegate fPtr)
        {
            {
                foreach (Book B in blist)
                {
                    if (B != null && fPtr != null)
                        Console.WriteLine(fPtr(B));
                }
            }
        }
    }
}
