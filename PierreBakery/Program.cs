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
      Console.WriteLine("The Fabled BreadStick: Buy 1 for $100, 3 for $75 each or 10 for $50 each.");
      Console.WriteLine("How many Baguettes would you like?");
      string strBaguette = Console.ReadLine();
      int value;
      int numBaguette = 0;
      if (int.TryParse(strBaguette, out value) && int.Parse(strBaguette) >= 0)
      {
        numBaguette = int.Parse(strBaguette);
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
        Main();
      }
      Console.WriteLine("How much Sourdough Bread would you like?");
      string strSourdough = Console.ReadLine();
      int numSourdough = 0;
      if (int.TryParse(strSourdough, out value) && int.Parse(strSourdough) >= 0)
      {
        numSourdough = int.Parse(strSourdough);
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
        Main();
      }
      Console.WriteLine("How much Rye Bread would you like?");
      string strRye = Console.ReadLine();
      int numRye = 0;
      if (int.TryParse(strRye, out value) && int.Parse(strRye) >= 0)
      {
        numRye = int.Parse(strRye);
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
        Main();
      }
      int numBread = numBaguette + numSourdough + numRye;
      Console.WriteLine("How many Pastries would you like?");
      string strPastry = Console.ReadLine();
      int numPastry = 0;
      if (int.TryParse(strPastry, out value) && int.Parse(strPastry) >= 0)
      {
        numPastry = int.Parse(strPastry);
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
        Main();
      }
      Console.WriteLine("How many Fabled Breadsticks would you like?");
      string strFable = Console.ReadLine();
      int numFable = 0;
      if (int.TryParse(strFable, out value) && int.Parse(strFable) >= 0)
      {
        numFable = int.Parse(strFable);
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
        Main();
      }
      CustomerOrder cusOrder = new CustomerOrder(numBread, numPastry, numFable);
      Console.WriteLine("The total cost of your order is $" + cusOrder._totalOrderCost);
      Console.WriteLine("Buy more?");
    }
  }
}