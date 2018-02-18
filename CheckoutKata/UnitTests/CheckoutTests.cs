using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CheckoutKata.UnitTests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void GetTotalPrice_ShouldReturnTotal()
        {
            // Arrange

            var checkout = new Checkout();

            // Act

            checkout.Scan("A");
            var result = checkout.GetTotalPrice();

            // Assert

            Assert.AreEqual(1, result);
        }
    }
}
