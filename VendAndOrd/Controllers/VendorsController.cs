using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendAndOrd.Models;

namespace VendAndOrd.Controllers
{
  public class VendorsController : Controller 
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> fullListVendors = Vendor.GetAll();
      return View(fullListVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDesc)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDesc);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return  View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription, string orderDeliveryDate, int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDescription, orderDeliveryDate, orderPrice);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("show", model);
    }
  }
}