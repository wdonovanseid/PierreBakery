using System;

namespace Stock
{
  public class CustomerOrder
  {
    private int _breadOrder { get; set; }
    private int _pastryOrder { get; set; }
    private int _fableOrder { get; set; }
    public int _totalOrderCost { get; set; }

    public CustomerOrder (int numBread, int numPastry, int numFable)
    {
      _breadOrder = numBread;
      _pastryOrder = numPastry;
      _fableOrder = numFable;
      _totalOrderCost = GetTotalCost(numBread, numPastry, numFable);
    }

    private int GetTotalCost (int numBread, int numPastry, int numFable)
    {
      return Bread.BreadCost(numBread) + Pastry.PastryCost(numPastry) + Fable.FableCost(numFable);
    }
  }
  public class Bread
  {
    public static int BreadCost(int numBread)
    {
      return ((numBread / 2) + (numBread % 2)) * 5;
    }
  }
  public class Pastry
  {
    public static int PastryCost(int numPastry)
    {
      return (numPastry / 3) * 5 + (numPastry % 3) * 2;
    }
  }
  public class Fable
  {
    public static int FableCost(int numFable)
    {
      return (numFable / 10) * 500 + (numFable % 10 / 3) * 225 + (numFable % 10 % 3) * 100;
    }
  }
}