using System;
using System.Text;
using System.Collections.Generic;
using J_SellPoint.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using J_SellPoint.Classes;

namespace J_SellPoint.UnitTest
{
    /// <summary>
    /// Summary description for LossesUnitTest
    /// </summary>
    [TestClass]
    public class PurchasesUnitTest
    {
        public PurchasesUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext _testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SaveUnitTest_WhenLossObjectIsFilled_ShouldBeTrue()
        {
            var Purchase = new Purchase();
            var LostQuantity = 1;
            var p = new Product();
            p.Load(2);
            Purchase.Comment = $"Adding a purchase for {p.Description} x {LostQuantity}";
            Assert.IsTrue(Purchase.Save(p, 1));
        }
        [TestMethod]
        public void SaveUnitTest_WhenLossObjectIdDoesntExist_ShouldBeFalse()
        {
            var Purchase = new Purchase();
            var p = new Product();
            p.Load(12);
            p.Id = 0;
            Assert.IsFalse(Purchase.Save(p, 1));
        }

        [TestMethod]
        public void SaveUnitTest_WhenSaveALost_ProductQuantityGetsReduced()
        {
            var PurchaseQuantity = 1;
            var TestProductID = 2;
            var purchase = new Purchase();
            var p = new Product();
            p.Load(TestProductID);
            var expectecResult = p.Quantity + PurchaseQuantity;
            purchase.Comment = $"Testing Product purchase | {p.Description} x {PurchaseQuantity}";
            purchase.Save(p, PurchaseQuantity);
            p.Load(TestProductID);
            Assert.AreEqual(expectecResult, p.Quantity);
        }


    }
}
