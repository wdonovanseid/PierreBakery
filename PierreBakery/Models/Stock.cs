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
}