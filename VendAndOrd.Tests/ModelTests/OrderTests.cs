using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendAndOrd.Models;

namespace VendAndOrd.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}