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
        [Test]
        public void GetTotalPrice_ShouldReturnTotalForNonDiscountedItems()
        {
            // Arrange

            var checkout = new Checkout(new List<InventoryItem>() { new InventoryItem("A", 50) });

            // Act

            checkout.Scan("A");
            var result = checkout.GetTotalPrice();

            // Assert

            Assert.AreEqual(50, result);
        }
    }
}
