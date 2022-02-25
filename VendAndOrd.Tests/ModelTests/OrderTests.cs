using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendAndOrd.Models;
using System;
using System.Collections.Generic;

namespace VendAndOrd.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order> {};
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}