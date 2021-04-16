using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemController : Controller
  {
    [HttpGet("/item")]
    public ActionResult Index()
    {
      List<Item> itemList = Item.GetAll();
      return View(itemList);
    }

    [HttpGet("/item/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/item")]
    public ActionResult Create(string name, double weight, string isPacked, string isPurchased)
    {
      bool packed = false;
      bool purchased = false;
      if(String.IsNullOrEmpty(name))
      {
        name = "Nameless";
      }
      if(isPacked == "on")
      {
        packed = true;
      }
      if(isPurchased == "on")
      {
        purchased = true;
      }
      Item myItem = new Item(name, weight, packed, purchased);
      return RedirectToAction("Index");
    }

    [HttpGet("/item/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }
  }
}