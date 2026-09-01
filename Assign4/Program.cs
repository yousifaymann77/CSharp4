using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion

            #region Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies andshelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] ShelfCopies = new int[2, 2] { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(ShelfCopies[1, 0]); 
            #endregion
            
            PrintWelcomeMessage();

            PrintBookTitle("Clean Code");

            int pages = 400;
            Console.WriteLine($"Before Method : {pages}");
            AddBonusPages(pages);
            Console.WriteLine($"After Method : {pages}");

            double[] prices1 = { 25.5, 40.0 };
            ApplyDiscount(prices1);
            Console.WriteLine(prices1[0]);


        }

        #region Write a method called PrintWelcomeMessage that takes no parameters and prints"Welcome to the Library!". Call it from Main.
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion
        #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title : {title}");
        }
        #endregion

        #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward.What do you expect to see, and why?
        
        // It will print 400 because the variable is passed by value which takes a copy of the variable and does not change the original one 
        static void AddBonusPages(int pages)
        {
            pages += 50;
            Console.WriteLine(pages);
        }
        #endregion

        #region Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?
        // It will print 20.5 because the array is passed by reference which means the original array is modified and the change is reflected outside the method.
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
            Console.WriteLine(prices[0]);
        } 
        #endregion
    }
}
