using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
            Bread newBread = new Bread();
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

    [TestMethod]
        public void BreadCost_ReturnsCostOfOneLoaf_BreadCost()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(5, newBread.BreadCost());

        }

        [TestMethod]
        public void BreadCost_ReturnsCostOfTwoLoaves_BreadCost()
        {
            Bread newBread = new Bread(2);
            Assert.AreEqual(10, newBread.BreadCost());

        }

    
  }
}