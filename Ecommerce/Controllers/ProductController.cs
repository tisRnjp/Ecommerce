using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.EF.Model;
using Ecommerce.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductController(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }

        // GET: api/Product
        [HttpGet]
        public ActionResult<IEnumerable<Products>> Get()
        {
            try
            {
                var products = _productRepo.GetAll().ToList();

                if (products.Any())
                {
                    return _productRepo.GetAll().ToList();
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Get a product of certain ID
        /// </summary>
        /// <param name="id">ID of a product</param>
        /// <returns>Product details</returns>
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Products> Get(int id)
        {
            try
            {
                var product = _productRepo.Get(id);

                if(product != null)
                {
                    return product;
                }
                else
                {
                    return NotFound();
                }

            }
            catch
            {
                return NotFound();
            }
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult Create([FromBody] Products product)
        {
            try
            {
                _productRepo.Add(product);
                _productRepo.SaveChanges();
                var newProduct = _productRepo.Find(p => p.ProductName == product.ProductName).FirstOrDefault();

                return CreatedAtAction(nameof(Get), new { id = newProduct.ProductId }, newProduct);
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Products product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            try
            {
                _productRepo.Update(product);
                _productRepo.SaveChanges();
            }
            catch
            {
                return BadRequest();
            }

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _productRepo.Get(id);
                
                if(product == null)
                {
                    return NotFound();
                }

                _productRepo.Remove(product);
                _productRepo.SaveChanges();

                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
