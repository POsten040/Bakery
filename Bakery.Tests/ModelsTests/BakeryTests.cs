using Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Items.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void MakeBread_CreatesBreadObject_True()
    {
      int input = 5;
      Bread uOrder = new Bread(input);
      Assert.AreEqual(typeof(Bread), uOrder.GetType());
    }
  }
}
      