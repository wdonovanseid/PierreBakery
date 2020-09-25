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
  }
}