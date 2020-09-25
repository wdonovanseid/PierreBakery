using System;
using System.Collections.Generic;
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
      List<int> productNumOrder = new List<int> {};
      string[] productArray = {"Baguettes", "Sourdough Breads", "Rye Breads", "Pastries", "Fabled Breadsticks"};
      foreach (string productName in productArray)
      {
        productNumOrder.Add(GetProductNum(productName));
      }
      CustomerOrder cusOrder = new CustomerOrder(productNumOrder[0] + productNumOrder[1] + productNumOrder[2], productNumOrder[3], productNumOrder[4]);
      Console.WriteLine("The total cost of your order is $" + cusOrder._totalOrderCost);
      EndProgram();
    }
    public static int GetProductNum(string productName)
    {
      Console.WriteLine("How many " + productName + " would you like?");
      string strProduct = Console.ReadLine();
      int value;
      if (int.TryParse(strProduct, out value) && int.Parse(strProduct) >= 0)
      {
        return int.Parse(strProduct);
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
        return GetProductNum(productName);
      }
    }

    public static void EndProgram()
    {
      Console.WriteLine("Buy more? Enter 'Y' for yes; 'N' for no");
      string yesOrNo = Console.ReadLine();
      if (yesOrNo.ToUpper() == "Y")
      {
        Main();
      }
      else if (yesOrNo.ToUpper() == "N")
      {
        System.Environment.Exit(1);
      }
      else
      {
        Console.WriteLine("Please enter 'Y' or 'N'.");
        EndProgram();
      }
    }
  }
}