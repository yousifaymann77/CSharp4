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



        }
    }
}
