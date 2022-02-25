using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendAndOrd.Models;
using System.Collections.Generic;
using System;


namespace VendAndOrd.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "test vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "test vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string vendor01 = "Tony's";
      string vendor02 = "Chapala";
      Vendor newVendor01 = new Vendor(vendor01);
      Vendor newVendor02 = new Vendor(vendor02);
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsSpecificCorrectVendor_Vendor()
    {
      //Arrange
      string vendor01 = "Tony's";
      string vendor02 = "Chapala";
      Vendor newVendor01 = new Vendor(vendor01);
      Vendor newVendor02 = new Vendor(vendor02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor02, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string description = "1 Bread";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Tony's";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);
      //Act
      List<Order> result = newVendor.Orders;
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}