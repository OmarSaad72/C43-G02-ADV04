using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper
    {
        public static List<int> FindOddNum(List<int> list)
        {
            List<int> result = new List<int>();
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 1)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }


        public static List<int> FindEvenNum(List<int> list)
        {
            List<int> result = new List<int>();
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }

        //public delegate bool FUnDelegate(int i);
        public static List<int> FindNum(List<int> list, Predicate<int> fUn)
        {
            List<int> result = new List<int>();
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (fUn.Invoke(list[i]))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
