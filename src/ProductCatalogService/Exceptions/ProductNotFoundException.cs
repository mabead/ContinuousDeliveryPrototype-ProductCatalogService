using System;

namespace ProductCatalogService.Exceptions
{
    class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string productSku)
            :base($"Product with SKU {productSku} does not exist.")
        {
            Sku = productSku;
        }

        public string Sku { get; }
    }
}
