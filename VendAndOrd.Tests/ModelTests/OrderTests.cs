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

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      //Arrange
      string order = "10 Bread";
      //Act
      Order newOrder = new Order(order);
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(order, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string order = "10 Bread";
      Order newOrder = new Order(order);
      //Act
      string updatedOrder = "5 Bread";
      newOrder.Description = updatedOrder;
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(updatedOrder, result);
    }


  }
}