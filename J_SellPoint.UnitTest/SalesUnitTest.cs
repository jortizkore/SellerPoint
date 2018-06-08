using System;
using System.Text;
using System.Collections.Generic;
using J_SellPoint.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace J_SellPoint.UnitTest
{
    /// <summary>
    /// Summary description for SalesUnitTest
    /// </summary>
    [TestClass]
    public class SalesUnitTest
    {
        private int idTestProd = 12;
        private int sellQuantity = 1;
        public SalesUnitTest()
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
        public void SaveSale_WhenSaleIsFilled_ShouldBeTrue()
        {
            var sale = new Sale();
            var prod = new Product();

            prod.Load(idTestProd);
            Assert.IsTrue(sale.Save(prod, sellQuantity));
        }

        [TestMethod]
        public void SaveSale_WhenSaleIsEmpty_ShouldBeFalse()
        {
            var sale = new Sale();
            var prod = new Product();
            Assert.IsFalse(sale.Save(prod, sellQuantity));
        }

        [TestMethod]
        public void SaveSale_WhenSaleHaveInvalidProd_ShouldBeFalse()
        {
            var sale = new Sale();
            var prod = new Product();
            prod.Load(idTestProd);
            prod.Id = 0;
            Assert.IsFalse(sale.Save(prod, sellQuantity));
        }

        [TestMethod]
        public void SaveSale_WhenSaleIsDone_ShouldDicrementProdQuantity()
        {
            var sale = new Sale();
            var prod = new Product();

            prod.Load(idTestProd);
            var expectedQuantity = prod.Quantity - sellQuantity; // We expect quantity to dicrement

            sale.Save(prod, sellQuantity);
            prod.Load(idTestProd);          // Refresh prod quantity

            Assert.AreEqual(prod.Quantity, expectedQuantity);
        }

    }
}
