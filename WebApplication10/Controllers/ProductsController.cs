using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        //[HttpGet]
        //public string Get()
        //{
        //    return "Lots of products";
        //}

        //[HttpGet("{id}")]
        //public string GetById(int id, [FromQuery] bool isActive)
        //{
        //    return $"Lots of products: {id}, status: {isActive}";
        //}        

        
        [HttpGet]
        public string GetByObject([FromQuery] ProductDTO productDTO)
        {
            return $"product id: {productDTO.Id}, name: {productDTO.Name}";
        }

        [HttpPost]
        public IActionResult Post(ProductDTO productDTO)
        {
            return Ok($"product id: {productDTO.Id}, name: {productDTO.Name}");
        }
    }   
    
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
}
