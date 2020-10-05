namespace Stock
{
  public class Fable
  {
    public static int FableCost(int numFable)
    {
      return (numFable / 10) * 500 + (numFable % 10 / 3) * 225 + (numFable % 10 % 3) * 100;
    }
  }
}