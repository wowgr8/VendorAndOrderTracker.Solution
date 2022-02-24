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
  }
}