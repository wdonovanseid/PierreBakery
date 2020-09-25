using System;
using Stock;

namespace PierreBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here is the costs of our products today:");
      Console.WriteLine("All Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("All Pastries: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("How many Baguettes would you like?");
      string strBaguette = Console.ReadLine();
      int numBaguette = int.Parse(strBaguette);
      Console.WriteLine("How much Sourdough Bread would you like?");
      string strSourdough = Console.ReadLine();
      int numSourdough = int.Parse(strSourdough);
      Console.WriteLine("How much Rye Bread would you like?");
      string strRye = Console.ReadLine();
      int numRye = int.Parse(strRye);
      int numBread = numBaguette + numSourdough + numRye;
      Console.WriteLine("How many Pastries would you like?");
      string strPastry = Console.ReadLine();
      int numPastry = int.Parse(strPastry);
      CustomerOrder cusOrder = new CustomerOrder(numBread, numPastry);
      Console.WriteLine("The total cost of your order is $" + cusOrder._totalOrderCost);
    }
  }
}