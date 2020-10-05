namespace Stock
{
  public class Bread
  {
    public static int BreadCost(int numBread)
    {
      return ((numBread / 2) + (numBread % 2)) * 5;
    }
  }
}