
namespace Demo
{
    public delegate int StringFun(string str);
    public delegate int Fun<T>(T Num1, T Num2);
    internal class Program
    {
        public static IEnumerable<int> OddNum { get; private set; }

        static void Main()
        {
            #region Delegate_Ex:1
            //StringFun fun = new StringFun(String_Functions.getCountUpperChars); // Syntax Suger
            //StringFun fun = String_Functions.getCountUpperChars;
            ////int result = fun.Invoke("Omar Saad");
            //int result = fun("Omar Saad"); // Syntax Suger
            //Console.WriteLine(result); 
            //StringFun fun = new StringFun(String_Functions.getCountLowererChars); // Syntax Suger
            //StringFun fun = String_Functions.getCountLowererChars;
            //int result = fun.Invoke("Omar Saad");
            ////int result = fun("Omar Saad"); // Syntax Suger
            //Console.WriteLine(result);
            #endregion
            #region Delegate_Ex:2{Non-Generic}
            //int[] Num = { 2, 4, 6, 3, 1, 5 };
            //Sorting.BubbleSort(Num , SortingTypes.CompareGrt);
            //foreach (int i in Num)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Delegate_Ex:3{Generic}
            //int[] Num = { 2, 4, 6, 3, 1, 5 };
            //Sorting.BubbleSort(Num , SortingTypes.CompareGrt);
            //foreach (int i in Num)
            //{
            //    Console.WriteLine(i);
            //}
            //string[] Names = { "Omar", "Ali", "Mai" };
            //Fun<string> fun = SortingTypes.SortDEC;
            //Sorting<string>.BubbleSort(Names , fun);
            //foreach (string  name in Names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #region Delegate_Ex:4
            //List<int> Num = Enumerable.Range(0, 100).ToList();
            //List<int> OddNum = Helper.FindNum(Num, ConditionFun.CheckOdd);
            //foreach (int odd in OddNum)
            //{
            //    Console.WriteLine(odd);
            //}

            //List<int> Num1 = Enumerable.Range(0, 100).ToList();
            //List<int> EvenNum = Helper.FindNum(Num1, ConditionFun.CheckOdd);
            //foreach (int Even in EvenNum)
            //{
            //    Console.WriteLine(Even);
            //}
            #endregion
            #region Delegate_Ex:5{Built In Delegate}
            Predicate<int> predicate = SomeFun.Test;
            predicate.Invoke(10);
            //predicate(10);
            Func<int, string> func = SomeFun.Cast;
            func(10);

            Action<string> action = SomeFun.Print;
            action("Omar");
            #endregion
        }
    }
}
