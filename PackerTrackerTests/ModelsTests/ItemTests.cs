using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTrackerTests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreateItemInstance_Item()
    {
      Item newItem = new Item("Test", 1, true, true);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void ItemProperties_ReturnsProperties_True()
    {
      Item newItem = new Item("Test", 1.1, false, true);
      Assert.AreEqual("Test", newItem.Name);
      Assert.AreEqual(1.1, newItem.Weight);
      Assert.AreEqual(false, newItem.IsPacked);
      Assert.AreEqual(true, newItem.IsPurchased);
    }

    [TestMethod]
    public void ItemProperties_SetProperties_True()
    {
      Item newItem = new Item("Test", 1.1, false, false);
      newItem.Name = "Pants";
      newItem.Weight = 2.2;
      newItem.IsPacked = true;
      newItem.IsPurchased = true;
      Assert.AreEqual("Pants", newItem.Name);
      Assert.AreEqual(2.2, newItem.Weight);
      Assert.AreEqual(true, newItem.IsPacked);
      Assert.AreEqual(true, newItem.IsPurchased);
    }

    [TestMethod]
    public void GetAll_ReturnEmptyList_List()
    {
      List<Item> newList = new List<Item>();
      List<Item> itemList = Item.GetAll();
      CollectionAssert.AreEqual(newList, itemList);
    }

    [TestMethod]
    public void GetAll_ReturnList_List()
    {
      Item newItem = new Item("Test", 1.1, false, false);
      Item newerItem = new Item("Pants", 2.2, true, true);
      List<Item> newList = new List<Item>() { newItem, newerItem };
      List<Item> itemList = Item.GetAll();
      CollectionAssert.AreEqual(newList, itemList);
    }

    [TestMethod]
    public void Find_ReturnRightItem_Item()
    {
      Item newItem = new Item("Test", 1.1, false, false);
      Item newerItem = new Item("Pants", 2.2, true, true);
      Item foundItem = Item.Find(2);
      Assert.AreEqual(foundItem, newerItem);
    }
  }
}