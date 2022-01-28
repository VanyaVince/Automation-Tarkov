using System;
using Tarkov.Pages;
using Tarkov.Utils;

namespace Tarkov.Steps
{
    public class ProductPageSteps
    {
        private readonly ProductPage _productPage;

        public ProductPageSteps()
        {
            _productPage = new ProductPage();
        }

        public bool IsProductPriceEqualTo(int expectedPrice)
        {
            string productPrice = ParsingHelper.ParseProductPrice(_productPage.GetProductPrice());
            return Int32.Parse(productPrice) == expectedPrice;
        }
    }
}
