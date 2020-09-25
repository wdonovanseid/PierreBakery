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
      //Arrange
      int testBread = 4;
      //Act
      int testBreadCost = Bread.BreadCost(testBread);
      //Assert
      Assert.AreEqual(10, testBreadCost);
    }
  }
}