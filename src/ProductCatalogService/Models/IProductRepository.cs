﻿using System.Collections.Generic;

namespace ProductCatalogService.Models
{
    public interface IProductRepository
    {
        void Add(Product item);

        IEnumerable<Product> GetAll();

        Product Find(string key);

        void Remove(string key);

        void Update(Product item);
    }
}
