namespace Demo
{
    public delegate int StringFun(string str);
    public delegate int IntFun(int Num1 , int Num2);
    internal class Program
    {
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
            #region Delegate_Ex:2
            //int[] Num = { 2, 4, 6, 3, 1, 5 };
            //Sorting.BubbleSort(Num , SortingTypes.CompareGrt);
            //foreach (int i in Num)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
        }
    }
}
