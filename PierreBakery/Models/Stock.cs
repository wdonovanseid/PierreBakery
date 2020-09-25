using System;

namespace Stock
{
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