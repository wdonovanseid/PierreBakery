using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PierreBakeryTests
  {

    [TestMethod]
    public void CustomerOrderConstructor_MakesCustomerOrderInstance_CustomerOrder()
    {
      CustomerOrder testCustomerOrder = new CustomerOrder(1,2,3);
      Assert.AreEqual(typeof(CustomerOrder), testCustomerOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_Int()
    {
      CustomerOrder testCustomerOrder = new CustomerOrder(1,2,3);
      int result = testCustomerOrder._breadOrder;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void BreadCost_GetCorrectCostOfOneBread_Int()
    {
      int testBread = 1;
      int testBreadCost = Bread.BreadCost(testBread);
      Assert.AreEqual(5, testBreadCost);
    }

    [TestMethod]
    public void BreadCost_GetCorrectCostOfMultipleBread_Int()
    {
      int testBread = 4;
      int testBreadCost = Bread.BreadCost(testBread);
      Assert.AreEqual(10, testBreadCost);
    }

    [TestMethod]
    public void PastryCost_GetCorrectCostOfOnePastry_Int()
    {
      int testPastry = 1;
      int testPastryCost = Pastry.PastryCost(testPastry);
      Assert.AreEqual(2, testPastryCost);
    }

    [TestMethod]
    public void PastryCost_GetCorrectCostOfMultiplePastry_Int()
    {
      int testPastry = 7;
      int testPastryCost = Pastry.PastryCost(testPastry);
      Assert.AreEqual(12, testPastryCost);
    }

    [TestMethod]
    public void FableCost_GetCorrectCostOfOneFableBreadStick_Int()
    {
      int testFable = 1;
      int testFableCost = Fable.FableCost(testFable);
      Assert.AreEqual(100, testFableCost);
    }

    [TestMethod]
    public void FableCost_GetCorrectCostOfMultipleFableBreadStick_Int()
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