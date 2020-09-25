using System;

namespace Stock
{
  public class CustomerOrder
  {
    private int _breadOrder { get; set; }
    private int _pastryOrder { get; set; }
    public int _totalOrderCost { get; set; }

    public CustomerOrder (int numBread, int numPastry)
    {
      _breadOrder = numBread;
      _pastryOrder = numPastry;
      _totalOrderCost = GetTotalCost(numBread, numPastry);
    }

    private int GetTotalCost (int numBread, int numPastry)
    {
      return Bread.BreadCost(numBread) + Pastry.PastryCost(numPastry);
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
}