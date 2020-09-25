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
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("How much Bread would you like?");
      string strBread = Console.ReadLine();
      int numBread = int.Parse(strBread);
      Console.WriteLine("How many Pastries would you like?");
      string strPastry = Console.ReadLine();
      int numPastry = int.Parse(strPastry);
      CustomerOrder cusOrder = new CustomerOrder(numBread, numPastry);
      Console.WriteLine("The total cost of your order is $" + cusOrder._totalOrderCost);
    }
  }
}