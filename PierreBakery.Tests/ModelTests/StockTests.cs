using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PierreBakeryTests
  {
    [TestMethod]
    public void BreadCost_GetCorrectCostOfBread_Int()
    {
      int testBread = 4;
      int testBreadCost = Bread.BreadCost(testBread);
      Assert.AreEqual(10, testBreadCost);
    }

    [TestMethod]
    public void PastryCost_GetCorrectCostOfPastry_Int()
    {
      int testPastry = 7;
      int testPastryCost = Pastry.PastryCost(testPastry);
      Assert.AreEqual(12, testPastryCost);
    }

    [TestMethod]
    public void FableCost_GetCorrectCostOfFableBreadStick_Int()
    {
      int testFable = 15;
      int testFableCost = Fable.FableCost(testFable);
      Assert.AreEqual(925, testFableCost);
    }

    [TestMethod]
    public void CustomerOrder_GetCorrectTotalCost_Int()
    {
      CustomerOrder testOrder = new CustomerOrder(4,7,15);
      Assert.AreEqual(947, testOrder.TotalOrderCost);
    }
  }
}