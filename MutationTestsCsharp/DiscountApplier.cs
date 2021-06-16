using System.Linq;

namespace MutationTestsCsharp
{
    public class DiscountApplier
    {
        public int GetDiscountPercentageValue(Product[] products) 
        {
            var discountValue = 0;
            if (products.Length == 1) {
                return 0;
            }

            var allProductsQuantity = products.Sum(p => p.Quantity);
    
            if (allProductsQuantity is > 10 and <= 50) {
                discountValue += 10;
            }
            if (allProductsQuantity > 50) {
                discountValue += 15;
            }

            var allProductsPrice = products.Sum(p => p.Quantity * p.Price);
    
            if (allProductsPrice is > 100 and <= 500) {
                discountValue += 5;
            }
            if (allProductsPrice is > 500 and <= 2000) {
                discountValue += 10;
            }
            if (allProductsPrice > 2000) {
                discountValue += 25;
            }
    
            return discountValue;
        }
    }
}