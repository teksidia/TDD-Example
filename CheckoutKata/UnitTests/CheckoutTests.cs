using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CheckoutKata.UnitTests
{
    [TestFixture]
    public class CheckoutTests
    {
        private List<InventoryItem> _inventory;
        private List<Offer> _offers;

        [SetUp]
        public void SetUp()
        {
            _inventory = new List<InventoryItem>
            {
                new InventoryItem("A", 50),
                new InventoryItem("B", 30),
                new InventoryItem("C", 20),
                new InventoryItem("D", 15)
            };

            _offers = new List<Offer>
            {
                new Offer("A", 3, 130),
                new Offer("B", 2, 45)
            };
        }

        [TestCase("A", 50)]
        [TestCase("B", 30)]
        [TestCase("C", 20)]
        [TestCase("D", 15)]
        [TestCase("A,B", 80)]
        [TestCase("C,D", 35)]
        [TestCase("A,A,A", 130)]
        [TestCase("B,B", 45)]
        [TestCase("A,A,A,A", 180)]
        [TestCase("B,A,B", 95)]
        public void GetTotalPrice_ShouldReturnTotal(string basketItems, int expectedTotal)
        {
            // Arrange

            var checkout = new Checkout(_inventory, _offers);

            // Act

            foreach (var item in basketItems.Split(','))
            {
                checkout.Scan(item);
            }

            var result = checkout.GetTotalPrice();

            // Assert

            Assert.AreEqual(expectedTotal, result);
        }
    }
}
