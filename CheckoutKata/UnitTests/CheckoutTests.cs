﻿using System;
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
        }

        [TestCase("A", 50)]
        [TestCase("B", 30)]
        [TestCase("C", 20)]
        [TestCase("D", 15)]
        public void GetTotalPrice_ShouldReturnTotalForNonDiscountedItems(string sku, int expectedTotal)
        {
            // Arrange

            var checkout = new Checkout(_inventory);

            // Act

            checkout.Scan(sku);
            var result = checkout.GetTotalPrice();

            // Assert

            Assert.AreEqual(expectedTotal, result);
        }
    }
}