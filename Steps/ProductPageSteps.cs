using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class ProductPageSteps
    {
        private readonly ProductPage _productPage;

        public ProductPageSteps()
        {
            _productPage = new ProductPage();
        }

        public bool IsProductPriceEqualTo(int price)
        {
            var productPrice = _productPage.GetProductPrice().Replace("₽", "").Trim();
            Console.WriteLine($"product price is equal to - {productPrice}");

            int convertedPrice = Int32.Parse(productPrice);
            return convertedPrice == price;
        }
    }
}
