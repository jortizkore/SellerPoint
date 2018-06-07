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
    public class LossesUnitTest
    {
        public LossesUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
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
            var loss = new Loss();
            var LostQuantity = 1;
            var p = new Product();
            p.Load(2);
            loss.Comment = $"Adding a lost for {p.Description} x {LostQuantity}";
            Assert.IsTrue(loss.Save(p, 1));
        }
        [TestMethod]
        public void SaveUnitTest_WhenLossObjectIdDoesntExist_ShouldBeFalse()
        {
            var loss = new Loss();
            var p = new Product();
            p.Load(12);
            p.Id = 0;
            Assert.IsFalse(loss.Save(p, 1));
        }

        [TestMethod]
        public void SaveUnitTest_WhenSaveALost_ProductQuantityGetsReduced()
        {
            var LostQuantity = 10;
            var TestProductID = 2;
            var loss = new Loss();
            var p = new Product();
            p.Load(TestProductID);
            var expectecResult = p.Quantity - LostQuantity;
            loss.Comment = $"Testing Product loss | {p.Description} x {LostQuantity}";
            loss.Save(p, LostQuantity);
            p.Load(TestProductID);
            Assert.AreEqual(expectecResult, p.Quantity);
        }


    }
}
