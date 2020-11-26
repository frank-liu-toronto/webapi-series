using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Filters;

namespace WebApplication10.Controllers
{    
    [ApiController]
    [Route("api/v2/products")]       
    [DebugResourceFilter2]
    //[TokenAuthenticationFilter]
    [Authorize]
    public class ProductsV2Controller : ControllerBase
    {
        //[HttpGet]
        //public string Get()
        //{
        //    // Authentication / authoriaztion

        //    // Generic validation

        //    // Retrieve input data

        //    // Input data validation

        //    // Application logic

        //    // Format output data

        //    // Exception handling

        //    return "Lots of products";
        //}

        [HttpGet("{id}")]
        [DebugResourceFilter3]
        public string GetById(int id, [FromQuery] bool isActive)
        {
            return $"Lots of products: {id}, status: {isActive}";
        }


        [HttpGet]
        [DebugActionFilter]
        public string GetByObject([FromQuery] ProductDTO productDTO)
        {
            return $"product id: {productDTO.Id}, name: {productDTO.Name}";
        }

        [HttpGet("daterange")]
        [EnsureCorrectDateRange]
        public string GetByDateRange(DateTime beginDate, DateTime endDate)
        {
            return "Here is your list of products.";
        }

        [HttpPost]
        public IActionResult Post(ProductDTO productDTO)
        {   
            return Ok($"product id: {productDTO.Id}, name: {productDTO.Name}");
        }


    }      
    
    
}
