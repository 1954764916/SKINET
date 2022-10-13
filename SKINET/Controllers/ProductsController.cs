using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SKINET.Data;


namespace SKINET.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
           
        }
        
        
        [HttpGet]
        public async Task< ActionResult<List<Product>> >GetProducts()
        {
            var products =await _context.Products.ToListAsync();
            return Ok(products);
        }
        // async
        // http: //localhost:17718/api/products
        //[{"id":1,"name":"Product one"},{"id":2,"name":"Produce two"},{"id":3,"name":"Produce three"}]

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        //∑«async
        //http: //localhost:5000/api/products
        //this will be a list of products

        //http: //localhost:5000/api/products/2 ªÚ’ﬂ
        //http: //localhost:5000/api/products/3456
        //single product

        //async 
        //{"id":2,"name":"Produce two"}
        //http: //localhost:17718/api/products/2
    }
}