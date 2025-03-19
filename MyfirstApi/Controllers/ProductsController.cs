using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyfirstApi.Models;
namespace MyfirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts([FromQuery] QueryParameter queryParameter)
        {
            IQueryable<Product> products = _context.products;
            products = products.Skip(queryParameter.Size * (queryParameter.Page - 1)).Take(queryParameter.Size);
            return Ok(await products.ToArrayAsync());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                "GetProducts",
                new { id = product.Id },
                product
                );

        }
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Product>> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.products.Any(p => p.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();

        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }


}

