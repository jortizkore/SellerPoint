using System;
using J_SellPoint.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace J_SellPoint.UnitTest
{
    [TestClass]
    public class ProductUnitTests
    {
        [TestMethod]
        public void SaveProduct_WhenProductIsFilled_ShouldBeTrue()
        {
            var prod = new Product("testDescription", 1000, 2000);
            var result = prod.Save();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SaveProduct_WhenProductIsEmpty_ShouldBeFalse()
        {
            var prod = new Product();
            var result = prod.Save();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UpdateProduct_WhenProductIsEmpty_ShouldBeTrue()
        {
            var prod = new Product();
            prod.Load(12);
            prod.Description = "updated";
            var result = prod.Update();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdateProduct_WhenProductIsEmpty_ShouldBeFalse()
        {
            var prod = new Product();
            var result = prod.Update();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddQuantity_WhenPlusIsPositiveGreatherThanZero_ShouldBeTrue()
        {
            var prod = new Product();
            var result = prod.AddQuantity(2, 1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddQuantity_WhenPlus_ShouldIncrementTheQuantitySetted()
        {
            var plus = 1;
            var prod = new Product();
            prod.Load(2);
            var afterQuantity = prod.Quantity + plus;
            prod.AddQuantity(2, plus);
            prod.Load(2);
            Assert.AreEqual(prod.Quantity, afterQuantity);
        }

        [TestMethod]
        public void AddQuantity_WhenPlusIsZero_ShouldBeFalse()
        {
            var prod = new Product();
            var result = prod.AddQuantity(1, 0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddQuantity_WhenPlusIsNegative_ShouldBeFalse()
        {
            var prod = new Product();
            var result = prod.AddQuantity(1, -1);
            Assert.IsFalse(result);
        }
    }
}
