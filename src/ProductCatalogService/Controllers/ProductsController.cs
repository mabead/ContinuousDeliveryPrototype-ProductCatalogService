using Microsoft.AspNetCore.Mvc;
using ProductCatalogService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogService.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productRepository)
        {
            _productsRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productsRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetProducts")]
        public IActionResult GetById(string id)
        {
            var item = _productsRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
