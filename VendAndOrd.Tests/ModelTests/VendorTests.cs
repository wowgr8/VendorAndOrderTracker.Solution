using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendAndOrd.Models;
using System;

namespace VendAndOrd.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfCategory_Vendor()
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
  }
}