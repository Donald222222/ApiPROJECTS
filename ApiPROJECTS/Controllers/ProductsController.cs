using ApiPROJECTS.Data;
using ApiPROJECTS.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPROJECTS.Controllers
{

    [ApiController]

    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContentSeed _context;

        public ProductsController(StoreContentSeed context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var product = await _context.Products.ToList();

            return Ok(product);
        }
    }
}
