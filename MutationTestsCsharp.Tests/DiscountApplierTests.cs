using NUnit.Framework;

namespace MutationTestsCsharp.Tests
{
    public class DiscountApplierTests
    {
        [Test]
        public void GetDiscountPercentageValue_Should_Return0Discount_When_1ProductProvided()
        {
            var discountApplier = new DiscountApplier();
            var products = new[] {new Product("Product 1", 25, 1)};

            var discountValue = discountApplier.GetDiscountPercentageValue(products);
            Assert.AreEqual(0, discountValue);
        }
        
        [Test]
        public void GetDiscountPercentageValue_Should_Return10PercentDiscount_When_TotalQuantityIs12()
        {
            var discountApplier = new DiscountApplier();
            var products = new[] {new Product("Product 1", 1, 6), new Product("Product 2", 1, 6)};

            var discountValue = discountApplier.GetDiscountPercentageValue(products);
            Assert.AreEqual(10, discountValue);
        }
        
        [Test]
        public void GetDiscountPercentageValue_Should_Return15PercentDiscount_When_TotalQuantityIs56()
        {
            var discountApplier = new DiscountApplier();
            var products = new[] {new Product("Product 1", 1, 28), new Product("Product 2", 1, 28)};

            var discountValue = discountApplier.GetDiscountPercentageValue(products);
            Assert.AreEqual(15, discountValue);
        }
        
        [Test]
        public void GetDiscountPercentageValue_Should_Return5PercentDiscount_When_TotalPriceIs110AndQuantityIs2()
        {
            var discountApplier = new DiscountApplier();
            var products = new[]{new Product("Product 1", 100, 1), new Product("Product 2", 10, 1)};

            var discountValue = discountApplier.GetDiscountPercentageValue(products);
            Assert.AreEqual(5, discountValue);
        }
        
        [Test]
        public void GetDiscountPercentageValue_Should_Return10PercentDiscount_When_TotalPriceIs550AndQuantityIs2()
        {
            var discountApplier = new DiscountApplier();
            var products = new[]{new Product("Product 1", 500, 1), new Product("Product 2", 50, 1)};

            var discountValue = discountApplier.GetDiscountPercentageValue(products);
            Assert.AreEqual(10, discountValue);
        }
        
        [Test]
        public void GetDiscountPercentageValue_Should_Return25PercentDiscount_When_TotalPriceIs2500AndQuantityIs2()
        {
            var discountApplier = new DiscountApplier();
            var products = new[]{new Product("Product 1", 2000, 1), new Product("Product 2", 500, 1)};

            var discountValue = discountApplier.GetDiscountPercentageValue(products);
            Assert.AreEqual(25, discountValue);
        }
    }
}