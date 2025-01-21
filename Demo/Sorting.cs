//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo
//{
//    internal class Sorting
//    {
//        public static void BubbleSort<T>(T[] array, Fun<T> sorting)
//        {
//            if (array != null)
//            {

//                for (int i = 0; i < array.Length; i++)
//                {
//                    for (int j = 0; j < array.Length - i - 1; j++)
//                    {
//                        //if (array[j] < array[j + 1])
//                        if (sorting.Invoke(array[j], array[j + 1]))
//                            Swap(ref array[j], ref array[j + 1]);
//                    }
//                }
//            }
//        }
//        private static void Swap<T>(ref T x, ref T y)
//        {
//            T temp = x; x = y; y = temp;
//        }
//    }
//}
