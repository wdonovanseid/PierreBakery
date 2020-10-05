namespace Stock
{
  public class CustomerOrder
  {
    private int _breadOrder;
    private int _pastryOrder;
    private int _fableOrder;
    public int TotalOrderCost { get; set; }

    public CustomerOrder (int numBread, int numPastry, int numFable)
    {
      _breadOrder = numBread;
      _pastryOrder = numPastry;
      _fableOrder = numFable;
    }

    public int GetTotalCost()
    {
      return Bread.BreadCost(_breadOrder) + Pastry.PastryCost(_pastryOrder) + Fable.FableCost(_fableOrder);
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