using Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Items.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
    [TestMethod]
    public void MakeBread_CreatesBreadObject_True()
    {
      int input = 5;
      Bread uOrder = new Bread(input);
      Assert.AreEqual(typeof(Bread), uOrder.GetType());
    }
    [TestMethod]
    public void MakePastry_CreatesPastryObject_True()
    {
      int input = 5;
      Pastry uOrder = new Pastry(input);
      Assert.AreEqual(typeof(Pastry), uOrder.GetType());
    }
    [TestMethod]
    public void BreadOrder_CalculatesPriceOfBreadOrder_Int()
    {
      int input = 1;
      Bread uOrder = new Bread(input);
      int result = uOrder.BreadOrder();
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void BreadOrder_CalculatesSalePriceOfBreadOrder_Int()
    {
      int input = 5;
      Bread uOrder = new Bread(input);
      int result = uOrder.BreadOrder();
      Assert.AreEqual(15, result);
    }
    [TestMethod]
    public void PastryOrder_CalculatePriceOfPastry_Int()
    {
      int input = 1;
      Pastry uOrder = new Pastry(input);
      int result = uOrder.PastryOrder();
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void PastryOrder_CalculateSalePriceOfPastry_Int()
    {
      int input = 4;
      Pastry uOrder = new Pastry(input);
      int result = uOrder.PastryOrder();
      Assert.AreEqual(7, result);
    }
    [TestMethod]
    private void GetAll_ReturnsTotalBreadOrder_Int()
    {
      Bread uOrder = new Bread(5);
      int u = Bread.GetAll();
      Assert.AreEqual(typeof(int), u);
    }
    [TestMethod]
    public void BreadOrder_CalculateTotalCostOfBreadOrders_Int()
    {
      Bread uOrder = new Bread(5);
      Bread yOrder = new Bread(2);
      int total = Bread.GetAll();
      Assert.AreEqual(5, total);
    }
  }
}
      