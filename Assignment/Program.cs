namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region Part01
            // Done In Demo & Notes
            #endregion

            #region Part02
            List<Book> books = new List<Book>()
            {
                new Book("2323" , ".Net" , new string[]{"Andres","Hejlsberg" }, new DateTime(1/23/2002), 10000),
                new Book("7132" , "C#" , new string[]{"Jon","Skeet" }, new DateTime(7/2/2008), 20000),
                new Book("8868" , "Clean Architecture" , new string[]{"Robert","Martin" }, new DateTime(10/3/2017), 20000)
            };
            //Using User Defined Delgate:
            BookFuncDElegate bookFuncDElegate = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, bookFuncDElegate);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            ////LibraryEngine.ProcessBooks(books, BookFunctions.Details);
            
            //Using Built In Delegate:
            Func<Book,string> func = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, func.Invoke);
            //Func<Book,string> func = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(books, func.Invoke);
            #endregion
        }
    }
}
