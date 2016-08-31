using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using ProductCatalogService.Models;
using ProductCatalogService.Exceptions;

namespace ProductCatalogService.DataLayer
{
    class InMemoryProductRepository : IProductRepository
    {
        private ConcurrentDictionary<string, Product> _products = new ConcurrentDictionary<string, Product>();

        public InMemoryProductRepository()
        {
            // TODO
            Add(new Product { Sku = "123", Name = "Watch", Description = "Gives accurate time." });
        }

        public void Add(Product item)
        {
            _products[item.Sku] = item;
        }

        public IEnumerable<Product> GetAll()
        {
            return _products.Values;
        }

        public Product Find(string sku)
        {
            Product product;
            var found = _products.TryGetValue(sku, out product);

            if (found == false)
            {
                throw new ProductNotFoundException(sku);
            }

            return product;
        }

        public void Remove(string sku)
        {
            Product item;
            var found = _products.TryRemove(sku, out item);
            
            if (found == false)
            {
                throw new ProductNotFoundException(sku);
            }
        }

        public void Update(Product item)
        {
            _products[item.Sku] = item;
        }
    }
}
