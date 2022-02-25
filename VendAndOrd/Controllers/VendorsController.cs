using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendAndOrd.Models;

namespace VendAndOrd.Controllers
{
  public class VendorsControllers : Controller 
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
  }
}